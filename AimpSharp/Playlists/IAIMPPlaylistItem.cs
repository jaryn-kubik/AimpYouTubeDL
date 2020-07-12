using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPPlaylistItem_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistItem : IAIMPPropertyList
	{
		[PreserveSig] HRESULT ReloadInfo();
	}
}