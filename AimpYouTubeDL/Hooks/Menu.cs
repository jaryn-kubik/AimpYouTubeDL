﻿using AimpSharp;
using AimpSharp.Core;
using AimpSharp.Menu;
using AimpSharp.Menu.Enums;
using AimpSharp.Objects;
using AimpSharp.Playlists;
using AimpSharp.Playlists.Enums;
using AimpYouTubeDL.Utils;
using System.Windows.Forms;

namespace AimpYouTubeDL.Hooks
{
	public static class Menu
	{
		public static void AddPlaylistAddingMenu()
		{
			var manager = PluginWrapper.Core.GetService<IAIMPServiceMenuManager>();
			manager.GetBuiltIn(MenuId.AIMP_MENUID_PLAYER_PLAYLIST_ADDING, out var menuPlaylistAdding).EnsureSuccess();

			var menuItem = PluginWrapper.Core.CreateObject<IAIMPMenuItem>();
			menuItem.SetValueAsObject(PropIdMenuItem.AIMP_MENUITEM_PROPID_PARENT, menuPlaylistAdding);
			menuItem.SetValueAsString(PropIdMenuItem.AIMP_MENUITEM_PROPID_NAME, "YouTube-DL");
			menuItem.SetValueAsObject(PropIdMenuItem.AIMP_MENUITEM_PROPID_EVENT, new AimpActionEvent(OnPlaylistAddingMenu));

			PluginWrapper.Core.RegisterExtension<IAIMPServiceMenuManager>(menuItem);
		}

		private static void OnPlaylistAddingMenu()
		{
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
			var infos = Plugin.YouTube.GetInfo(url);
			var list = PluginWrapper.Core.CreateObject<IAIMPObjectList>();

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
			if (string.IsNullOrWhiteSpace(newPlaylist))
			{
				PluginWrapper.Core.GetService<IAIMPServicePlaylistManager>().GetActivePlaylist(out var playlist).EnsureSuccess();
				return playlist;
			}
			else
			{
				var name = PluginWrapper.Core.CreateString(newPlaylist);
				PluginWrapper.Core.GetService<IAIMPServicePlaylistManager>().CreatePlaylist(name, true, out var playlist).EnsureSuccess();
				return playlist;
			}
		}
	}
}