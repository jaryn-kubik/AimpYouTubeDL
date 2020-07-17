using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.Core;
using AimpYouTubeDL.Api.Objects;
using AimpYouTubeDL.YouTube;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace AimpYouTubeDL.Utils
{
	public static class Helpers
	{
		public static bool TryCatch(Action action)
		{
			try
			{
				action();
				return true;
			}
			catch (Exception ex)
			{
				HandleException(ex);
				return false;
			}
		}

		public static bool TryCatch(Func<bool> func)
		{
			try
			{
				return func();
			}
			catch (Exception ex)
			{
				HandleException(ex);
				return false;
			}
		}

		public delegate bool TryCatchWithResult<TValue, TResult>(TValue value, out TResult result);
		public static bool TryCatch<TValue, TResult>(TryCatchWithResult<TValue, TResult> func, TValue value, out TResult result)
		{
			try
			{
				return func(value, out result);
			}
			catch (Exception ex)
			{
				HandleException(ex);
				result = default;
				return false;
			}
		}

		private static void HandleException(Exception ex)
		{
			Trace.Fail(ex.ToString());
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static VisualStyle GetVisualStyle()
		{
			try
			{
				PluginWrapper.Core.GetService<IAIMPServiceConfig>().GetValueAsInt32(PluginWrapper.Core.CreateString("System\\NightMode"), out var mode).EnsureSuccess();
				if (mode == 2)
				{
					return VisualStyle.Dark;
				}
				if (mode == 0 && Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1")?.ToString() == "0")
				{
					return VisualStyle.Dark;
				}
			}
			catch { }
			return VisualStyle.Light;
		}

		public static bool TryGetInfo(this IAIMPString str, out YouTubeDLInfo info)
		{
			return str.GetData().TryGetInfo(out info);
		}

		public static bool TryGetInfo(this string str, out YouTubeDLInfo info)
		{
			if (str.StartsWith(Plugin.Scheme))
			{
				var url = str.Substring(Plugin.Scheme.Length);
				info = Plugin.YouTube.GetInfo(url).Single();
				return true;
			}
			info = null;
			return false;
		}
	}
}