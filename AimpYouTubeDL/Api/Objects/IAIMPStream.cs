using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid("41494D50-5374-7265-616D-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPStream
	{
		[PreserveSig] long GetSize();
		[PreserveSig] HRESULT SetSize(long Value);
		[PreserveSig] long GetPosition();
		[PreserveSig] HRESULT Seek(long Offset, int Mode);
		[PreserveSig] int Read(byte[] Buffer, uint Count);
		[PreserveSig] HRESULT Write(byte[] Buffer, uint Count, out uint Written);
	}
}