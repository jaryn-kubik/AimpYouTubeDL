using AimpSharp.Objects;
using AimpSharp.Playlists.Enums;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int TAIMPPlaylistCompareProc(IAIMPPlaylistItem Item1, IAIMPPlaylistItem Item2, IntPtr UserData);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate bool TAIMPPlaylistDeleteProc(IAIMPPlaylistItem Item, IntPtr UserData);

	[ComImport]
	[Guid("41494D50-506C-7300-0000-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylist
	{
		// Adding
		[PreserveSig] HRESULT Add([MarshalAs(UnmanagedType.IUnknown)] object Obj, FlagsPlaylistAdd Flags, int InsertIn);
		[PreserveSig] HRESULT AddList(IAIMPObjectList ObjList, FlagsPlaylistAdd Flags, int InsertIn);

		// Deleting
		[PreserveSig] HRESULT Delete(IAIMPPlaylistItem Item);
		[PreserveSig] HRESULT Delete2(int ItemIndex);
		[PreserveSig] HRESULT Delete3(FlagsPlaylistDelete Flags, TAIMPPlaylistDeleteProc Proc, IntPtr UserData);
		[PreserveSig] HRESULT DeleteAll();

		// Sorting
		[PreserveSig] HRESULT Sort(int Mode);
		[PreserveSig] HRESULT Sort2(IAIMPString Template);
		[PreserveSig] HRESULT Sort3(TAIMPPlaylistCompareProc Proc, IntPtr UserData);

		// Locking
		[PreserveSig] HRESULT BeginUpdate();
		[PreserveSig] HRESULT EndUpdate();

		// Other Commands
		[PreserveSig] HRESULT Close(FlagsPlaylistClose Flags);
		[PreserveSig] HRESULT GetFiles(FlagsPlaylistGetFiles Flags, out IAIMPObjectList List);
		[PreserveSig] HRESULT MergeGroup(IAIMPPlaylistGroup Group);
		[PreserveSig] HRESULT ReloadFromPreimage();
		[PreserveSig] HRESULT ReloadInfo(FlagsPlaylistReloadInfo Flags);

		// Items
		[PreserveSig] HRESULT GetItem(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetItemCount();

		// Groups
		[PreserveSig] HRESULT GetGroup(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetGroupCount();

		// Listener
		[PreserveSig] HRESULT ListenerAdd(IAIMPPlaylistListener AListener);
		[PreserveSig] HRESULT ListenerRemove(IAIMPPlaylistListener AListener);
	}
}