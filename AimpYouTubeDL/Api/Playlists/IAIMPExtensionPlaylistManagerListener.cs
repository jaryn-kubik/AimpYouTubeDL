using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Playlists
{
	[ComImport]
	[Guid("41494D50-4578-7450-6C73-4D616E4C7472")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionPlaylistManagerListener
	{
		[PreserveSig] void PlaylistActivated(IAIMPPlaylist Playlist);
		[PreserveSig] void PlaylistAdded(IAIMPPlaylist Playlist);
		[PreserveSig] void PlaylistRemoved(IAIMPPlaylist Playlist);
	}
}