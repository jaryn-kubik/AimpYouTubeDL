using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
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