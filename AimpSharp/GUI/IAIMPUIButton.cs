using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIButton_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIButton : IAIMPUIWinControl
	{
		[PreserveSig] HRESULT ShowDropDownMenu();
	}
}