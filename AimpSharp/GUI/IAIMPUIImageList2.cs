using AimpSharp.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIImageList2_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIImageList2 : IAIMPUIImageList
	{
		[PreserveSig] HRESULT DrawEx(IntPtr DC, int Index, RECT R, bool Enabled);
	}
}