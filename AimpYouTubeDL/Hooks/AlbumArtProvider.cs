using AimpSharp;
using AimpSharp.AlbumArt;
using AimpSharp.AlbumArt.Enums;
using AimpSharp.Core;
using AimpSharp.Objects;
using AimpYouTubeDL.Utils;
using System.Net.Http;

namespace AimpYouTubeDL.Hooks
{
	public class AlbumArtProvider : IAIMPExtensionAlbumArtProvider
	{
		public HRESULT Get(IAIMPString FileURI, IAIMPString Artist, IAIMPString Album, IAIMPPropertyList Options, out IAIMPImageContainer Image)
		{
			if (FileURI.TryGetInfo(out var info) && !string.IsNullOrEmpty(info.Thumbnail))
			{
				using var client = new HttpClient();
				var bytes = client.GetByteArrayAsync(info.Thumbnail).GetAwaiter().GetResult();

				var container = PluginWrapper.Core.CreateObject<IAIMPImageContainer>();
				container.CreateImage(out var image).EnsureSuccess();
				//return HRESULT.S_OK;
			}
			Image = null;
			return HRESULT.E_FAIL;
		}

		public AlbumArtCategory GetCategory()
		{
			return AlbumArtCategory.AIMP_ALBUMART_PROVIDER_CATEGORY_TAGS;
		}
	}
}