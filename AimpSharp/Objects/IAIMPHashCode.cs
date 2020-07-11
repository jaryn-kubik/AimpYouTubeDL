using System.Runtime.InteropServices;

namespace AimpSharp.Objects
{
	[ComImport]
	[Guid(IID.IAIMPHashCode_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPHashCode
	{
		[PreserveSig] int GetHashCode();
		[PreserveSig] void Recalculate();
	}
}