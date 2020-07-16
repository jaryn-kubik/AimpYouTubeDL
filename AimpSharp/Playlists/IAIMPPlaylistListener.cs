using AimpSharp.Playlists.Enums;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid("41494D50-506C-734C-7374-6E7200000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistListener
	{
		[PreserveSig] void Activated();
		[PreserveSig] void Changed(FlagsPlaylistNotify Flags);
		[PreserveSig] void Removed();
	}
}