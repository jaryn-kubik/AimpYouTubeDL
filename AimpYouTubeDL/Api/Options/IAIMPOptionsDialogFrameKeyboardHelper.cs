using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Options
{
	[ComImport]
	[Guid("41494D50-4F70-7444-6C67-46726D4B4870")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPOptionsDialogFrameKeyboardHelper
	{
		[PreserveSig] bool DialogChar(char CharCode, int Unused);
		[PreserveSig] bool DialogKey(short CharCode, int Unused);
		[PreserveSig] bool SelectFirstControl();
		[PreserveSig] bool SelectNextControl(bool FindForward, bool CheckTabStop);
	}
}