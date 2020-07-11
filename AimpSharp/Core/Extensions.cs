using System;

namespace AimpSharp.Core
{
	public static class Extensions
	{
		public static T CreateObject<T>(this IAIMPCore core, ref Guid guid)
		{
			core.CreateObject(guid, out var obj).EnsureSuccess();
			return (T)obj;
		}
	}
}