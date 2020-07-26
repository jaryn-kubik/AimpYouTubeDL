using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.FileManager;
using AimpYouTubeDL.Api.FileManager.Enums;
using AimpYouTubeDL.Api.Objects;
using AimpYouTubeDL.Api.Player;
using AimpYouTubeDL.Api.Player.Enums;
using AimpYouTubeDL.Api.Playlists;
using AimpYouTubeDL.Api.Playlists.Enums;
using AimpYouTubeDL.Utils;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Hooks
{
	public sealed class PlaybackQueue : IAIMPExtensionPlaybackQueue
	{
		public void OnSelect(IAIMPPlaylistItem Item, IAIMPPlaybackQueueItem QueueItem) { }

		public HRESULT GetNext(object Current, FlagsPlaybackQueue Flags, IAIMPPlaybackQueueItem QueueItem)
		{
			Trace.WriteLine(nameof(GetNext), nameof(PlaybackQueue));
			return UpdateCurrentItem(Current, Flags);
		}

		public HRESULT GetPrev(object Current, FlagsPlaybackQueue Flags, IAIMPPlaybackQueueItem QueueItem)
		{
			Trace.WriteLine(nameof(GetPrev), nameof(PlaybackQueue));
			return UpdateCurrentItem(Current, Flags);
		}

		private HRESULT UpdateCurrentItem(object Current, FlagsPlaybackQueue Flags)
		{
			if (Flags != FlagsPlaybackQueue.AIMP_PLAYBACKQUEUE_FLAGS_START_FROM_ITEM)
			{
				return HRESULT.S_OK;
			}

			var result = Helpers.TryCatch(() =>
			{
				var current = (IAIMPPlaylistItem)Current;
				var fileInfo = current.GetValueAsObject<IAIMPFileInfo>(PropIdPlaylistItem.AIMP_PLAYLISTITEM_PROPID_FILEINFO);
				var fileName = fileInfo.GetValueAsString(PropIdFileInfo.AIMP_FILEINFO_PROPID_FILENAME);
				Trace.WriteLine(nameof(UpdateCurrentItem) + " - " + fileName, nameof(PlaybackQueue));

				if (fileName.TryGetInfo(out var info))
				{
					info.UpdateAimpFileInfo(fileInfo);
				}
				Marshal.FinalReleaseComObject(fileInfo);
			});
			return result.ToHRESULT();
		}
	}
}