using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIKeyboardEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIKeyboardEvents
	{
		[PreserveSig] void OnEnter([MarshalAs(UnmanagedType.IUnknown)] object Sender);
		[PreserveSig] void OnExit([MarshalAs(UnmanagedType.IUnknown)] object Sender);
		[PreserveSig] void OnKeyDown([MarshalAs(UnmanagedType.IUnknown)] object Sender, ref ushort Key, short Modifiers);
		[PreserveSig] void OnKeyPress([MarshalAs(UnmanagedType.IUnknown)] object Sender, ref char Key);
		[PreserveSig] void OnKeyUp([MarshalAs(UnmanagedType.IUnknown)] object Sender, ref ushort Key, short Modifiers);
	}
}