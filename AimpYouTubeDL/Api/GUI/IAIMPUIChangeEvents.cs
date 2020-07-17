using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIChangeEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIChangeEvents
	{
		[PreserveSig] void OnChanged([MarshalAs(UnmanagedType.IUnknown)] object Sender);
	}
}