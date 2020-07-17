using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Objects
{
	[ComImport]
	[Guid("41494D50-4861-7368-436F-646500000000")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPHashCode
	{
		[PreserveSig] int GetHashCode();
		[PreserveSig] void Recalculate();
	}
}