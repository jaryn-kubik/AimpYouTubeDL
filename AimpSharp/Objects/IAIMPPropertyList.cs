using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPPropertyList_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPropertyList
	{
		[PreserveSig] void BeginUpdate();
		[PreserveSig] void EndUpdate();
		[PreserveSig] HRESULT Reset();

		[PreserveSig] HRESULT GetValueAsFloat(int PropertyID, out double Value);
		[PreserveSig] HRESULT GetValueAsInt32(int PropertyID, out int Value);
		[PreserveSig] HRESULT GetValueAsInt64(int PropertyID, out long Value);
		[PreserveSig] HRESULT GetValueAsObject(int PropertyID, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Value);

		[PreserveSig] HRESULT SetValueAsFloat(int PropertyID, double Value);
		[PreserveSig] HRESULT SetValueAsInt32(int PropertyID, int Value);
		[PreserveSig] HRESULT SetValueAsInt64(int PropertyID, long Value);
		[PreserveSig] HRESULT SetValueAsObject(int PropertyID, [MarshalAs(UnmanagedType.IUnknown)] object Value);
	}
}