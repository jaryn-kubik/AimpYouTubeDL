using AimpSharp.Threading.Enums;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Threading
{
	[ComImport]
	[Guid(IID.IAIMPTaskPriority_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPTaskPriority
	{
		[PreserveSig] TaskPriority GetPriority();
	}
}