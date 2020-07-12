using AimpSharp.Core.Enums;
using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Core
{
	[ComImport]
	[Guid(IID.IAIMPServiceVersionInfo_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceVersionInfo
	{
		[PreserveSig] HRESULT FormatInfo(out IAIMPString S);
		[PreserveSig] int GetBuildDate();
		[PreserveSig] ServiceVersionState GetBuildState();
		[PreserveSig] int GetBuildNumber();
		[PreserveSig] int GetVersionID();
	}
}