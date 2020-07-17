using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUITreeList_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUITreeList : IAIMPUIWinControl
	{
		[PreserveSig] HRESULT AddColumn(ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] HRESULT ClearColumns();
		[PreserveSig] HRESULT DeleteColumn(int Index);
		[PreserveSig] HRESULT GetColumn(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetColumnCount();

		[PreserveSig] HRESULT Clear();
		[PreserveSig] HRESULT Delete(IAIMPUITreeListNode Node);
		[PreserveSig] HRESULT GetPath(IAIMPUITreeListNode Node, out IAIMPString S);
		[PreserveSig] HRESULT GetRootNode(ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] HRESULT MakeTop(IAIMPUITreeListNode Node);
		[PreserveSig] HRESULT MakeVisible(IAIMPUITreeListNode Node);
		[PreserveSig] HRESULT SetPath(IAIMPString S);

		[PreserveSig] HRESULT GetAbsoluteVisibleNode(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetAbsoluteVisibleNodeCount();

		[PreserveSig] HRESULT DeleteSelected();
		[PreserveSig] HRESULT SelectAll();
		[PreserveSig] HRESULT SelectNone();
		[PreserveSig] HRESULT GetFocused(ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] HRESULT SetFocused([MarshalAs(UnmanagedType.IUnknown)] object Obj);
		[PreserveSig] HRESULT GetSelected(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetSelectedCount();

		[PreserveSig] HRESULT GetEditingCell(out int ColumnIndex, out int RowIndex);
		[PreserveSig] HRESULT StartEditing(IAIMPUITreeListColumn Column);
		[PreserveSig] HRESULT StopEditing();

		[PreserveSig] HRESULT GroupBy(IAIMPUITreeListColumn Column, bool ResetPrevGroupingParams);
		[PreserveSig] HRESULT GetGroup(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetGroupCount();
		[PreserveSig] HRESULT Regroup();
		[PreserveSig] HRESULT ResetGrouppingParams();

		[PreserveSig] HRESULT ResetSortingParams();
		[PreserveSig] HRESULT Resort();
		[PreserveSig] HRESULT SortBy(IAIMPUITreeListColumn Column, int Flags, bool ResetPrevSortingParams);

		[PreserveSig] HRESULT ConfigLoad(IAIMPConfig Config, IAIMPString Key);
		[PreserveSig] HRESULT ConfigSave(IAIMPConfig Config, IAIMPString Key);
	}
}