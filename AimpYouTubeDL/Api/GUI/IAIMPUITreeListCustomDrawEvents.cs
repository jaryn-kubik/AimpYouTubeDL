using AimpSharp.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUITreeListCustomDrawEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUITreeListCustomDrawEvents
	{
		[PreserveSig] void OnCustomDrawNode(IAIMPUITreeList Sender, IntPtr DC, RECT R, IAIMPUITreeListNode Node, ref bool Handled);
		[PreserveSig] void OnCustomDrawNodeCell(IAIMPUITreeList Sender, IntPtr DC, RECT R, IAIMPUITreeListNode Node, IAIMPUITreeListColumn Column, ref bool Handled);
		[PreserveSig] void OnGetNodeBackground(IAIMPUITreeList Sender, IAIMPUITreeListNode Node, ref int Color);
	}
}