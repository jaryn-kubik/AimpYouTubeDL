using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIPageControlEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIPageControlEvents
	{
		[PreserveSig] void OnActivating(IAIMPUIPageControl Sender, IAIMPUITabSheet Page, ref bool Allow);
		[PreserveSig] void OnActivated(IAIMPUIPageControl Sender, IAIMPUITabSheet Page);
	}
}