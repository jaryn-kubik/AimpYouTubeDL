using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPPlaylistPreimage_IID)]
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