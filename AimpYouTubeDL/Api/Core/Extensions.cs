namespace AimpYouTubeDL.Api.Core
{
	public static class Extensions
	{
		public static T CreateObject<T>(this IAIMPCore core)
		{
			core.CreateObject(typeof(T).GUID, out var obj).EnsureSuccess();
			return (T)obj;
		}

		public static T GetService<T>(this IAIMPCore core)
		{
			return (T)core;
		}

		public static void RegisterExtension<T>(this IAIMPCore core, object extension)
		{
			core.RegisterExtension(typeof(T).GUID, extension).EnsureSuccess();
		}
	}
}