using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Playlists
{
	[ComImport]
	[Guid("41494D50-506C-7351-7565-75654C737400")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistQueueListener
	{
		[PreserveSig] void ContentChanged();
		[PreserveSig] void StateChanged();
	}
}