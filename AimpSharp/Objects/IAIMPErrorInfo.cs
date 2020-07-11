using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPErrorInfo_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPErrorInfo
	{
		[PreserveSig] HRESULT GetInfo(out int ErrorCode, out IAIMPString Message, out IAIMPString Details);
		[PreserveSig] HRESULT GetInfoFormatted(out IAIMPString S);
		[PreserveSig] void SetInfo(int ErrorCode, IAIMPString Message, IAIMPString Details);
	}
}