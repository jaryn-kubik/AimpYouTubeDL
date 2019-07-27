using System;
using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public static class Utils
	{
		public static bool TryHandleException(Action action)
		{
			try
			{
				action();
				return true;
			}
			catch (Exception ex)
			{
				ShowException(ex);
				return false;
			}
		}

		public static bool TryHandleException<T>(Func<T> func, out T result)
		{
			try
			{
				result = func();
				return true;
			}
			catch (Exception ex)
			{
				ShowException(ex);
				result = default;
				return false;
			}
		}

		private static void ShowException(Exception ex)
		{
			MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void Dispose<T>(ref T obj)
			where T : class, IDisposable
		{
			obj?.Dispose();
			obj = null;
		}
	}
}