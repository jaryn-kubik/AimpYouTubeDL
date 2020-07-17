using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41465343-6D64-4669-6C65-466C64720000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPFileSystemCommandOpenFileFolder : IAIMPFileSystemCustomFileCommand
	{
	}
}