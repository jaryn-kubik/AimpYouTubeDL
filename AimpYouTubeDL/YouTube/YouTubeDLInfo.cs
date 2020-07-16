using AimpSharp;
using AimpSharp.Core;
using AimpSharp.FileManager;
using AimpSharp.FileManager.Enums;
using AimpSharp.Objects;
using Python.Runtime;

namespace AimpYouTubeDL.YouTube
{
	public sealed class YouTubeDLInfo
	{
		public string WebpageUrl { get; set; }
		public string Url { get; set; }
		public double Duration { get; set; }

		public string Title { get; set; }
		public string Album { get; set; }
		public string Thumbnail { get; set; }

		private YouTubeDLInfo() { }

		public void UpdateAimpFileInfo(IAIMPFileInfo fileInfo)
		{
			fileInfo.SetValueAsString(PropIdFileInfo.AIMP_FILEINFO_PROPID_FILENAME, Plugin.Scheme + WebpageUrl);
			fileInfo.SetValueAsString(PropIdFileInfo.AIMP_FILEINFO_PROPID_TITLE, Title);
			fileInfo.SetValueAsFloat(PropIdFileInfo.AIMP_FILEINFO_PROPID_DURATION, Duration);
			fileInfo.SetValueAsString(PropIdFileInfo.AIMP_FILEINFO_PROPID_ALBUM, Album);
		}

		public IAIMPFileInfo ToAimpFileInfo()
		{
			var fileInfo = PluginWrapper.Core.CreateObject<IAIMPFileInfo>();
			UpdateAimpFileInfo(fileInfo);
			return fileInfo;
		}

		public static YouTubeDLInfo FromResult(PyDict item, PyDict parent)
		{
			var extractor = GetKey<string>(parent ?? item, "extractor");
			extractor = extractor.Split(':')[0];

			var webpageUrl = GetKey<string>(item, "webpage_url") ?? GetKey<string>(item, "url");
			var url = GetKey<string>(item, "url");
			var duration = GetKey<double?>(item, "duration");

			var title = GetKey<string>(item, "title");
			var uploader = GetKey<string>(item, "uploader");
			var thumbnail = GetKey<string>(item, "thumbnail");

			if (extractor == _extractorSoundcloud && uploader != null)
			{
				title = $"{uploader} - {title}";
			}

			return new YouTubeDLInfo
			{
				WebpageUrl = webpageUrl,
				Url = url,
				Duration = duration ?? 0,

				Title = title ?? url,
				Album = uploader,
				Thumbnail = thumbnail
			};
		}

		private static T GetKey<T>(PyDict obj, string key)
		{
			if (obj.HasKey(key))
			{
				return obj.GetItem(key).As<T>();
			}
			return default;
		}

		private const string _extractorYoutube = "youtube";
		private const string _extractorSoundcloud = "soundcloud";
	}
}