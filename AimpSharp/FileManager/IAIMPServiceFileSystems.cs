using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-5372-7646-5300-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceFileSystems
	{
		[PreserveSig] HRESULT Get(IAIMPString FileURI, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] HRESULT GetDefault(ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
	}
}