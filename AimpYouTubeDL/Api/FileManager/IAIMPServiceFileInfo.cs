using AimpYouTubeDL.Api.FileManager.Enums;
using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.FileManager
{
	[ComImport]
	[Guid("41494D50-5372-7646-696C-65496E666F00")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceFileInfo
	{
		[PreserveSig] HRESULT GetFileInfoFromFileURI(IAIMPString FileURI, FlagsFileInfo Flags, IAIMPFileInfo Info);
		[PreserveSig] HRESULT GetFileInfoFromStream(IAIMPStream Stream, FlagsFileInfo Flags, IAIMPFileInfo Info);

		[PreserveSig] HRESULT GetVirtualFile(IAIMPString FileURI, int Flags, out IAIMPVirtualFile Info);
	}
}