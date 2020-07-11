using System;

namespace AimpSharp.Plugin
{
	public static class IID
	{
		public const string IAIMPPlugin_IID = "4FE9FD09-6C16-4265-88D7-14AFF1C8FD46";
		public static readonly Guid IAIMPPlugin = new Guid(IAIMPPlugin_IID);

		public const string IAIMPExternalSettingsDialog_IID = "41494D50-4578-7472-6E4F-7074446C6700";
		public static readonly Guid IAIMPExternalSettingsDialog = new Guid(IAIMPExternalSettingsDialog_IID);
	}
}