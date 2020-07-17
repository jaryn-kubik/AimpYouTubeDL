using AimpYouTubeDL.Api.Objects;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Playlists
{
	[ComImport]
	[Guid("41494D50-5372-7650-6C73-4D616E000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServicePlaylistManager
	{
		[PreserveSig] HRESULT CreatePlaylist(IAIMPString Name, bool Activate, out IAIMPPlaylist Playlist);
		[PreserveSig] HRESULT CreatePlaylistFromFile(IAIMPString FileName, bool Activate, out IAIMPPlaylist Playlist);

		[PreserveSig] HRESULT GetActivePlaylist(out IAIMPPlaylist Playlist);
		[PreserveSig] HRESULT SetActivePlaylist(IAIMPPlaylist Playlist);

		[PreserveSig] HRESULT GetPlayablePlaylist(out IAIMPPlaylist Playlist);

		[PreserveSig] HRESULT GetLoadedPlaylist(int Index, out IAIMPPlaylist Playlist);
		[PreserveSig] HRESULT GetLoadedPlaylistByName(IAIMPString Name, out IAIMPPlaylist Playlist);
		[PreserveSig] int GetLoadedPlaylistCount();
		[PreserveSig] HRESULT GetLoadedPlaylistByID(IAIMPString ID, out IAIMPPlaylist Playlist);
	}
}