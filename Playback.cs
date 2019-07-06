using AIMP.SDK;
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
		private const string _scheme = @"ydl:\\";
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
			if (fullUrl.StartsWith(_scheme))
			{
				var url = fullUrl.Substring(_scheme.Length);
				fullUrl = Utils.HandleException(() => _ytb.GetInfo(url).Single().Url);
				return true;
			}
			return false;
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
			foreach (var info in _ytb.GetInfo(url))
			{
				var file = new AimpFileInfo
				{
					FileName = _scheme + url,
					Title = info.Title,
					Duration = info.Duration,
					Album = info.Uploader,
					AlbumArt = new System.Drawing.Bitmap(1, 1)
				};

				IAimpPlaylist playlist;
				if (string.IsNullOrEmpty(newPlaylist))
				{
					_player.PlaylistManager.GetActivePlaylist(out playlist);
				}
				else
				{
					_player.PlaylistManager.CreatePlaylist(newPlaylist, true, out playlist);
				}
				playlist.Add(file, PlaylistFlags.FILEINFO, PlaylistFilePosition.CurrentPosition);
			}
		}
	}
}