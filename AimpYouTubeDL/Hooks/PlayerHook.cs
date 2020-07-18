using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.Objects;
using AimpYouTubeDL.Api.Player;
using AimpYouTubeDL.Utils;
using System.Diagnostics;

namespace AimpYouTubeDL.Hooks
{
	public sealed class PlayerHook : IAIMPExtensionPlayerHook
	{
		public HRESULT OnCheckURL(IAIMPString URL, ref bool Handled)
		{
			Trace.WriteLine(nameof(OnCheckURL), nameof(PlayerHook));

			Handled = Helpers.TryCatch(() =>
			{
				if (URL.TryGetInfo(out var info))
				{
					URL.SetData(info.Url).EnsureSuccess();
					return true;
				}
				return false;
			});
			return HRESULT.S_OK;
		}
	}
}