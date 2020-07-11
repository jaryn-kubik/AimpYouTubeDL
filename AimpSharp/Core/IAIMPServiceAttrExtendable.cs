using System.Runtime.InteropServices;

namespace AimpSharp.Core
{
	[ComImport]
	[Guid(IID.IAIMPServiceAttrExtendable_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceAttrExtendable
	{
		[PreserveSig] void RegisterExtension([MarshalAs(UnmanagedType.IUnknown)] object Extension);
		[PreserveSig] void UnregisterExtension([MarshalAs(UnmanagedType.IUnknown)] object Extension);
	}
}