using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Playlists
{
	[ComImport]
	[Guid("41494D50-506C-7351-7565-756532000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistQueue2 : IAIMPPlaylistQueue
	{
		[PreserveSig] HRESULT ListenerAdd(IAIMPPlaylistQueueListener AListener);
		[PreserveSig] HRESULT ListenerRemove(IAIMPPlaylistQueueListener AListener);
	}
}