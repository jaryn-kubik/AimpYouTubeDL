using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Plugin
{
	[ComImport]
	[Guid(IID.IAIMPExternalSettingsDialog_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExternalSettingsDialog
	{
		[PreserveSig] void Show(IntPtr ParentWindow);
	}
}