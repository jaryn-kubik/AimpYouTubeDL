using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUITreeListColumn_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUITreeListColumn : IAIMPPropertyList
	{
	}
}