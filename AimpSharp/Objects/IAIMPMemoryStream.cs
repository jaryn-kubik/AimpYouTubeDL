using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid("41494D50-4D65-6D53-7472-65616D000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPMemoryStream : IAIMPStream
	{
		[PreserveSig] IntPtr GetData();
	}
}