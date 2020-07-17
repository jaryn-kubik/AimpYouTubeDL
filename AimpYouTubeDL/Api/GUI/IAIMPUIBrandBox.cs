using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIBrandBox_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIBrandBox : IAIMPUIWinControl
	{
	}
}