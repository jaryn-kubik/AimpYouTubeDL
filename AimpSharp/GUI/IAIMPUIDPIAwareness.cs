using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIDPIAwareness_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIDPIAwareness
	{
		[PreserveSig] bool IsDPIAware();
		[PreserveSig] HRESULT SetDPIAware(bool Value);
	}
}