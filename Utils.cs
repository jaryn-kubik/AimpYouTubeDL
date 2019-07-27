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
	}
}