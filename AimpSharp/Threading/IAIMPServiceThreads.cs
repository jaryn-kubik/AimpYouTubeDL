using AimpSharp.Threading.Enums;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Threading
{
	[ComImport]
	[Guid("41494D50-5372-7654-6872-656164730000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceThreads
	{
		[PreserveSig] HRESULT ExecuteInMainThread(IAIMPTask Task, FlagsServiceThreads Flags = FlagsServiceThreads.AIMP_SERVICE_THREADS_FLAGS_NONE);
		[PreserveSig] HRESULT ExecuteInThread(IAIMPTask Task, out IntPtr TaskHandle);
		[PreserveSig] HRESULT Cancel(IntPtr TaskHandle, FlagsServiceThreads Flags);
		[PreserveSig] HRESULT WaitFor(IntPtr TaskHandle);
	}
}