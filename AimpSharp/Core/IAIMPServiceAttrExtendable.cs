using System.Runtime.InteropServices;

namespace AimpSharp.Core
{
	[ComImport]
	[Guid("41494D50-5372-7641-7474-724578740000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceAttrExtendable
	{
		[PreserveSig] void RegisterExtension([MarshalAs(UnmanagedType.IUnknown)] object Extension);
		[PreserveSig] void UnregisterExtension([MarshalAs(UnmanagedType.IUnknown)] object Extension);
	}
}