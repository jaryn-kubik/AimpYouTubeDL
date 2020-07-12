using AimpSharp.Objects;
using AimpSharp.Playlists.Enums;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPExtensionPlaylistPreimageFactory_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionPlaylistPreimageFactory
	{
		[PreserveSig] HRESULT CreatePreimage(out IAIMPPlaylistPreimage preimage);
		[PreserveSig] HRESULT GetID(out IAIMPString ID);
		[PreserveSig] HRESULT GetName(out IAIMPString Name);
		[PreserveSig] FlagsPlaylistPreimageFactory GetFlags();
	}
}