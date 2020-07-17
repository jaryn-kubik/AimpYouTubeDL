using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Options
{
	[ComImport]
	[Guid("41494D50-4F70-7444-6C67-4672616D6500")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPOptionsDialogFrame
	{
		[PreserveSig] HRESULT GetName(out IAIMPString S);
		[PreserveSig] IntPtr CreateFrame(IntPtr ParentWnd);
		[PreserveSig] void DestroyFrame();
		[PreserveSig] void Notification(NotificationOptionsDialog ID);
	}
}