using AimpSharp.GUI.Enums;
using AimpSharp.Objects.Structs;
using System.Runtime.InteropServices;

namespace AimpSharp.GUI.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TAIMPUIControlPlacement
	{
		public TAIMPUIControlAlignment Alignment;
		public RECT AlignmentMargins;
		public RECT Anchors;
		public RECT Bounds;
	}
}