using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.AlbumArt
{
	[ComImport]
	[Guid("4941494D-5053-7276-416C-624172744368")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceAlbumArtCache
	{
		[PreserveSig] HRESULT Flush(IAIMPString Artist, IAIMPString Album);
		[PreserveSig] HRESULT Flush2(IAIMPString FileURI);
		[PreserveSig] HRESULT FlushAll();
	}
}