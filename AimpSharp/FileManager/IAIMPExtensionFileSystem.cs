﻿using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-4578-7446-5300-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionFileSystem : IAIMPPropertyList
	{
	}
}