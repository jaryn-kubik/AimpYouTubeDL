﻿using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIPopupMenuEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIPopupMenuEvents
	{
		[PreserveSig] bool OnContextPopup([MarshalAs(UnmanagedType.IUnknown)] object Sender, int X, int Y);
	}
}