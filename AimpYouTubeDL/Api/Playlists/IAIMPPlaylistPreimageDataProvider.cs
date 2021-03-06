﻿using AimpYouTubeDL.Api.Objects;
using AimpYouTubeDL.Api.Playlists.Enums;
using AimpYouTubeDL.Api.Threading;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Playlists
{
	[ComImport]
	[Guid("41494D50-536D-506C-7344-617461507276")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistPreimageDataProvider
	{
		[PreserveSig] HRESULT GetFiles(IAIMPTaskOwner Owner, out FlagsPlaylistAdd Flags, out IAIMPObjectList List);
	}
}