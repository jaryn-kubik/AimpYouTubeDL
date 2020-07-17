using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIImageComboBox_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIImageComboBox : IAIMPUIBaseComboBox
	{
		[PreserveSig] int GetImageIndex(int Index);
		[PreserveSig] HRESULT SetImageIndex(int Index, int Value);
	}
}