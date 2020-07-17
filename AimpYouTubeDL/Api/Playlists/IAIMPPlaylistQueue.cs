using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Playlists
{
	[ComImport]
	[Guid("41494D50-506C-7351-7565-756500000000")]
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