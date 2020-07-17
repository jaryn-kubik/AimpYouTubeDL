using System;

namespace AimpSharp.Scheduler
{
	public static class IID
	{
		public const string IAIMPSchedulerEvent_IID = "41494D50-5363-6865-6475-6C6572457674";
		public static readonly Guid IAIMPSchedulerEvent = new Guid(IAIMPSchedulerEvent_IID);

		public const string IAIMPServiceScheduler_IID = "41494D50-5372-7653-6368-6564756C6572";
		public static readonly Guid IAIMPServiceScheduler = new Guid(IAIMPServiceScheduler_IID);
	}
}