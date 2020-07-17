using AimpYouTubeDL.Api.GUI.Enums;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIMouseEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIMouseEvents
	{
		[PreserveSig] void OnMouseDoubleClick([MarshalAs(UnmanagedType.IUnknown)] object Sender, TAIMPUIMouseButton Button, int X, int Y, short Modifiers);
		[PreserveSig] void OnMouseDown([MarshalAs(UnmanagedType.IUnknown)] object Sender, TAIMPUIMouseButton Button, int X, int Y, short Modifiers);
		[PreserveSig] void OnMouseLeave([MarshalAs(UnmanagedType.IUnknown)] object Sender);
		[PreserveSig] void OnMouseMove([MarshalAs(UnmanagedType.IUnknown)] object Sender, int X, int Y, short Modifiers);
		[PreserveSig] void OnMouseUp([MarshalAs(UnmanagedType.IUnknown)] object Sender, TAIMPUIMouseButton Button, int X, int Y, short Modifiers);
	}
}