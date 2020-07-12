using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPPlaylistQueue_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistQueue
	{
		[PreserveSig] HRESULT Add(IAIMPPlaylistItem Item, bool InsertAtBeginning);
		[PreserveSig] HRESULT AddList(IAIMPObjectList ItemList, bool InsertAtBeginning);

		[PreserveSig] HRESULT Delete(IAIMPPlaylistItem Item);
		[PreserveSig] HRESULT Delete2(IAIMPPlaylist Playlist);

		[PreserveSig] HRESULT Move(IAIMPPlaylistItem Item, int TargetIndex);
		[PreserveSig] HRESULT Move2(int ItemIndex, int TargetIndex);

		[PreserveSig] HRESULT GetItem(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetItemCount();
	}
}