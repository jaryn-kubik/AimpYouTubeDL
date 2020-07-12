﻿using AimpSharp.FileManager.Structs;
using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-4578-7446-696C-65496E666F00")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPFileSystemCommandFileInfo
	{
		[PreserveSig] HRESULT GetFileAttrs(IAIMPString FileName, out TAIMPFileAttributes Attrs);
		[PreserveSig] HRESULT GetFileSize(IAIMPString FileName, out long Size);
		[PreserveSig] HRESULT IsFileExists(IAIMPString FileName);
	}
}