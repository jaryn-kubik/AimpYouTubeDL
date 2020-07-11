using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Core
{
	[ComImport]
	[Guid(IID.IAIMPServiceAttrObjects_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceAttrObjects
	{
		[PreserveSig] HRESULT CreateObject(ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
	}
}