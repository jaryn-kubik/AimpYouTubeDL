using System;

namespace AimpSharp.Menu
{
	public static class IID
	{
		public const string IAIMPMenuItem_IID = "41494D50-4D65-6E75-4974-656D00000000";
		public static readonly Guid IAIMPMenuItem = new Guid(IAIMPMenuItem_IID);

		public const string IAIMPServiceMenuManager_IID = "41494D50-5372-764D-656E-754D6E677200";
		public static readonly Guid IAIMPServiceMenuManager = new Guid(IAIMPServiceMenuManager_IID);
	}
}