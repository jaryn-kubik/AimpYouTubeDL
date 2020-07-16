using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIPageControl_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIPageControl : IAIMPUIWinControl
	{
		[PreserveSig] HRESULT Add(IAIMPString Name, out IAIMPUITabSheet Page);
		[PreserveSig] HRESULT Delete(int Index);
		[PreserveSig] HRESULT Delete2(IAIMPUITabSheet Page);
		[PreserveSig] HRESULT Get(int Index, out IAIMPUITabSheet Page);
		[PreserveSig] int GetCount();
	}
}