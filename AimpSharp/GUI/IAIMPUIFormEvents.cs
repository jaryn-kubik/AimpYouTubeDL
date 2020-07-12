using System;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI
{
	[ComImport]
	[Guid(IID.IAIMPUIFormEvents_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPUIFormEvents
	{
		[PreserveSig] void OnActivated(IAIMPUIForm Sender);
		[PreserveSig] void OnDeactivated(IAIMPUIForm Sender);
		[PreserveSig] void OnCreated(IAIMPUIForm Sender);
		[PreserveSig] void OnDestroyed(IAIMPUIForm Sender);
		[PreserveSig] void OnCloseQuery(IAIMPUIForm Sender, ref bool CanClose);
		[PreserveSig] void OnLocalize(IAIMPUIForm Sender);
		[PreserveSig] void OnShortCut(IAIMPUIForm Sender, short Key, short Modifiers, ref bool Handled);
	}
}