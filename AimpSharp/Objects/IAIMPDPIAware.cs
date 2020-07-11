using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPDPIAware_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPDPIAware
	{
		[PreserveSig] int GetDPI();
		[PreserveSig] HRESULT SetDPI(int Value);
	}
}