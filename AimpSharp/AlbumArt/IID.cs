using System;

namespace AimpSharp.AlbumArt
{
	public static class IID
	{
		public const string IAIMPExtensionAlbumArtCatalog_IID = "41494D50-4578-7441-6C62-417274436174";
		public static readonly Guid IAIMPExtensionAlbumArtCatalog = new Guid(IAIMPExtensionAlbumArtCatalog_IID);

		public const string IAIMPExtensionAlbumArtCatalog2_IID = "41494D50-4578-416C-6241-727443617432";
		public static readonly Guid IAIMPExtensionAlbumArtCatalog2 = new Guid(IAIMPExtensionAlbumArtCatalog2_IID);

		public const string IAIMPExtensionAlbumArtProvider_IID = "41494D50-4578-7441-6C62-417274507276";
		public static readonly Guid IAIMPExtensionAlbumArtProvider = new Guid(IAIMPExtensionAlbumArtProvider_IID);

		public const string IAIMPExtensionAlbumArtProvider2_IID = "41494D50-4578-416C-6241-727450727632";
		public static readonly Guid IAIMPExtensionAlbumArtProvider2 = new Guid(IAIMPExtensionAlbumArtProvider2_IID);

		public const string IAIMPServiceAlbumArt_IID = "41494D50-5372-7641-6C62-417274000000";
		public static readonly Guid IAIMPServiceAlbumArt = new Guid(IAIMPServiceAlbumArt_IID);

		public const string IAIMPServiceAlbumArtCache_IID = "4941494D-5053-7276-416C-624172744368";
		public static readonly Guid IAIMPServiceAlbumArtCache = new Guid(IAIMPServiceAlbumArtCache_IID);
	}
}