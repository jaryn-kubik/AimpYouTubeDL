using System.Runtime.InteropServices;

namespace AimpSharp.Actions
{
	[ComImport]
	[Guid(IID.IAIMPActionEvent_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPActionEvent
	{
		[PreserveSig] void OnExecute([MarshalAs(UnmanagedType.IUnknown)] object Data);
	}
}