using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPPlaylistQueue2_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistQueue2 : IAIMPPlaylistQueue
	{
		[PreserveSig] HRESULT ListenerAdd(IAIMPPlaylistQueueListener AListener);
		[PreserveSig] HRESULT ListenerRemove(IAIMPPlaylistQueueListener AListener);
	}
}