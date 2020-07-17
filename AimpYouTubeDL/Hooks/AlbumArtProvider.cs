using AimpSharp;
using AimpSharp.AlbumArt;
using AimpSharp.AlbumArt.Enums;
using AimpSharp.Core;
using AimpSharp.Objects;
using AimpSharp.Objects.Enums;
using AimpYouTubeDL.Utils;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Hooks
{
	public class AlbumArtProvider : IAIMPExtensionAlbumArtProvider
	{
		public AlbumArtCategory GetCategory()
		{
			return AlbumArtCategory.AIMP_ALBUMART_PROVIDER_CATEGORY_INTERNET;
		}

		public HRESULT Get(IAIMPString FileURI, IAIMPString Artist, IAIMPString Album, IAIMPPropertyList Options, out IAIMPImageContainer Image)
		{
			var result = Helpers.TryCatch(TryGetImage, FileURI, out Image);
			return result ? HRESULT.S_OK : HRESULT.E_FAIL;
		}

		private bool TryGetImage(IAIMPString FileURI, out IAIMPImageContainer image)
		{
			if (FileURI.TryGetInfo(out var info) && !string.IsNullOrEmpty(info.Thumbnail))
			{
				Trace.WriteLine($"Getting album art for '{FileURI.GetData()}' from '{info.Thumbnail}'...", nameof(AlbumArtProvider));

				using var client = new HttpClient();
				var bytes = client.GetByteArrayAsync(info.Thumbnail).GetAwaiter().GetResult();

				var container = PluginWrapper.Core.CreateObject<IAIMPImageContainer>();
				container.SetDataSize(bytes.Length).EnsureSuccess();
				var ptr = container.GetData();
				Marshal.Copy(bytes, 0, ptr, bytes.Length);

				container.GetInfo(out var size, out var format).EnsureSuccess();
				Trace.WriteLine($"... downloaded image width='{size.X}' height='{size.Y}' format='{format}'", nameof(AlbumArtProvider));
				if (format != ImageFormat.AIMP_IMAGE_FORMAT_UNKNOWN)
				{
					image = container;
					return true;
				}
			}
			image = null;
			return false;
		}
	}
}