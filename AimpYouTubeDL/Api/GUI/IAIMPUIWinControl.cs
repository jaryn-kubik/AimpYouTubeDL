using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIWinControl_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIWinControl : IAIMPUIControl
	{
		[PreserveSig] HRESULT GetControl(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetControlCount();
		[PreserveSig] IntPtr GetHandle();
		[PreserveSig] bool HasHandle();
		[PreserveSig] HRESULT SetFocus();
	}
}