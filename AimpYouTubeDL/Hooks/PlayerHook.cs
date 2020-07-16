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
			var url = URL.GetData();
			if (url.StartsWith(Plugin.Scheme) && Helpers.TryCatch(GetAudioUrl, url, out var newUrl))
			{
				URL.SetData(newUrl);
				Handled = true;
			}
			return HRESULT.S_OK;
		}

		private string GetAudioUrl(string fullUrl)
		{
			var url = fullUrl.Substring(Plugin.Scheme.Length);
			var info = Plugin.YouTube.GetInfo(url).Single();
			return info.Url;
		}

		/*
_player.MenuManager.GetBuiltIn(ParentMenuType.AIMP_MENUID_PLAYER_PLAYLIST_ADDING, out var menuParent);
_player.MenuManager.CreateMenuItem(out var menuItem);
menuItem.Name = "YouTube-DL";
menuItem.Parent = menuParent;
menuItem.OnExecute += MenuItem_OnExecute;
_player.MenuManager.Add(menuItem);
*/

		/*private void MenuItem_OnExecute(object sender, EventArgs e)
		{
			Helpers.TryCatch(() =>
			{
				var form = new PlaybackAddForm(Helpers.GetVisualStyle(_player));
				if (form.ShowDialog() == DialogResult.OK)
				{
					AddToPlaylist(form.Url, form.Playlist);
				}
			});
		}

		private void AddToPlaylist(string url, string newPlaylist)
		{
			var info = _ytb.GetInfo(url);
			var fileInfo = info.Select(x => x.ToAimpFileInfo()).ToList();

			IAimpPlaylist playlist;
			if (string.IsNullOrWhiteSpace(newPlaylist))
			{
				_player.PlaylistManager.GetActivePlaylist(out playlist);
			}
			else
			{
				_player.PlaylistManager.CreatePlaylist(newPlaylist, true, out playlist);
			}
			playlist.AddList(fileInfo, PlaylistFlags.FILEINFO, PlaylistFilePosition.CurrentPosition);
		}*/
	}
}