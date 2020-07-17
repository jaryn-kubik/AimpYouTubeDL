using AimpSharp.FileManager;
using AimpSharp.Objects;
using AimpSharp.Player.Enums;
using AimpSharp.Playlists;
using System.Runtime.InteropServices;

namespace AimpSharp.Player
{
	[ComImport]
	[Guid("41494D50-5372-7650-6C61-796572000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServicePlayer
	{
		[PreserveSig] HRESULT Play(IAIMPPlaybackQueueItem Item);
		[PreserveSig] HRESULT Play2(IAIMPPlaylistItem Item);
		[PreserveSig] HRESULT Play3(IAIMPPlaylist Playlist);
		[PreserveSig] HRESULT Play4(IAIMPString FileURI, FlagsServicePlayer Flags);

		[PreserveSig] HRESULT GoToNext();
		[PreserveSig] HRESULT GoToPrev();

		[PreserveSig] HRESULT GetDuration(out double Seconds);
		[PreserveSig] HRESULT GetPosition(out double Seconds);
		[PreserveSig] HRESULT SetPosition(double Seconds);
		[PreserveSig] HRESULT GetMute(out bool Value);
		[PreserveSig] HRESULT SetMute(bool Value);
		[PreserveSig] HRESULT GetVolume(out float Level);
		[PreserveSig] HRESULT SetVolume(float Level);
		[PreserveSig] HRESULT GetInfo(out IAIMPFileInfo FileInfo);
		[PreserveSig] HRESULT GetPlaylistItem(out IAIMPPlaylistItem Item);
		[PreserveSig] int GetState();
		[PreserveSig] HRESULT Pause();
		[PreserveSig] HRESULT Resume();
		[PreserveSig] HRESULT Stop();
		[PreserveSig] HRESULT StopAfterTrack();
	}
}