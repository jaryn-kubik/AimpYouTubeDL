﻿using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUITreeListGroup_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUITreeListGroup : IAIMPPropertyList
	{
		[PreserveSig] HRESULT Get(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetCount();
	}
}