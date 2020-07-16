using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-5372-7646-696C-655552493200")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceFileURI2 : IAIMPServiceFileURI
	{
		[PreserveSig] HRESULT GetScheme(IAIMPString FileURI, out IAIMPString Scheme);
	}
}