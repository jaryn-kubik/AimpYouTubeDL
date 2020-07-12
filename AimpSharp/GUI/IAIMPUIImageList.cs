using AimpSharp.Objects;
using AimpSharp.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIImageList_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIImageList
	{
		[PreserveSig] HRESULT Add(IAIMPImage Image);
		[PreserveSig] HRESULT Clear();
		[PreserveSig] HRESULT Delete(int Index);
		[PreserveSig] HRESULT Draw(IntPtr DC, int Index, int X, int Y, bool Enabled);
		[PreserveSig] HRESULT LoadFromResource(IntPtr Instance, [MarshalAs(UnmanagedType.LPWStr)] string ResName, [MarshalAs(UnmanagedType.LPWStr)] string ResType);
		[PreserveSig] int GetCount();
		[PreserveSig] HRESULT GetSize(out SIZE Size);
		[PreserveSig] HRESULT SetSize(SIZE Size);
	}
}