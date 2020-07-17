using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUITreeListDragSortingEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUITreeListDragSortingEvents
	{
		[PreserveSig] void OnDragSorting(IAIMPUITreeList Sender);
		[PreserveSig] void OnDragSortingNodeOver(IAIMPUITreeList Sender, IAIMPUITreeListNode Node, int Flags, ref bool Handled);
	}
}