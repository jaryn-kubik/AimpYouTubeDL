using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Threading
{
	[ComImport]
	[Guid("41494D50-5461-736B-4F77-6E6572320000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPTaskOwner
	{
		[PreserveSig] bool IsCanceled();
	}
}