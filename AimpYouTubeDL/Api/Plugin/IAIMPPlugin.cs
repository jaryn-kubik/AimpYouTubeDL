using AimpYouTubeDL.Api.Core;
using AimpYouTubeDL.Api.Plugin.Enums;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Plugin
{
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlugin
	{
		[return: MarshalAs(UnmanagedType.LPWStr)]
		[PreserveSig] string InfoGet(PluginInfo Index);
		[PreserveSig] PluginCategory InfoGetCategories();

		[PreserveSig] HRESULT Initialize(IAIMPCore Core);
		[PreserveSig] HRESULT Finalize();

		[PreserveSig] void SystemNotification(SystemNotification NotifyID, IntPtr Data);
	}
}