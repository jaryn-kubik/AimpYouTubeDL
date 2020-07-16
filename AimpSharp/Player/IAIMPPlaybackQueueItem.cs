using AimpSharp.Objects;
using System.Runtime.InteropServices;

namespace AimpSharp.Player
{
	[ComImport]
	[Guid("41494D50-506C-6179-6261-636B5149746D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPPlaybackQueueItem : IAIMPPropertyList
	{
	}
}