using AimpSharp.Core;

namespace AimpSharp.Objects
{
	public static class Extensions
	{
		public static IAIMPString CreateString(this IAIMPCore core, string text)
		{
			var str = core.CreateObject<IAIMPString>(IID.IAIMPString);
			str.SetData(text).EnsureSuccess();
			return str;
		}
	}
}