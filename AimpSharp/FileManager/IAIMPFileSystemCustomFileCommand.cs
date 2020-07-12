using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-4653-0000-0000-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPFileSystemCustomFileCommand
	{
		[PreserveSig] HRESULT CanProcess(IAIMPString FileName);
		[PreserveSig] HRESULT Process(IAIMPString FileName);
	}
}