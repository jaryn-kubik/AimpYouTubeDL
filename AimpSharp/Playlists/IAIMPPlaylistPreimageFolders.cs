using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid("41494D50-536D-504C-5372-63466C647273")]
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