using AimpSharp.Core.Enums;
using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Core
{
	[ComImport]
	[Guid("41494D50-5372-7653-6875-74646F776E00")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceShutdown
	{
		[PreserveSig] HRESULT Restart(IAIMPString Params);
		[PreserveSig] HRESULT Shutdown(FlagsServiceShutdown Flags);
	}
}