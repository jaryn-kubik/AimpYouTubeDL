using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIBaseEdit_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIBaseEdit : IAIMPUIWinControl
	{
		[PreserveSig] HRESULT CopyToClipboard();
		[PreserveSig] HRESULT CutToClipboard();
		[PreserveSig] HRESULT PasteFromClipboard();
		[PreserveSig] HRESULT SelectAll();
		[PreserveSig] HRESULT SelectNone();
	}
}