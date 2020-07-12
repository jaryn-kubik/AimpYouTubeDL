using AimpSharp.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPImage2_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPImage2 : IAIMPImage
	{
		[PreserveSig] HRESULT LoadFromResource(IntPtr ResInstance, [MarshalAs(UnmanagedType.LPWStr)] string ResName, [MarshalAs(UnmanagedType.LPWStr)] string ResType);
		[PreserveSig] HRESULT LoadFromBitmap(IntPtr Bitmap);
		[PreserveSig] HRESULT LoadFromBits(ref RGBQUAD Bits, int Width, int Height);
		[PreserveSig] HRESULT CopyToClipboard();
		[PreserveSig] HRESULT CanPasteFromClipboard();
		[PreserveSig] HRESULT PasteFromClipboard();
	}
}