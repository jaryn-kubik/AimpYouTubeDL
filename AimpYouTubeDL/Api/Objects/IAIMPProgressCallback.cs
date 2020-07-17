using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Objects
{
	[ComImport]
	[Guid("41494D50-5072-6F67-7265-737343420000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPProgressCallback
	{
		[PreserveSig] HRESULT Process(float Progress, ref bool Canceled);
	}
}