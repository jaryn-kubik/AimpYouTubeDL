using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.AlbumArt;
using AimpYouTubeDL.Api.Core;
using AimpYouTubeDL.Api.Core.Enums;
using AimpYouTubeDL.Api.Menu;
using AimpYouTubeDL.Api.Menu.Enums;
using AimpYouTubeDL.Api.Options;
using AimpYouTubeDL.Api.Player;
using AimpYouTubeDL.Config;
using AimpYouTubeDL.Hooks;
using AimpYouTubeDL.Utils;
using AimpYouTubeDL.YouTube;
using System;
using System.Diagnostics;
using System.IO;

namespace AimpYouTubeDL
{
	public static class Plugin
	{
		public const string Name = "aimp_youtubedl";
		public const string NameFriendly = "YouTube-DL";
		public const string Scheme = @"ydl:\\";

		public static string Version => typeof(Plugin).Assembly.GetName().Version.ToString();
		public static Options Options { get; private set; }
		public static YouTubeDL YouTube { get; private set; }

		public static void Init(IntPtr ptr)
		{
			PluginWrapper.Init(ptr, NameFriendly, "cubis12321", "Support for playing audio from sites supported by youtube-dl", Initialize, Dispose);
		}

		private static bool Initialize()
		{
			return Helpers.TryCatch(() =>
			{
				PluginWrapper.Core.GetPath(CorePath.AIMP_CORE_PATH_PROFILE, out var dirProfile).EnsureSuccess();
				var dirAppData = Path.Combine(dirProfile.GetData(), Name);
				Directory.CreateDirectory(dirAppData);

				Trace.Listeners.Clear();
				Trace.Listeners.Add(new Logger(dirAppData));

				if (PluginWrapper.Core.GetService<IAIMPServiceMenuManager>().GetBuiltIn(MenuId.AIMP_MENUID_PLAYER_PLAYLIST_ADDING, out var _) != HRESULT.S_OK)
				{
					Trace.Fail("MenuManager not available.");
					return false;
				}

				Options = Options.Load(dirAppData);
				YouTube = new YouTubeDL(dirAppData);
				if (Options.AutoUpdate)
				{
					YouTube.Update();
				}

				PluginWrapper.Core.RegisterExtension<IAIMPServicePlayer>(new PlayerHook());
				PluginWrapper.Core.RegisterExtension<IAIMPServicePlaybackQueue>(new PlaybackQueue());

				PluginWrapper.Core.RegisterExtension<IAIMPServiceOptionsDialog>(new OptionsFrame());
				Menu.AddPlaylistAddingMenu();

				PluginWrapper.Core.RegisterExtension<IAIMPServiceAlbumArt>(new AlbumArtProvider());
				return true;
			});
		}

		private static bool Dispose()
		{
			return Helpers.TryCatch(() =>
			{
				YouTube?.Dispose();
				YouTube = null;
				Options = null;
			});
		}
	}
}