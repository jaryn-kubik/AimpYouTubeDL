using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Core
{
	[ComImport]
	[Guid("41494D50-5372-7641-7474-724F626A7300")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceAttrObjects
	{
		[PreserveSig] HRESULT CreateObject(ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
	}
}