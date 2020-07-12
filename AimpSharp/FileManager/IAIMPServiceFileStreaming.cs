using AimpSharp.FileManager.Enums;
using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-5372-7646-696C-655374726D00")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceFileStreaming
	{
		[PreserveSig] HRESULT CreateStreamForFile(IAIMPString FileName, FlagsFileStreaming Flags, long Offset, long Size, out IAIMPStream Stream);
		[PreserveSig] HRESULT CreateStreamForFileURI(IAIMPString FileURI, out IAIMPVirtualFile VirtualFile, out IAIMPStream Stream);
	}
}