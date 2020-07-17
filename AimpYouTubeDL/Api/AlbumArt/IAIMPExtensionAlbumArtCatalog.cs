using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.AlbumArt
{
	[ComImport]
	[Guid("41494D50-4578-7441-6C62-417274436174")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionAlbumArtCatalog
	{
		[PreserveSig] HRESULT GetIcon(out IntPtr Image);//HICON
		[PreserveSig] HRESULT GetName(out IAIMPString Name);
		[PreserveSig] HRESULT Show(IAIMPString FileURI, IAIMPString Artist, IAIMPString Album, out IAIMPImageContainer Image);
	}
}