using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPFileStream_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPFileStream : IAIMPStream
	{
		[PreserveSig] HRESULT GetClipping(out long Offset, out long Size);
		[PreserveSig] HRESULT GetFileName(out IAIMPString S);
	}
}