using AimpSharp.FileManager.Enums;
using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-4578-7446-696C-65466D740000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionFileFormat
	{
		[PreserveSig] HRESULT GetDescription(out IAIMPString S);
		[PreserveSig] HRESULT GetExtList(out IAIMPString S);
		[PreserveSig] HRESULT GetFlags(out FlagsFileFormats S);
	}
}