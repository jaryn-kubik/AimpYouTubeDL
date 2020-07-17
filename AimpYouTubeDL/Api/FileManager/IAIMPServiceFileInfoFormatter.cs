using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.FileManager
{
	[ComImport]
	[Guid("41494D50-5372-7646-6C49-6E66466D7400")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceFileInfoFormatter
	{
		[PreserveSig] HRESULT Format(IAIMPString Template, IAIMPFileInfo FileInfo, int Reserved, [MarshalAs(UnmanagedType.IUnknown)] object AdditionalInfo, out IAIMPString FormattedResult);
	}
}