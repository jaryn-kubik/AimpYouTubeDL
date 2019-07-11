using AIMP.SDK.MenuManager;
using AIMP.SDK.Player;
using AIMP.SDK.Playlist;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public class Playback : IDisposable
	{
		public const string Scheme = @"ydl:\\";
		private readonly IAimpPlayer _player;
		private readonly YouTubeDL _ytb;

		public Playback(IAimpPlayer player, YouTubeDL ytb)
		{
			_ytb = ytb;

			_player = player;
			_player.PlaybackQueueManager.OnCheckURL += PlaybackQueueManager_OnCheckURL;

			_player.MenuManager.GetBuiltIn(ParentMenuType.AIMP_MENUID_PLAYER_PLAYLIST_ADDING, out var menuParent);
			_player.MenuManager.CreateMenuItem(out var menuItem);
			menuItem.Name = "YouTube-DL";
			menuItem.Parent = menuParent;
			menuItem.OnExecute += MenuItem_OnExecute;
			_player.MenuManager.Add(menuItem);
		}

		public void Dispose()
		{
			_player.PlaybackQueueManager.OnCheckURL -= PlaybackQueueManager_OnCheckURL;
		}

		private bool PlaybackQueueManager_OnCheckURL(ref string fullUrl)
		{
			if (!fullUrl.StartsWith(Scheme))
			{
				return false;
			}

			var url = fullUrl.Substring(Scheme.Length);
			fullUrl = Utils.HandleException(() =>
			{
				var info = _ytb.GetInfo(url).Single();
				var task = new ActionAimpTask(() =>
				{
					_player.PlaylistManager.GetActivePlaylist(out var playlist);
					var item = playlist.GetItem(playlist.PlayingIndex);
					info.UpdateAimpFileInfo(item.FileInfo);
					item.FileName = item.FileInfo.FileName;
				});
				_player.ServiceSynchronizer.ExecuteInMainThread(task, false);
				return info.Url;
			});
			return true;
		}

		private void MenuItem_OnExecute(object sender, EventArgs e)
		{
			Utils.HandleException(() =>
			{
				var form = new PlaybackAddForm();
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
		}
	}
}