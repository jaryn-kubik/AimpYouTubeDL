using AIMP.SDK;
using AIMP.SDK.FileManager;
using Python.Runtime;

namespace AIMPYoutubeDL
{
	public class YouTubeDLInfo
	{
		public string WebpageUrl { get; set; }
		public string Url { get; set; }
		public double Duration { get; set; }

		public string Title { get; set; }
		public string Album { get; set; }

		public void UpdateAimpFileInfo(IAimpFileInfo fileInfo)
		{
			fileInfo.FileName = Playback.Scheme + WebpageUrl;
			fileInfo.Title = Title;
			fileInfo.Duration = Duration;
			fileInfo.Album = Album;
			if (fileInfo.AlbumArt == null)
			{
				fileInfo.AlbumArt = new System.Drawing.Bitmap(1, 1);
			}
		}

		public IAimpFileInfo ToAimpFileInfo()
		{
			var fileInfo = new AimpFileInfo();
			UpdateAimpFileInfo(fileInfo);
			return fileInfo;
		}

		public static YouTubeDLInfo FromResult(PyDict item, PyDict parent)
		{
			var extractor = GetKey<string>(parent ?? item, "extractor");
			extractor = extractor.Split(':')[0];

			var webpageUrl = GetKey<string>(item, "webpage_url") ?? GetKey<string>(item, "url");
			var url = GetKey<string>(item, "url");
			var duration = GetKey<double>(item, "duration");

			var title = GetKey<string>(item, "title");
			var uploader = GetKey<string>(item, "uploader");

			if (extractor == _extractorSoundcloud && uploader != null)
			{
				title = $"{uploader} - {title}";
			}

			return new YouTubeDLInfo
			{
				WebpageUrl = webpageUrl,
				Url = url,
				Duration = duration,

				Title = title ?? url,
				Album = uploader
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