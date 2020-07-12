using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.FileManager
{
	[ComImport]
	[Guid("41494D50-4578-7446-696C-654578706472")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionFileExpander
	{
		[PreserveSig] HRESULT Expand(IAIMPString FileName, out IAIMPObjectList List, IAIMPProgressCallback ProgressCallback);
	}
}