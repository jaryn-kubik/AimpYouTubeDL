using AimpYouTubeDL.Api.FileManager.Enums;
using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.FileManager
{
	[ComImport]
	[Guid("41494D50-5372-7646-696C-65466D747300")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceFileFormats
	{
		[PreserveSig] HRESULT GetFormats(FlagsFileFormats Flags, out IAIMPString S);
		[PreserveSig] HRESULT IsSupported(IAIMPString FileName, FlagsFileFormats Flags);
	}
}