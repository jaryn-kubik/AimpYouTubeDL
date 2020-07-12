using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPPlaylistListener2_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistListener2
	{
		[PreserveSig] void ScanningBegin();
		[PreserveSig] void ScanningProgress(double Progress);
		[PreserveSig] void ScanningEnd(bool HasChanges, bool Canceled);
	}
}