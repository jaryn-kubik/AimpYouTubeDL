using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIBaseButtonnedEdit_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIBaseButtonnedEdit : IAIMPUIBaseEdit
	{
		[PreserveSig] HRESULT AddButton([MarshalAs(UnmanagedType.IUnknown)] object EventsHandler, out IAIMPUIEditButton Button);
		[PreserveSig] HRESULT DeleteButton(int Index);
		[PreserveSig] HRESULT DeleteButton2(IAIMPUIEditButton Button);
		[PreserveSig] HRESULT GetButton(int Index, out IAIMPUIEditButton Button);
		[PreserveSig] int GetButtonCount();
	}
}