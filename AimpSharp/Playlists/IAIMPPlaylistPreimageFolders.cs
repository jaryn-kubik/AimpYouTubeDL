using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid(IID.IAIMPPlaylistPreimageFolders_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistPreimageFolders : IAIMPPlaylistPreimage
	{
		[PreserveSig] HRESULT ItemsAdd(IAIMPString Path, bool Recursive);
		[PreserveSig] HRESULT ItemsDelete(int Index);
		[PreserveSig] HRESULT ItemsDeleteAll();
		[PreserveSig] HRESULT ItemsGet(int Index, IAIMPString Path, bool Recursive);
		[PreserveSig] int ItemsGetCount();
	}
}