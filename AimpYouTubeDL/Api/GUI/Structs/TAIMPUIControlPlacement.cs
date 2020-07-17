using AimpYouTubeDL.Api.GUI.Enums;
using AimpYouTubeDL.Api.Objects.Structs;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI.Structs
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