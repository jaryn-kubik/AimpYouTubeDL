using System;

namespace AimpSharp.Actions
{
	public static class IID
	{
		public const string IAIMPAction_IID = "41494D50-4163-7469-6F6E-000000000000";
		public static readonly Guid IAIMPAction = new Guid(IAIMPAction_IID);

		public const string IAIMPActionEvent_IID = "41494D50-4163-7469-6F6E-4576656E7400";
		public static readonly Guid IAIMPActionEvent = new Guid(IAIMPActionEvent_IID);

		public const string IAIMPServiceActionManager_IID = "41494D50-5372-7641-6374-696F6E4D616E";
		public static readonly Guid IAIMPServiceActionManager = new Guid(IAIMPServiceActionManager_IID);
	}
}