using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPPlaylistQueueListener_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistQueueListener
	{
		[PreserveSig] void ContentChanged();
		[PreserveSig] void StateChanged();
	}
}