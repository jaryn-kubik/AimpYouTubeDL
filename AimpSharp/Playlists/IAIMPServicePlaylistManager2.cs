using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPServicePlaylistManager2_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServicePlaylistManager2 : IAIMPServicePlaylistManager
	{
		[PreserveSig] HRESULT GetPreimageFactory(int Index, out IAIMPExtensionPlaylistPreimageFactory Factory);
		[PreserveSig] HRESULT GetPreimageFactoryByID(IAIMPString ID, out IAIMPExtensionPlaylistPreimageFactory Factory);
		[PreserveSig] int GetPreimageFactoryCount();
	}
}