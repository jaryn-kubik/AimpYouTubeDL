using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUICheckComboBox_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUICheckComboBox : IAIMPUIBaseComboBox
	{
		[PreserveSig] bool GetChecked(int Index);
		[PreserveSig] HRESULT SetChecked(int Index, bool Value);
	}
}