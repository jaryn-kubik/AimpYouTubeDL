using AimpYouTubeDL.Api.Objects;
using AimpYouTubeDL.Api.Player.Structs;
using AimpYouTubeDL.Api.Threading;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Player
{
	[ComImport]
	[Guid("41494D50-4578-7457-6176-507276000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionWaveformProvider
	{
		[PreserveSig] HRESULT Calculate(IAIMPString FileURI, IAIMPTaskOwner TaskOwner, ref TAIMPWaveformPeakInfo Peaks, int PeakCount);
	}
}