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
		}

		public bool AutoUpdate
		{
			get => GetBool(false);
			set => Set(value);
		}

		public string Format
		{
			get => GetString("best[ext=mp4]/best");
			set => Set(value);
		}

		private string GetStringInt(string key)
		{
			return _player.ServiceConfig.GetValueAsString(_key + key);
		}

		private string GetString(string def, [CallerMemberName] string key = null)
		{
			var str = GetStringInt(key);
			if (!string.IsNullOrEmpty(str))
			{
				return str;
			}
			return def;
		}

		private bool GetBool(bool def, [CallerMemberName] string key = null)
		{
			var str = GetStringInt(key);
			if (!string.IsNullOrEmpty(str) && bool.TryParse(str, out var result))
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