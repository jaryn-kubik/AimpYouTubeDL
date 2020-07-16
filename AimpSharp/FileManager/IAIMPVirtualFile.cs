using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-5669-7274-7561-6C46696C6500")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPVirtualFile : IAIMPPropertyList
	{
		[PreserveSig] HRESULT CreateStream(out IAIMPStream Stream);
		[PreserveSig] HRESULT GetFileInfo(IAIMPFileInfo Info);
		[PreserveSig] HRESULT IsExists();
		[PreserveSig] HRESULT IsInSameStream(IAIMPVirtualFile VirtualFile);
		[PreserveSig] HRESULT Synchronize();
	}
}