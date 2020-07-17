using AimpSharp.Objects.Enums;
using AimpSharp.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid("41494D50-496D-6167-6500-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPImage
	{
		[PreserveSig] HRESULT LoadFromFile(IAIMPString FileName);
		[PreserveSig] HRESULT LoadFromStream(IAIMPStream Stream);
		[PreserveSig] HRESULT SaveToFile(IAIMPString FileName, int FormatID);
		[PreserveSig] HRESULT SaveToStream(IAIMPStream Stream, int FormatID);
		[PreserveSig] int GetFormatID();
		[PreserveSig] HRESULT GetSize(out SIZE size);
		[PreserveSig] HRESULT Clone(out IAIMPImage Image);
		[PreserveSig] HRESULT Draw(IntPtr DC, RECT R, ImageDraw Flags, [MarshalAs(UnmanagedType.IUnknown)] object Attrs = null);
		[PreserveSig] HRESULT Resize(int Width, int Height);
	}
}