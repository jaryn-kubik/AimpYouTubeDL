using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIInputDialogEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIInputDialogEvents
	{
		[PreserveSig] HRESULT OnValidate(IntPtr/*VARIANT*/ Value, int ValueIndex);
	}
}