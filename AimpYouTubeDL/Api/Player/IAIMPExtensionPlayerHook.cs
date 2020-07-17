using AimpYouTubeDL.Api.Objects;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Player
{
	[ComImport]
	[Guid("41494D50-4578-7450-6C72-486F6F6B0000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionPlayerHook
	{
		[PreserveSig] HRESULT OnCheckURL(IAIMPString URL, ref bool Handled);
	}
}