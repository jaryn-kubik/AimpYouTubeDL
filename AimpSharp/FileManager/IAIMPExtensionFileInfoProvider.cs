using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-4578-7446-696C-65496E666F00")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionFileInfoProvider
	{
		[PreserveSig] HRESULT GetFileInfo(IAIMPString FileURI, IAIMPFileInfo Info);
	}
}