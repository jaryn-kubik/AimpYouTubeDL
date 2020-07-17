using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIMouseWheelEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIMouseWheelEvents
	{
		[PreserveSig] bool OnMouseWheel([MarshalAs(UnmanagedType.IUnknown)] object Sender, int WheelDelta, int X, int Y, short Modifiers);
	}
}