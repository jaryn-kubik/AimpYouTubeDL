using System.Runtime.InteropServices;

namespace AimpSharp.Player.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TAIMPWaveformPeakInfo
	{
		public short MaxNegative;
		public short MaxPositive;
	}
}