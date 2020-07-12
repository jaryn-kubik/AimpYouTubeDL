﻿using AimpSharp.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid("41494D50-496D-6167-6543-6F6E746E7200")]
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