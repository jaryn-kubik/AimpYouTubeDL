using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIImage_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIImage : IAIMPUIControl
	{
	}
}