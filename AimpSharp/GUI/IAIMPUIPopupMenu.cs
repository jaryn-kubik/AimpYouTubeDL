using AimpSharp.Objects;
using AimpSharp.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIPopupMenu_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIPopupMenu
	{
		[PreserveSig] HRESULT Add(IAIMPString ID, out IAIMPUIMenuItem MenuItem);
		[PreserveSig] HRESULT Delete(int Index);
		[PreserveSig] HRESULT DeleteChildren();
		[PreserveSig] HRESULT Get(int index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object MenuItem);
		[PreserveSig] int GetCount();
		[PreserveSig] HRESULT Popup(POINT ScreenPoint);
		[PreserveSig] HRESULT Popup2(RECT ScreenRect);
	}
}