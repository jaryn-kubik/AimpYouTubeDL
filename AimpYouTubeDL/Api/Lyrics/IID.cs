using System;

namespace AimpYouTubeDL.Api.Lyrics
{
	public static class IID
	{
		public const string IAIMPLyrics_IID = "41494D50-4C79-7269-6373-46696C650000";
		public static readonly Guid IAIMPLyrics = new Guid(IAIMPLyrics_IID);

		public const string IAIMPExtensionLyricsProvider_IID = "41494D50-4578-744C-7972-697850727600";
		public static readonly Guid IAIMPExtensionLyricsProvider = new Guid(IAIMPExtensionLyricsProvider_IID);

		public const string IAIMPServiceLyrics_IID = "41494D50-5372-764C-7972-697800000000";
		public static readonly Guid IAIMPServiceLyrics = new Guid(IAIMPServiceLyrics_IID);
	}
}