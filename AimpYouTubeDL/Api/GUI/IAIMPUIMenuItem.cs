using AimpSharp.Menu;
using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIMenuItem_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIMenuItem : IAIMPMenuItem
	{
		[PreserveSig] HRESULT Add(IAIMPString ID, out IAIMPUIMenuItem MenuItem);
		[PreserveSig] HRESULT Delete(int Index);
		[PreserveSig] HRESULT Get(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetCount();
	}
}