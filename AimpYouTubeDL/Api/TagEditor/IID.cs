using System;

namespace AimpSharp.TagEditor
{
	public static class IID
	{
		public const string IAIMPFileTag_IID = "41494D50-4669-6C65-5461-670000000000";
		public static readonly Guid IAIMPFileTag = new Guid(IAIMPFileTag_IID);

		public const string IAIMPFileTagEditor_IID = "41494D50-4669-6C65-5461-674564697400";
		public static readonly Guid IAIMPFileTagEditor = new Guid(IAIMPFileTagEditor_IID);

		public const string IAIMPServiceFileTagEditor_IID = "41494D50-5372-7654-6167-456469740000";
		public static readonly Guid IAIMPServiceFileTagEditor = new Guid(IAIMPServiceFileTagEditor_IID);

		public const string IAIMPServiceFindTagsOnline_IID = "41494D50-5372-7646-696E-645461677300";
		public static readonly Guid IAIMPServiceFindTagsOnline = new Guid(IAIMPServiceFindTagsOnline_IID);

		public const string IAIMPExtensionTagsProvider_IID = "41494D50-4578-7446-696E-645461677300";
		public static readonly Guid IAIMPExtensionTagsProvider = new Guid(IAIMPExtensionTagsProvider_IID);
	}
}