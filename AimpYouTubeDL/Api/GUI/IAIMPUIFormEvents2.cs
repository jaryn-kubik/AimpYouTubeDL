using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIFormEvents2_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIFormEvents2
	{
		[PreserveSig] void OnChangeScale(IAIMPUIForm Sender, int Multiplier, int Divider);
	}
}