using AimpYouTubeDL.Api.GUI.Enum;
using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPServiceUI_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceUI
	{
		[PreserveSig] HRESULT CreateControl(IAIMPUIForm Owner, IAIMPUIWinControl Parent, IAIMPString Name, [MarshalAs(UnmanagedType.IUnknown)] object EventsHandler, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Control);
		[PreserveSig] HRESULT CreateForm(IntPtr OwnerWindow, FlagsServiceCreateForm Flags, IAIMPString Name, [MarshalAs(UnmanagedType.IUnknown)] object EventsHandler, out IAIMPUIForm Form);
		[PreserveSig] HRESULT CreateObject(IAIMPUIForm Owner, [MarshalAs(UnmanagedType.IUnknown)] object EventsHandler, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
	}
}