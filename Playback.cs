using AIMP.SDK;
using AIMP.SDK.FileManager;
using AIMP.SDK.MenuManager;
using AIMP.SDK.Player;
using AIMP.SDK.Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public class Playback : IDisposable
	{
		private const string _scheme = @"ydl:\\";
		private readonly IAimpPlayer _player;
		private readonly YouTubeDL _ytb;
		private readonly CancellationTokenSource _ytbCancel = new CancellationTokenSource();
		private Task<IEnumerable<YouTubeDLInfo>> _ytbTask;

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
			_ytbCancel.Cancel();
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
			IAimpPlaylist playlist;
			if (string.IsNullOrWhiteSpace(newPlaylist))
			{
				_player.PlaylistManager.GetActivePlaylist(out playlist);
			}
			else
			{
				_player.PlaylistManager.CreatePlaylist(newPlaylist, true, out playlist);
			}

			if (_ytbTask?.IsCompleted == false)
			{
				throw new InvalidOperationException("Task already running!");
			}

			_ytbTask = Task.Run(() => _ytb.GetInfo(url), _ytbCancel.Token);
			_ytbTask.ContinueWith(info => Utils.HandleException(() =>
			{
				var fileInfo = info.Result.Select(x => new AimpFileInfo
				{
					FileName = _scheme + x.WebPageUrl,
					Title = x.Title,
					Duration = x.Duration,
					Album = x.Uploader,
					AlbumArt = new System.Drawing.Bitmap(1, 1)
				}).ToList<IAimpFileInfo>();

				var task = new ActionAimpTask(() => playlist.AddList(fileInfo, PlaylistFlags.FILEINFO, PlaylistFilePosition.CurrentPosition));
				_player.ServiceSynchronizer.ExecuteInMainThread(task, false);
			}));
		}
	}
}