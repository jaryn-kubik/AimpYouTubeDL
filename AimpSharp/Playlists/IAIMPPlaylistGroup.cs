using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPPlaylistGroup_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistGroup : IAIMPPropertyList
	{
		[PreserveSig] HRESULT GetItem(int Index, ref Guid IID, [MarshalAs(UnmanagedType.IUnknown)] out object Obj);
		[PreserveSig] int GetItemCount();
	}
}