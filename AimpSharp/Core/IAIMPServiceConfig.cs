using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Core
{
	[ComImport]
	[Guid(IID.IAIMPServiceConfig_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceConfig : IAIMPConfig
	{
		[PreserveSig] HRESULT FlushCache();
	}
}