using AimpYouTubeDL.Api.Core.Enums;
using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Core
{
	[ComImport]
	[Guid("41494D50-436F-7265-0000-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPCore
	{
		[PreserveSig] HRESULT CreateObject(ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] HRESULT GetPath(CorePath PathID, out IAIMPString Value);

		[PreserveSig] HRESULT RegisterExtension(ref Guid ServiceIID, [MarshalAs(UnmanagedType.IUnknown)] object Extension);
		[PreserveSig] HRESULT RegisterService([MarshalAs(UnmanagedType.IUnknown)] object Service);
		[PreserveSig] HRESULT UnregisterExtension([MarshalAs(UnmanagedType.IUnknown)] object Extension);
	}
}