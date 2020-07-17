using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIBrowseFolderDialog_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIBrowseFolderDialog
	{
		[PreserveSig] HRESULT Execute(IntPtr OwnerWnd, int Flags, IAIMPString DefaultPath, out IAIMPObjectList Selection);
	}
}