using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Options
{
	[ComImport]
	[Guid("41494D50-5372-764F-7074-446C67000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceOptionsDialog
	{
		[PreserveSig] HRESULT FrameModified(IAIMPOptionsDialogFrame Frame);
		[PreserveSig] HRESULT FrameShow(IAIMPOptionsDialogFrame Frame, bool ForceShow);
	}
}