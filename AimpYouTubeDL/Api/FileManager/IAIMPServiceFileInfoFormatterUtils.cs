using AimpYouTubeDL.Api.Objects.Structs;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.FileManager
{
	[ComImport]
	[Guid("41494D50-5372-7646-6C49-6E66466D7455")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceFileInfoFormatterUtils
	{
		[PreserveSig] HRESULT ShowMacrosLegend(RECT ScreenTarget, int Reserved, [MarshalAs(UnmanagedType.IUnknown)] object EventsHandler);
	}
}