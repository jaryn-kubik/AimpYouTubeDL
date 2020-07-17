using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUILabel_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUILabel : IAIMPUIControl
	{
	}
}