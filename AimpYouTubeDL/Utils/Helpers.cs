using AimpSharp;
using AimpSharp.Core;
using AimpSharp.Objects;
using System;
using System.Diagnostics;
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
	}
}