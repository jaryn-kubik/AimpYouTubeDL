using AimpSharp.FileManager.Enums;
using AimpSharp.FileManager.Structs;
using AimpSharp.Objects;
using AimpSharp.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-4669-6C65-496E-666F00000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPFileInfo : IAIMPPropertyList
	{
		[PreserveSig] HRESULT Assign(IAIMPFileInfo Source);
		[PreserveSig] HRESULT Clone(out IAIMPFileInfo Info);
	}
}