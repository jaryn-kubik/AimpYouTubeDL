using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Core
{
	[ComImport]
	[Guid("41494D50-5372-7643-6667-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceConfig : IAIMPConfig
	{
		[PreserveSig] HRESULT FlushCache();
	}
}