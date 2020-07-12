using AimpSharp.FileManager.Enums;
using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-5372-7646-696C-655552490000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceFileURI
	{
		[PreserveSig] HRESULT Build(IAIMPString ContainerFileName, IAIMPString PartName, out IAIMPString FileURI);
		[PreserveSig] HRESULT Parse(IAIMPString FileURI, out IAIMPString ContainerFileName, out IAIMPString PartName);

		[PreserveSig] HRESULT ChangeFileExt(ref IAIMPString FileURI, IAIMPString NewExt, FlagsFileUri Flags);
		[PreserveSig] HRESULT ExtractFileExt(IAIMPString FileURI, out IAIMPString S, FlagsFileUri Flags);
		[PreserveSig] HRESULT ExtractFileName(IAIMPString FileURI, IAIMPString S);
		[PreserveSig] HRESULT ExtractFileParentDirName(IAIMPString FileURI, out IAIMPString S);
		[PreserveSig] HRESULT ExtractFileParentName(IAIMPString FileURI, out IAIMPString S);
		[PreserveSig] HRESULT ExtractFilePath(IAIMPString FileURI, out IAIMPString S);
		[PreserveSig] HRESULT IsURL(IAIMPString FileURI);
	}
}