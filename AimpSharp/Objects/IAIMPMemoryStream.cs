using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPMemoryStream_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPMemoryStream : IAIMPStream
	{
		[PreserveSig] IntPtr GetData();
	}
}