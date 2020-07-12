﻿using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.Playlists
{
	[ComImport]
	[Guid("41494D50-506C-7349-7465-6D0000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaylistItem : IAIMPPropertyList
	{
		[PreserveSig] HRESULT ReloadInfo();
	}
}