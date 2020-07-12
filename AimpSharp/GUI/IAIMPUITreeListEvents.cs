using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUITreeListEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUITreeListEvents
	{
		[PreserveSig] void OnColumnClick(IAIMPUITreeList Sender, int ColumnIndex);
		[PreserveSig] void OnFocusedColumnChanged(IAIMPUITreeList Sender);
		[PreserveSig] void OnFocusedNodeChanged(IAIMPUITreeList Sender);
		[PreserveSig] void OnNodeChecked(IAIMPUITreeList Sender, IAIMPUITreeListNode Node);
		[PreserveSig] void OnNodeDblClicked(IAIMPUITreeList Sender, IAIMPUITreeListNode Node);
		[PreserveSig] void OnSelectionChanged(IAIMPUITreeList Sender);
		[PreserveSig] void OnSorted(IAIMPUITreeList Sender);
		[PreserveSig] void OnStructChanged(IAIMPUITreeList Sender);
	}
}