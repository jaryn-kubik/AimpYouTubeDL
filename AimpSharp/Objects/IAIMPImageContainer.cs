using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPImageContainer_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPImageContainer
	{
		[PreserveSig] HRESULT CreateImage(out IAIMPImage Image);
		[PreserveSig] HRESULT GetInfo(out SIZE Size, out int FormatID);
		[PreserveSig] IntPtr GetData();
		[PreserveSig] int GetDataSize();
		[PreserveSig] HRESULT SetDataSize(int Value);
	}
}