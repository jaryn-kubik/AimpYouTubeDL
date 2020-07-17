using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIFileDialogs_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIFileDialogs
	{
		[PreserveSig] HRESULT ExecuteOpenDialog(IntPtr OwnerWnd, IAIMPString Caption, IAIMPString Filter, out IAIMPString FileName);
		[PreserveSig] HRESULT ExecuteOpenDialog2(IntPtr OwnerWnd, IAIMPString Caption, IAIMPString Filter, out IAIMPObjectList Files);
		[PreserveSig] HRESULT ExecuteSaveDialog(IntPtr OwnerWnd, IAIMPString Caption, IAIMPString Filter, out IAIMPString FileName, out int FilterIndex);
	}
}