using AimpYouTubeDL.Api.AlbumArt.Enums;
using AimpYouTubeDL.Api.FileManager;
using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.AlbumArt
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void TAIMPServiceAlbumArtReceiveProc(IAIMPImage image, IAIMPImageContainer imageContainer, IntPtr UserData);

	[ComImport]
	[Guid("41494D50-5372-7641-6C62-417274000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceAlbumArt
	{
		[PreserveSig] HRESULT Get(IAIMPString FileURI, IAIMPString Artist, IAIMPString Album, FlagsAlbumArt Flags, TAIMPServiceAlbumArtReceiveProc CallbackProc, IntPtr UserData, out IntPtr TaskID);
		[PreserveSig] HRESULT Get2(IAIMPFileInfo FileInfo, FlagsAlbumArt Flags, TAIMPServiceAlbumArtReceiveProc CallbackProc, IntPtr UserData, out IntPtr TaskID);
		[PreserveSig] HRESULT Cancel(IntPtr TaskID, FlagsAlbumArt Flags);
	}
}