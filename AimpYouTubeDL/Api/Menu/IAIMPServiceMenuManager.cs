using AimpYouTubeDL.Api.Menu.Enums;
using AimpYouTubeDL.Api.Objects;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Menu
{
	[ComImport]
	[Guid("41494D50-5372-764D-656E-754D6E677200")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceMenuManager
	{
		[PreserveSig] HRESULT GetBuiltIn(MenuId ID, out IAIMPMenuItem MenuItem);
		[PreserveSig] HRESULT GetByID(IAIMPString ID, out IAIMPMenuItem MenuItem);
	}
}