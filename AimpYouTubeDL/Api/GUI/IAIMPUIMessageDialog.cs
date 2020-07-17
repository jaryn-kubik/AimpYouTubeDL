using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIMessageDialog_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIMessageDialog
	{
		[PreserveSig] HRESULT Execute(IntPtr OwnerWnd, IAIMPString Caption, IAIMPString Text, int Flags);
	}
}