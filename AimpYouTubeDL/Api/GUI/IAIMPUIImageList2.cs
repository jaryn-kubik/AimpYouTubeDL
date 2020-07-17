using AimpYouTubeDL.Api.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIImageList2_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIImageList2 : IAIMPUIImageList
	{
		[PreserveSig] HRESULT DrawEx(IntPtr DC, int Index, RECT R, bool Enabled);
	}
}