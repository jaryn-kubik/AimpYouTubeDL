using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Menu
{
	[ComImport]
	[Guid(IID.IAIMPMenuItem_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPMenuItem : IAIMPPropertyList
	{
		[PreserveSig] HRESULT DeleteChildren();
	}
}