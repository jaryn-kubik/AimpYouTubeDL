using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41465343-6D64-436F-7079-32436C706264")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPFileSystemCommandCopyToClipboard
	{
		[PreserveSig] HRESULT CopyToClipboard(IAIMPObjectList Files);
	}
}