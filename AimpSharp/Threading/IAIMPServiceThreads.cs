using AimpSharp.Threading.Enums;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Threading
{
	[ComImport]
	[Guid(IID.IAIMPServiceThreads_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceThreads
	{
		[PreserveSig] HRESULT ExecuteInMainThread(IAIMPTask Task, ServiceThreadsFlags Flags);
		[PreserveSig] HRESULT ExecuteInThread(IAIMPTask Task, out IntPtr TaskHandle);
		[PreserveSig] HRESULT Cancel(IntPtr TaskHandle, ServiceThreadsFlags Flags);
		[PreserveSig] HRESULT WaitFor(IntPtr TaskHandle);
	}
}