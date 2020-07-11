using System;

namespace AimpSharp.Core
{
	public static class IID
	{
		public const string IAIMPCore_IID = "41494D50-436F-7265-0000-000000000000";
		public static readonly Guid IAIMPCore = new Guid(IAIMPCore_IID);

		public const string IAIMPServiceConfig_IID = "41494D50-5372-7643-6667-000000000000";
		public static readonly Guid IAIMPServiceConfig = new Guid(IAIMPServiceConfig_IID);

		public const string IAIMPServiceShutdown_IID = "41494D50-5372-7653-6875-74646F776E00";
		public static readonly Guid IAIMPServiceShutdown = new Guid(IAIMPServiceShutdown_IID);

		public const string IAIMPServiceVersionInfo_IID = "41494D50-5372-7656-6572-496E666F0000";
		public static readonly Guid IAIMPServiceVersionInfo = new Guid(IAIMPServiceVersionInfo_IID);

		public const string IAIMPServiceAttrExtendable_IID = "41494D50-5372-7641-7474-724578740000";
		public static readonly Guid IAIMPServiceAttrExtendable = new Guid(IAIMPServiceAttrExtendable_IID);

		public const string IAIMPServiceAttrObjects_IID = "41494D50-5372-7641-7474-724F626A7300";
		public static readonly Guid IAIMPServiceAttrObjects = new Guid(IAIMPServiceAttrObjects_IID);
	}
}