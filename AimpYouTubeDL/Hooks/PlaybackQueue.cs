using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.FileManager;
using AimpYouTubeDL.Api.FileManager.Enums;
using AimpYouTubeDL.Api.Objects;
using AimpYouTubeDL.Api.Player;
using AimpYouTubeDL.Api.Player.Enums;
using AimpYouTubeDL.Api.Playlists;
using AimpYouTubeDL.Api.Playlists.Enums;
using AimpYouTubeDL.Utils;
using System.Runtime.InteropServices;

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
				var fileName = fileInfo.GetValueAsString(PropIdFileInfo.AIMP_FILEINFO_PROPID_FILENAME);

				if (fileName.TryGetInfo(out var info))
				{
					info.UpdateAimpFileInfo(fileInfo);
				}

				Marshal.FinalReleaseComObject(fileInfo);
			});
		}
	}
}