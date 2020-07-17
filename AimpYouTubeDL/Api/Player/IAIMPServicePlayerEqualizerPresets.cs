using AimpYouTubeDL.Api.Objects;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Player
{
	[ComImport]
	[Guid("41494D50-5372-7645-5150-727374730000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServicePlayerEqualizerPresets
	{
		[PreserveSig] HRESULT Add(IAIMPString Name, out IAIMPEqualizerPreset Preset);
		[PreserveSig] HRESULT FindByName(IAIMPString Name, out IAIMPEqualizerPreset Preset);
		[PreserveSig] HRESULT Delete(IAIMPEqualizerPreset Preset);
		[PreserveSig] HRESULT Delete2(int Index);

		[PreserveSig] HRESULT GetPreset(int Index, out IAIMPEqualizerPreset Preset);
		[PreserveSig] int GetPresetCount();
	}
}