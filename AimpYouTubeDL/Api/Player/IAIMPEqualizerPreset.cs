using AimpYouTubeDL.Api.Objects;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Player
{
	[ComImport]
	[Guid("41494D50-4571-5072-7374-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPEqualizerPreset
	{
		[PreserveSig] HRESULT GetName(out IAIMPString S);
		[PreserveSig] HRESULT SetName(IAIMPString S);
		[PreserveSig] HRESULT GetBandValue(int BandIndex, out double S);
		[PreserveSig] HRESULT SetBandValue(int BandIndex, double S);
	}
}