using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Actions
{
	[ComImport]
	[Guid("41494D50-4163-7469-6F6E-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPAction : IAIMPPropertyList
	{
	}
}