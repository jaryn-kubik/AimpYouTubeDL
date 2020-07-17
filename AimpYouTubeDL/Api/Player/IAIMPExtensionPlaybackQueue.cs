using AimpYouTubeDL.Api.Player.Enums;
using AimpYouTubeDL.Api.Playlists;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Player
{
	[ComImport]
	[Guid("41494D50-4578-7450-6C61-796261636B51")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionPlaybackQueue
	{
		[PreserveSig] HRESULT GetNext([MarshalAs(UnmanagedType.IUnknown)] object Current, FlagsPlaybackQueue Flags, IAIMPPlaybackQueueItem QueueItem);
		[PreserveSig] HRESULT GetPrev([MarshalAs(UnmanagedType.IUnknown)] object Current, FlagsPlaybackQueue Flags, IAIMPPlaybackQueueItem QueueItem);
		[PreserveSig] void OnSelect(IAIMPPlaylistItem Item, IAIMPPlaybackQueueItem QueueItem);
	}
}