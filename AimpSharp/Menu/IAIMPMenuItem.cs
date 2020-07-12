﻿using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Menu
{
	[ComImport]
	[Guid("41494D50-4D65-6E75-4974-656D00000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPMenuItem : IAIMPPropertyList
	{
		[PreserveSig] HRESULT DeleteChildren();
	}
}