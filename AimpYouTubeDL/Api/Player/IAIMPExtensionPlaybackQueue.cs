using AimpSharp.Player.Enums;
using AimpSharp.Playlists;
using System.Runtime.InteropServices;

namespace AimpSharp.Player
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