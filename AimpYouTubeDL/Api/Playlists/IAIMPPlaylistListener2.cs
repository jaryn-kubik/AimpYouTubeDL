using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid("41494D50-506C-734C-7374-6E7232000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistListener2
	{
		[PreserveSig] void ScanningBegin();
		[PreserveSig] void ScanningProgress(double Progress);
		[PreserveSig] void ScanningEnd(bool HasChanges, bool Canceled);
	}
}