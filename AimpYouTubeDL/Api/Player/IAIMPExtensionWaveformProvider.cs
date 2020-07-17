using AimpSharp.Objects;
using AimpSharp.Player.Structs;
using AimpSharp.Threading;
using System.Runtime.InteropServices;

namespace AimpSharp.Player
{
	[ComImport]
	[Guid("41494D50-4578-7457-6176-507276000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionWaveformProvider
	{
		[PreserveSig] HRESULT Calculate(IAIMPString FileURI, IAIMPTaskOwner TaskOwner, ref TAIMPWaveformPeakInfo Peaks, int PeakCount);
	}
}