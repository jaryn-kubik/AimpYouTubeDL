using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUITreeListNode_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUITreeListNode : IAIMPPropertyList
	{
		[PreserveSig] HRESULT Add(out IAIMPUITreeListNode Node);
		[PreserveSig] HRESULT ClearChildren();
		[PreserveSig] HRESULT FindByTag(IntPtr Tag, bool Recursive, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Node);
		[PreserveSig] HRESULT FindByValue(int ColumnIndex, IAIMPString Value, bool Recursive, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Node);
		[PreserveSig] HRESULT Get(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetCount();

		[PreserveSig] HRESULT ClearValues();
		[PreserveSig] HRESULT GetValue(int Index, out IAIMPString Value);
		[PreserveSig] HRESULT SetValue(int Index, IAIMPString Value);

		[PreserveSig] HRESULT GetGroup(ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Group);
	}
}