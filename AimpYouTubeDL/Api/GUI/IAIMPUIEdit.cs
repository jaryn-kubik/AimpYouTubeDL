using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIEdit_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIEdit : IAIMPUIBaseButtonnedEdit
	{
	}
}