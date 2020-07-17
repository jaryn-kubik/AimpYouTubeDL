using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUITabControl_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUITabControl : IAIMPUIWinControl
	{
		[PreserveSig] HRESULT Add(IAIMPString S);
		[PreserveSig] HRESULT Delete(int Index);
		[PreserveSig] HRESULT Get(int Index, out IAIMPString Tab);
		[PreserveSig] int GetCount();
	}
}