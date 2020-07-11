using System;

namespace AimpSharp.Threading
{
	public static class IID
	{
		public const string IAIMPTask_IID = "41494D50-5461-736B-3200-000000000000";
		public static readonly Guid IAIMPTask = new Guid(IAIMPTask_IID);

		public const string IAIMPTaskOwner_IID = "41494D50-5461-736B-4F77-6E6572320000";
		public static readonly Guid IAIMPTaskOwner = new Guid(IAIMPTaskOwner_IID);

		public const string IAIMPTaskPriority_IID = "41494D50-5461-736B-5072-696F72697479";
		public static readonly Guid IAIMPTaskPriority = new Guid(IAIMPTaskPriority_IID);

		public const string IAIMPServiceThreads_IID = "41494D50-5372-7654-6872-656164730000";
		public static readonly Guid IAIMPServiceThreads = new Guid(IAIMPServiceThreads_IID);
	}
}