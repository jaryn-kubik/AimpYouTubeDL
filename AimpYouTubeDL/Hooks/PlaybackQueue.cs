using AimpSharp;
using AimpSharp.FileManager;
using AimpSharp.FileManager.Enums;
using AimpSharp.Objects;
using AimpSharp.Player;
using AimpSharp.Player.Enums;
using AimpSharp.Playlists;
using AimpSharp.Playlists.Enums;
using AimpYouTubeDL.Utils;
using System.Linq;

namespace AimpYouTubeDL.Hooks
{
	public sealed class PlaybackQueue : IAIMPExtensionPlaybackQueue
	{
		public HRESULT GetNext(object Current, FlagsPlaybackQueue Flags, IAIMPPlaybackQueueItem QueueItem)
		{
			return HRESULT.S_OK;
		}

		public HRESULT GetPrev(object Current, FlagsPlaybackQueue Flags, IAIMPPlaybackQueueItem QueueItem)
		{
			return HRESULT.S_OK;
		}

		public void OnSelect(IAIMPPlaylistItem Item, IAIMPPlaybackQueueItem QueueItem)
		{
			Helpers.TryCatch(() =>
			{
				var fileInfo = Item.GetValueAsObject<IAIMPFileInfo>(PropIdPlaylistItem.AIMP_PLAYLISTITEM_PROPID_FILEINFO);
				var url = fileInfo.GetValueAsString(PropIdFileInfo.AIMP_FILEINFO_PROPID_FILENAME);
				if (url.StartsWith(Plugin.Scheme))
				{
					url = url.Substring(Plugin.Scheme.Length);
					var info = Plugin.YouTube.GetInfo(url).Single();
					info.UpdateAimpFileInfo(fileInfo);
				}
			});
		}
	}
}