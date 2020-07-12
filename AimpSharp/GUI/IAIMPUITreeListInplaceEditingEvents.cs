﻿using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUITreeListInplaceEditingEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUITreeListInplaceEditingEvents
	{
		[PreserveSig] void OnEditing(IAIMPUITreeList Sender, IAIMPUITreeListNode Node, int ColumnIndex, ref bool Allow);
		[PreserveSig] void OnEdited(IAIMPUITreeList Sender, IAIMPUITreeListNode Node, int ColumnIndex, ref IAIMPString Value);
	}
}