using AIMP.SDK.Player;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public static class Utils
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

		public static bool TryCatch<T, TResult>(Func<T, TResult> func, T value, out TResult result)
		{
			try
			{
				result = func(value);
				return true;
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

		public static void Dispose<T>(ref T obj)
			where T : class, IDisposable
		{
			obj?.Dispose();
			obj = null;
		}

		public static VisualStyle GetVisualStyle(IAimpPlayer player)
		{
			try
			{
				var mode = player.ServiceConfig.GetValueAsInt32("System\\NightMode");
				if (mode == 2 || (mode == 0 && Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1")?.ToString() == "0"))
				{
					return VisualStyle.Dark;
				}
			}
			catch { }
			return VisualStyle.Light;
		}
	}
}