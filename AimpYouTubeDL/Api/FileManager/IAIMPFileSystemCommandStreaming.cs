using AimpYouTubeDL.Api.FileManager.Enums;
using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.FileManager
{
	[ComImport]
	[Guid("41465343-6D64-5374-7265-616D696E6700")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPFileSystemCommandStreaming
	{
		[PreserveSig] HRESULT CreateStream(IAIMPString FileName, long Offset, long Size, FlagsFileStreaming Flags, out IAIMPStream Stream);
	}
}