using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.FileManager.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TAIMPFileAttributes
	{
		public int Attributes;
		public double TimeCreation;
		public double TimeLastAccess;
		public double TimeLastWrite;
		public long Reserved0;
		public long Reserved1;
		public long Reserved2;
	}
}