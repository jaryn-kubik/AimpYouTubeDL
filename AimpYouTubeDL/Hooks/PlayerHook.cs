using AimpSharp;
using AimpSharp.Objects;
using AimpSharp.Player;
using AimpYouTubeDL.Utils;
using System.Linq;

namespace AimpYouTubeDL.Hooks
{
	public sealed class PlayerHook : IAIMPExtensionPlayerHook
	{
		public HRESULT OnCheckURL(IAIMPString URL, ref bool Handled)
		{
			Handled = Helpers.TryCatch(() =>
			{
				var url = URL.GetData();
				if (url.StartsWith(Plugin.Scheme))
				{
					url = url.Substring(Plugin.Scheme.Length);
					var info = Plugin.YouTube.GetInfo(url).Single();
					URL.SetData(info.Url).EnsureSuccess();
					return true;
				}
				return false;
			});
			return HRESULT.S_OK;
		}
	}
}