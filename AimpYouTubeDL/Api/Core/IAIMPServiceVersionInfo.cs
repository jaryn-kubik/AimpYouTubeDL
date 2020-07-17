using AimpSharp.Core.Enums;
using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Core
{
	[ComImport]
	[Guid("41494D50-5372-7656-6572-496E666F0000")]
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