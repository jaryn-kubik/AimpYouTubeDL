using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Objects.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct RGBQUAD
	{
		public byte Blue;
		public byte Green;
		public byte Red;
		public byte Reserved;
	}
}