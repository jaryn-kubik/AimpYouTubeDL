using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid("41494D50-4450-4941-7761-726500000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPDPIAware
	{
		[PreserveSig] int GetDPI();
		[PreserveSig] HRESULT SetDPI(int Value);
	}
}