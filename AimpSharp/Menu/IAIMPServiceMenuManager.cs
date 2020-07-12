using AimpSharp.Menu.Enums;
using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Menu
{
	[ComImport]
	[Guid(IID.IAIMPServiceMenuManager_IID)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceMenuManager
	{
		[PreserveSig] HRESULT GetBuiltIn(MenuId ID, out IAIMPMenuItem MenuItem);
		[PreserveSig] HRESULT GetByID(IAIMPString ID, out IAIMPMenuItem MenuItem);
	}
}