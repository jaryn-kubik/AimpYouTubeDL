using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIInputDialog_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIInputDialog
	{
		[PreserveSig] HRESULT Execute(IntPtr OwnerWnd, IAIMPString Caption, [MarshalAs(UnmanagedType.IUnknown)] object EventsHandler, IAIMPString Text, IntPtr Value);
		[PreserveSig] HRESULT Execute2(IntPtr OwnerWnd, IAIMPString Caption, [MarshalAs(UnmanagedType.IUnknown)] object EventsHandler, IAIMPObjectList TextForValues, IntPtr Values, int ValueCount);
	}
}