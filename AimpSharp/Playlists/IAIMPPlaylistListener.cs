using AimpSharp.Playlists.Enums;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPPlaylistListener_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistListener
	{
		[PreserveSig] void Activated();
		[PreserveSig] void Changed(FlagsPlaylistNotify Flags);
		[PreserveSig] void Removed();
	}
}