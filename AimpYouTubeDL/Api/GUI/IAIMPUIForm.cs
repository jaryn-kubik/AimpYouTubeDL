using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIForm_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIForm : IAIMPUIWinControl
	{
		[PreserveSig] HRESULT Close();
		[PreserveSig] HRESULT GetFocusedControl(out IAIMPUIWinControl Control);
		[PreserveSig] HRESULT Localize();
		[PreserveSig] HRESULT Release(bool Postponed);
		[PreserveSig] int ShowModal();
	}
}