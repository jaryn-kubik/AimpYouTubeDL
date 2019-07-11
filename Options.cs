using AIMP.SDK.Player;
using System.Runtime.CompilerServices;

namespace AIMPYoutubeDL
{
	public class Options
	{
		private const string _key = "YouTubeDL\\";
		private readonly IAimpPlayer _player;

		public Options(IAimpPlayer player)
		{
			_player = player;
			_autoUpdate = GetBool(nameof(AutoUpdate), false);
			_format = GetString(nameof(Format), "best[ext=mp4]/best");
		}

		private bool _autoUpdate;
		private string _format;

		public bool AutoUpdate
		{
			get => _autoUpdate;
			set => Set(_autoUpdate = value);
		}

		public string Format
		{
			get => _format;
			set => Set(_format = value.Trim());
		}

		private string GetStringInt(string key)
		{
			return _player.ServiceConfig.GetValueAsString(_key + key);
		}

		private string GetString(string key, string def)
		{
			var str = GetStringInt(key);
			if (!string.IsNullOrWhiteSpace(str))
			{
				return str;
			}
			return def;
		}

		private bool GetBool(string key, bool def)
		{
			var str = GetStringInt(key);
			if (!string.IsNullOrWhiteSpace(str) && bool.TryParse(str, out var result))
			{
				return result;
			}
			return def;
		}

		private void Set(object value, [CallerMemberName] string key = null)
		{
			_player.ServiceConfig.SetValueAsString(_key + key, value.ToString());
		}
	}
}