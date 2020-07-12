using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPExtensionPlaylistManagerListener_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionPlaylistManagerListener
	{
		[PreserveSig] void PlaylistActivated(IAIMPPlaylist Playlist);
		[PreserveSig] void PlaylistAdded(IAIMPPlaylist Playlist);
		[PreserveSig] void PlaylistRemoved(IAIMPPlaylist Playlist);
	}
}