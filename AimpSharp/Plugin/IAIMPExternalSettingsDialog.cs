using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Plugin
{
	[ComImport]
	[Guid("41494D50-4578-7472-6E4F-7074446C6700")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExternalSettingsDialog
	{
		[PreserveSig] void Show(IntPtr ParentWindow);
	}
}