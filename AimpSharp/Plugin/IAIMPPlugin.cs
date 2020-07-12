using AimpSharp.Core;
using AimpSharp.Plugin.Enums;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Plugin
{
	[ComImport]
	[Guid(IID.IAIMPPlugin_IID)]
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