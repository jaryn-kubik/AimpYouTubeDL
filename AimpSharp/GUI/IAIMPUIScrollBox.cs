using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIScrollBox_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIScrollBox : IAIMPUIWinControl
	{
		[PreserveSig] HRESULT MakeVisible(IAIMPUIControl Control);
	}
}