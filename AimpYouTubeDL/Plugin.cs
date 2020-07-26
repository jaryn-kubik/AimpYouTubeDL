using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.AlbumArt;
using AimpYouTubeDL.Api.Core;
using AimpYouTubeDL.Api.Core.Enums;
using AimpYouTubeDL.Api.Menu;
using AimpYouTubeDL.Api.Menu.Enums;
using AimpYouTubeDL.Api.Options;
using AimpYouTubeDL.Api.Player;
using AimpYouTubeDL.Api.Plugins;
using AimpYouTubeDL.Api.Plugins.Enums;
using AimpYouTubeDL.Config;
using AimpYouTubeDL.Hooks;
using AimpYouTubeDL.Utils;
using AimpYouTubeDL.YouTube;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace AimpYouTubeDL
{
	public sealed class Plugin : IAIMPPlugin
	{
		public const string Name = "aimp_youtubedl";
		public const string NameFriendly = "YouTube-DL";
		public const string Scheme = @"ydl:\\";

		private int _threadId;
		private IntPtr _corePtr;
		private IAIMPCore _core;
		private Options _options;
		private YouTubeDL _youtube;

		public static IAIMPCore Core => Instance.GetCore();
		public static string Version => typeof(Plugin).Assembly.GetName().Version.ToString();
		public static Options Options => Instance._options;
		public static YouTubeDL YouTube => Instance._youtube;

		private Plugin() { }
		public static Plugin Instance { get; private set; }
		public static Plugin Init() => Instance = new Plugin();

		public string InfoGet(PluginInfo Index)
		{
			return Index switch
			{
				PluginInfo.AIMP_PLUGIN_INFO_NAME => NameFriendly,
				PluginInfo.AIMP_PLUGIN_INFO_AUTHOR => "cubis12321",
				PluginInfo.AIMP_PLUGIN_INFO_SHORT_DESCRIPTION => "Support for playing audio from sites supported by youtube-dl",
				_ => null
			};
		}

		public PluginCategory InfoGetCategories()
		{
			return PluginCategory.AIMP_PLUGIN_CATEGORY_ADDONS;
		}

		private void Collect()
		{
			Marshal.CleanupUnusedObjectsInCurrentContext();
			GC.WaitForPendingFinalizers();
			for (var i = 0; i <= GC.MaxGeneration; i++)
			{
				GC.Collect();
			}
		}

		private IAIMPCore GetCore()
		{
			var threadId = Thread.CurrentThread.ManagedThreadId;
			if (threadId == _threadId)
			{
				return _core;
			}
			Trace.WriteLine("Creating IAIMPCore instance", nameof(Plugin));
			return (IAIMPCore)Marshal.GetUniqueObjectForIUnknown(_corePtr);
		}

		public HRESULT Initialize(IAIMPCore core)
		{
			_threadId = Thread.CurrentThread.ManagedThreadId;
			_corePtr = Marshal.GetIUnknownForObject(core);
			_core = core;

			AppDomain.CurrentDomain.UnhandledException += (s, e) => Helpers.HandleException(e.ExceptionObject as Exception);
			TaskScheduler.UnobservedTaskException += (s, e) => { Helpers.HandleException(e.Exception); e.SetObserved(); };

			var result = Helpers.TryCatch(() =>
			{
				core.GetPath(CorePath.AIMP_CORE_PATH_PROFILE, out var dirProfile).EnsureSuccess();
				var dirAppData = Path.Combine(dirProfile.GetData(), Name);
				Directory.CreateDirectory(dirAppData);

				Trace.Listeners.Clear();
				Trace.Listeners.Add(new Logger(dirAppData));

				if (core.GetService<IAIMPServiceMenuManager>().GetBuiltIn(MenuId.AIMP_MENUID_PLAYER_PLAYLIST_ADDING, out var _) != HRESULT.S_OK)
				{
					Trace.Fail("MenuManager not available.");
					return false;
				}

				Trace.WriteLine(nameof(Initialize) + "Start", nameof(Plugin));
				_options = Options.Load(dirAppData);
				_youtube = new YouTubeDL(dirAppData);
				Task.Run(YouTube.Update);

				core.RegisterExtension<IAIMPServicePlayer>(new PlayerHook());
				core.RegisterExtension<IAIMPServicePlaybackQueue>(new PlaybackQueue());
				core.RegisterExtension<IAIMPServiceAlbumArt>(new AlbumArtProvider());

				core.RegisterExtension<IAIMPServiceOptionsDialog>(new OptionsFrame());
				Menu.AddPlaylistAddingMenu();
				return true;
			});
			Collect();
			Trace.WriteLine(nameof(Initialize) + "End", nameof(Plugin));
			return result.ToHRESULT();
		}

		public HRESULT Finalize()
		{
			Trace.WriteLine(nameof(Finalize) + "Start", nameof(Plugin));
			var result = Helpers.TryCatch(() =>
			{
				_youtube?.Dispose();
				_youtube = null;
				_options = null;
				Marshal.FinalReleaseComObject(_core);
				Collect();
			});
			Trace.WriteLine(nameof(Finalize) + "End", nameof(Plugin));
			return result.ToHRESULT();
		}

		public void SystemNotification(SystemNotification NotifyId, IntPtr Data) { }
	}
}