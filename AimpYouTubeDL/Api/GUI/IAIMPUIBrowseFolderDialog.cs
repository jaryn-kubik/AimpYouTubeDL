using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIBrowseFolderDialog_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIBrowseFolderDialog
	{
		[PreserveSig] HRESULT Execute(IntPtr OwnerWnd, int Flags, IAIMPString DefaultPath, out IAIMPObjectList Selection);
	}
}