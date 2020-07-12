using AimpSharp.Actions.Enums;
using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Actions
{
	[ComImport]
	[Guid(IID.IAIMPServiceActionManager_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceActionManager
	{
		[PreserveSig] HRESULT GetByID(IAIMPString ID, out IAIMPAction Action);
		[PreserveSig] int MakeHotkey(ActionHotkeyModifier Modifiers, short Key);
	}
}