using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Objects
{
	[ComImport]
	[Guid("41494D50-4F62-6A4C-6973-740000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPObjectList
	{
		[PreserveSig] HRESULT Add([MarshalAs(UnmanagedType.IUnknown)] object Obj);
		[PreserveSig] HRESULT Clear();
		[PreserveSig] HRESULT Delete(int Index);
		[PreserveSig] HRESULT Insert(int Index, [MarshalAs(UnmanagedType.IUnknown)] object Obj);

		[PreserveSig] int GetCount();
		[PreserveSig] HRESULT GetObject(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] HRESULT SetObject(int Index, [MarshalAs(UnmanagedType.IUnknown)] object Obj);
	}
}