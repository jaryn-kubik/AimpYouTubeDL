using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Playlists
{
	[ComImport]
	[Guid("41494D50-536D-504C-4D6E-677200000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistPreimageListener
	{
		[PreserveSig] HRESULT DataChanged();
		[PreserveSig] HRESULT SettingsChanged();
	}
}