using System.Runtime.InteropServices;

namespace AimpSharp.Actions
{
	[ComImport]
	[Guid("41494D50-4163-7469-6F6E-4576656E7400")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPActionEvent
	{
		[PreserveSig] void OnExecute([MarshalAs(UnmanagedType.IUnknown)] object Data);
	}
}