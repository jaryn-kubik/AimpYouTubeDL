﻿using AimpSharp;
using AimpSharp.Objects;
using AimpSharp.Player;
using AimpYouTubeDL.Utils;

namespace AimpYouTubeDL.Hooks
{
	public sealed class PlayerHook : IAIMPExtensionPlayerHook
	{
		public HRESULT OnCheckURL(IAIMPString URL, ref bool Handled)
		{
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