using System;
using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public static class Utils
	{
		public static void HandleException(Action action)
		{
			try
			{
				action();
			}
			catch (Exception ex)
			{
				ShowException(ex);
				throw;
			}
		}

		public static T HandleException<T>(Func<T> func)
		{
			try
			{
				return func();
			}
			catch (Exception ex)
			{
				ShowException(ex);
				throw;
			}
		}

		public static void ShowException(Exception ex)
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