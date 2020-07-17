using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Player
{
	[ComImport]
	[Guid("41494D50-5372-7650-6C62-61636B510000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServicePlaybackQueue
	{
		[PreserveSig] HRESULT GetNextTrack(out IAIMPPlaybackQueueItem Item);
		[PreserveSig] HRESULT GetPrevTrack(out IAIMPPlaybackQueueItem Item);
	}
}