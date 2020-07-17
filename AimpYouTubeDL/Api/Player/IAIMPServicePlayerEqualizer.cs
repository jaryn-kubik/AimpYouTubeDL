using System.Runtime.InteropServices;

namespace AimpSharp.Player
{
	[ComImport]
	[Guid("41494D50-5372-7645-5100-000000000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServicePlayerEqualizer
	{
		[PreserveSig] bool GetActive();
		[PreserveSig] HRESULT SetActive(bool Value);

		[PreserveSig] HRESULT GetBandValue(int BandIndex, out double Value);
		[PreserveSig] HRESULT SetBandValue(int BandIndex, double Value);

		[PreserveSig] HRESULT GetPreset(out IAIMPEqualizerPreset Preset);
		[PreserveSig] HRESULT SetPreset(IAIMPEqualizerPreset Preset);
	}
}