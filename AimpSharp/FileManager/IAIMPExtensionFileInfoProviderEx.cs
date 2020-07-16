using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-4578-7446-696C-65496E666F45")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionFileInfoProviderEx
	{
		[PreserveSig] HRESULT GetFileInfo(IAIMPStream Stream, IAIMPFileInfo Info);
	}
}