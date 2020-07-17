using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.FileManager
{
	[ComImport]
	[Guid("41465343-6D64-4465-6C65-746500000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPFileSystemCommandDelete : IAIMPFileSystemCustomFileCommand
	{
	}
}