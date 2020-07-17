using AimpSharp.Objects;
using AimpSharp.Playlists.Enums;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid("41494D50-4578-7453-6D50-6C7346637400")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionPlaylistPreimageFactory
	{
		[PreserveSig] HRESULT CreatePreimage(out IAIMPPlaylistPreimage preimage);
		[PreserveSig] HRESULT GetID(out IAIMPString ID);
		[PreserveSig] HRESULT GetName(out IAIMPString Name);
		[PreserveSig] FlagsPlaylistPreimageFactory GetFlags();
	}
}