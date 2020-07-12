using AimpSharp.Core.Enums;
using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Core
{
	[ComImport]
	[Guid(IID.IAIMPServiceShutdown_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceShutdown
	{
		[PreserveSig] HRESULT Restart(IAIMPString Params);
		[PreserveSig] HRESULT Shutdown(ServiceShutdownFlags Flags);
	}
}