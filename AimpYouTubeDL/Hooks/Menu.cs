using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.Core;
using AimpYouTubeDL.Api.Menu;
using AimpYouTubeDL.Api.Menu.Enums;
using AimpYouTubeDL.Api.Objects;
using AimpYouTubeDL.Api.Playlists;
using AimpYouTubeDL.Api.Playlists.Enums;
using AimpYouTubeDL.Utils;
using System.Diagnostics;
using System.Windows.Forms;

namespace AimpYouTubeDL.Hooks
{
	public static class Menu
	{
		public static void AddPlaylistAddingMenu()
		{
			Trace.WriteLine(nameof(AddPlaylistAddingMenu), nameof(Menu));

			var manager = Plugin.Core.GetService<IAIMPServiceMenuManager>();
			manager.GetBuiltIn(MenuId.AIMP_MENUID_PLAYER_PLAYLIST_ADDING, out var menuPlaylistAdding).EnsureSuccess();

			var menuItem = Plugin.Core.CreateObject<IAIMPMenuItem>();
			menuItem.SetValueAsObject(PropIdMenuItem.AIMP_MENUITEM_PROPID_PARENT, menuPlaylistAdding);
			menuItem.SetValueAsString(PropIdMenuItem.AIMP_MENUITEM_PROPID_NAME, "YouTube-DL");
			menuItem.SetValueAsObject(PropIdMenuItem.AIMP_MENUITEM_PROPID_EVENT, new AimpActionEvent(OnPlaylistAddingMenu));

			Plugin.Core.RegisterExtension<IAIMPServiceMenuManager>(menuItem);
		}

		private static void OnPlaylistAddingMenu()
		{
			Trace.WriteLine(nameof(OnPlaylistAddingMenu), nameof(Menu));

			Helpers.TryCatch(() =>
			{
				var form = new PlaybackAddForm(Helpers.GetVisualStyle());
				if (form.ShowDialog() == DialogResult.OK)
				{
					AddToPlaylist(form.Url, form.Playlist);
				}
			});
		}

		private static void AddToPlaylist(string url, string newPlaylist)
		{
			Trace.WriteLine(nameof(AddToPlaylist), nameof(Menu));

			var infos = Plugin.YouTube.GetInfo(url);
			var list = Plugin.Core.CreateObject<IAIMPObjectList>();

			foreach (var info in infos)
			{
				var fileInfo = info.ToAimpFileInfo();
				list.Add(fileInfo).EnsureSuccess();
			}

			var playlist = GetPlaylist(newPlaylist);
			playlist.AddList(list, FlagsPlaylistAdd.AIMP_PLAYLIST_ADD_FLAGS_FILEINFO, 0).EnsureSuccess();
		}

		private static IAIMPPlaylist GetPlaylist(string newPlaylist)
		{
			Trace.WriteLine(nameof(GetPlaylist), nameof(Menu));

			if (string.IsNullOrWhiteSpace(newPlaylist))
			{
				Plugin.Core.GetService<IAIMPServicePlaylistManager>().GetActivePlaylist(out var playlist).EnsureSuccess();
				return playlist;
			}
			else
			{
				var name = Plugin.Core.CreateString(newPlaylist);
				Plugin.Core.GetService<IAIMPServicePlaylistManager>().CreatePlaylist(name, true, out var playlist).EnsureSuccess();
				return playlist;
			}
		}
	}
}