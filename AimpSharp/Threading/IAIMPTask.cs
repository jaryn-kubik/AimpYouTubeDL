using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Threading
{
	[ComImport]
	[Guid(IID.IAIMPTask_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPTask
	{
		[PreserveSig] void Execute(IAIMPTaskOwner Owner);
	}
}