using System.Runtime.InteropServices;

namespace AimpSharp.Objects
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