using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Actions
{
	[ComImport]
	[Guid(IID.IAIMPAction_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPAction : IAIMPPropertyList
	{
	}
}