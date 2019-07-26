using AIMP.SDK;
using System;
using System.IO;
using System.Reflection;

namespace AIMPYoutubeDL
{
	[AimpPlugin(PluginName, "cubis12321", PluginVersion, AimpPluginType = AimpPluginType.Addons, Description = "Support for playing audio from sites supported by youtube-dl")]
	public class Plugin : AimpPlugin
	{
		public const string PluginName = "YouTube-DL";
		public const string PluginVersion = "0.3";
		private const string _name = "aimp_youtubedl";

		private Options _options;
		private YouTubeDL _ytb;
		private Playback _playback;
		private OptionsFrame _optionsFrame;

		public override void Initialize()
		{
			Utils.HandleException(() =>
			{
				AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

				_options = new Options(Player);

				_ytb = new YouTubeDL(Path.Combine(Player.Core.GetPath(AimpMessages.AimpCorePathType.AIMP_CORE_PATH_PROFILE), _name), _options);
				if (_options.AutoUpdate)
				{
					_ytb.Update();
				}

				_playback = new Playback(Player, _ytb);
				_optionsFrame = new OptionsFrame(Player, _ytb, _options);
			});
		}

		public override void Dispose()
		{
			Utils.HandleException(() =>
			{
				Utils.Dispose(ref _optionsFrame);
				Utils.Dispose(ref _playback);
				Utils.Dispose(ref _ytb);

				AppDomain.CurrentDomain.AssemblyResolve -= CurrentDomain_AssemblyResolve;
			});
		}

		private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			if (args.Name.StartsWith("aimp_dotnet"))
			{
				return Assembly.LoadFrom($"{_name}\\{_name}.dll");
			}
			return null;
		}
	}
}