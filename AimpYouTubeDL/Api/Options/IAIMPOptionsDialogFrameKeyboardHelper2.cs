using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Options
{
	[ComImport]
	[Guid("41494D50-4F70-7444-6C67-46726D4B4832")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPOptionsDialogFrameKeyboardHelper2
	{
		[PreserveSig] bool SelectLastControl();
	}
}