using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIBaseComboBox_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIBaseComboBox : IAIMPUIBaseButtonnedEdit
	{
		[PreserveSig] HRESULT Add([MarshalAs(UnmanagedType.IUnknown)] object Obj, int ExtraData);
		[PreserveSig] HRESULT Add2(IAIMPObjectList List);
		[PreserveSig] HRESULT Clear();
		[PreserveSig] HRESULT Delete(int Index);
		[PreserveSig] HRESULT GetItem(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetItemCount();
		[PreserveSig] HRESULT SetItem(int Index, [MarshalAs(UnmanagedType.IUnknown)] object Obj);
	}
}