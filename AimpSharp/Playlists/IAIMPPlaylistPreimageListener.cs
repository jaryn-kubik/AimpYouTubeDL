using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPPlaylistPreimageListener_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistPreimageListener
	{
		[PreserveSig] HRESULT DataChanged();
		[PreserveSig] HRESULT SettingsChanged();
	}
}