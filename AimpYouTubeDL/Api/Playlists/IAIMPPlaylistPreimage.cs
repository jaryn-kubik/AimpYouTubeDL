using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Playlists
{
	[ComImport]
	[Guid("41494D50-536D-504C-5372-630000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistPreimage : IAIMPPropertyList
	{
		[PreserveSig] void Finalize();
		[PreserveSig] void Initialize(IAIMPPlaylistPreimageListener Listener);

		[PreserveSig] HRESULT ConfigLoad(IAIMPStream Stream);
		[PreserveSig] HRESULT ConfigSave(IAIMPStream Stream);
		[PreserveSig] HRESULT ExecuteDialog(IntPtr OwnerWndHanle);
	}
}