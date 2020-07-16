using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIWndProcEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIWndProcEvents
	{
		[PreserveSig] bool OnBeforeWndProc(int Message, IntPtr ParamW, IntPtr ParamL, out IntPtr Result);
		[PreserveSig] void OnAfterWndProc(int Message, IntPtr ParamW, IntPtr ParamL, out IntPtr Result);
	}
}