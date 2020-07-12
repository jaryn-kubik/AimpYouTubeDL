using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Threading
{
	[ComImport]
	[Guid(IID.IAIMPTaskOwner_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPTaskOwner
	{
		[PreserveSig] bool IsCanceled();
	}
}