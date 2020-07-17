using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIPlacementEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIPlacementEvents
	{
		[PreserveSig] void OnBoundsChanged([MarshalAs(UnmanagedType.IUnknown)] object Sender);
	}
}