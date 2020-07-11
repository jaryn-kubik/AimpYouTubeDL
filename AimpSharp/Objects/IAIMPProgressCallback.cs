using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPProgressCallback_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPProgressCallback
	{
		[PreserveSig] HRESULT Process(float Progress, ref bool Canceled);
	}
}