using System;

namespace AimpYouTubeDL.Api.Messages
{
	public static class IID
	{
		public const string IAIMPMessageHook_IID = "FC6FB524-A959-4089-AA0A-EA40AB7374CD";
		public static readonly Guid IAIMPMessageHook = new Guid(IAIMPMessageHook_IID);

		public const string IAIMPServiceMessageDispatcher_IID = "41494D50-5372-764D-7367-447370720000";
		public static readonly Guid IAIMPServiceMessageDispatcher = new Guid(IAIMPServiceMessageDispatcher_IID);
	}
}