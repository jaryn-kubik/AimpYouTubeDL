using AimpYouTubeDL.Api.Objects;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Playlists
{
	[ComImport]
	[Guid("41494D50-536D-504C-4D6E-677232000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServicePlaylistManager2 : IAIMPServicePlaylistManager
	{
		[PreserveSig] HRESULT GetPreimageFactory(int Index, out IAIMPExtensionPlaylistPreimageFactory Factory);
		[PreserveSig] HRESULT GetPreimageFactoryByID(IAIMPString ID, out IAIMPExtensionPlaylistPreimageFactory Factory);
		[PreserveSig] int GetPreimageFactoryCount();
	}
}