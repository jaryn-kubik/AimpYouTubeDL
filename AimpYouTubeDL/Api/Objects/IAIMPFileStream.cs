using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Objects
{
	[ComImport]
	[Guid("41494D50-4669-6C65-5374-7265616D0000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPFileStream : IAIMPStream
	{
		[PreserveSig] HRESULT GetClipping(out long Offset, out long Size);
		[PreserveSig] HRESULT GetFileName(out IAIMPString S);
	}
}