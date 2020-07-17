using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUITabControlEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUITabControlEvents : IAIMPUIChangeEvents
	{
		[PreserveSig] void OnActivating(IAIMPUITabControl Sender, int TabIndex, ref bool Allow);
		[PreserveSig] void OnActivated(IAIMPUITabControl Sender, int TabIndex);
	}
}