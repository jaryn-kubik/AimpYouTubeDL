using System;

namespace AimpYouTubeDL.Api.Internet
{
	public static class IID
	{
		public const string IAIMPServiceConnectionSettings_IID = "4941494D-5053-7276-436F-6E6E43666700";
		public static readonly Guid IAIMPServiceConnectionSettings = new Guid(IAIMPServiceConnectionSettings_IID);

		public const string IAIMPServiceHTTPClient_IID = "41494D50-5372-7648-7474-70436C740000";
		public static readonly Guid IAIMPServiceHTTPClient = new Guid(IAIMPServiceHTTPClient_IID);

		public const string IAIMPServiceHTTPClient2_IID = "41494D50-5372-7648-7474-70436C743200";
		public static readonly Guid IAIMPServiceHTTPClient2 = new Guid(IAIMPServiceHTTPClient2_IID);

		public const string IAIMPHTTPClientEvents_IID = "41494D50-4874-7470-436C-744576747300";
		public static readonly Guid IAIMPHTTPClientEvents = new Guid(IAIMPHTTPClientEvents_IID);

		public const string IAIMPHTTPClientEvents2_IID = "41494D50-4874-7470-436C-744576747332";
		public static readonly Guid IAIMPHTTPClientEvents2 = new Guid(IAIMPHTTPClientEvents2_IID);
	}
}