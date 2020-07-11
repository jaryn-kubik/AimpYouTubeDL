using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPStream_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPStream
	{
		[PreserveSig] long GetSize();
		[PreserveSig] HRESULT SetSize(long Value);
		[PreserveSig] long GetPosition();
		[PreserveSig] HRESULT Seek(long Offset, int Mode);
		[PreserveSig] int Read(IntPtr Buffer, uint Count);
		[PreserveSig] HRESULT Write(IntPtr Buffer, uint Count, out uint Written);
	}
}