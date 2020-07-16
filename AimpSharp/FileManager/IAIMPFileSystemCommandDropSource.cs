using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41465343-6D64-4472-6F70-537263000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPFileSystemCommandDropSource
	{
		[PreserveSig] HRESULT CreateStream(IAIMPString FileName, out IAIMPStream Stream);
	}
}