using System;

namespace AimpSharp.Playlist
{
	public static class IID
	{
		public const string IAIMPPlaylist_IID = "41494D50-506C-7300-0000-000000000000";
		public static readonly Guid IAIMPPlaylist = new Guid(IAIMPPlaylist_IID);

		public const string IAIMPPlaylistGroup_IID = "41494D50-506C-7347-726F-757000000000";
		public static readonly Guid IAIMPPlaylistGroup = new Guid(IAIMPPlaylistGroup_IID);

		public const string IAIMPPlaylistItem_IID = "41494D50-506C-7349-7465-6D0000000000";
		public static readonly Guid IAIMPPlaylistItem = new Guid(IAIMPPlaylistItem_IID);

		public const string IAIMPPlaylistListener_IID = "41494D50-506C-734C-7374-6E7200000000";
		public static readonly Guid IAIMPPlaylistListener = new Guid(IAIMPPlaylistListener_IID);

		public const string IAIMPPlaylistListener2_IID = "41494D50-506C-734C-7374-6E7232000000";
		public static readonly Guid IAIMPPlaylistListener2 = new Guid(IAIMPPlaylistListener2_IID);

		public const string IAIMPPlaylistQueue_IID = "41494D50-506C-7351-7565-756500000000";
		public static readonly Guid IAIMPPlaylistQueue = new Guid(IAIMPPlaylistQueue_IID);

		public const string IAIMPPlaylistQueue2_IID = "41494D50-506C-7351-7565-756532000000";
		public static readonly Guid IAIMPPlaylistQueue2 = new Guid(IAIMPPlaylistQueue2_IID);

		public const string IAIMPPlaylistQueueListener_IID = "41494D50-506C-7351-7565-75654C737400";
		public static readonly Guid IAIMPPlaylistQueueListener = new Guid(IAIMPPlaylistQueueListener_IID);

		public const string IAIMPExtensionPlaylistManagerListener_IID = "41494D50-4578-7450-6C73-4D616E4C7472";
		public static readonly Guid IAIMPExtensionPlaylistManagerListener = new Guid(IAIMPExtensionPlaylistManagerListener_IID);

		public const string IAIMPServicePlaylistManager_IID = "41494D50-5372-7650-6C73-4D616E000000";
		public static readonly Guid IAIMPServicePlaylistManager = new Guid(IAIMPServicePlaylistManager_IID);

		public const string IAIMPServicePlaylistManager2_IID = "41494D50-536D-504C-4D6E-677232000000";
		public static readonly Guid IAIMPServicePlaylistManager2 = new Guid(IAIMPServicePlaylistManager2_IID);

		public const string IAIMPPlaylistPreimageFolders_IID = "41494D50-536D-504C-5372-63466C647273";
		public static readonly Guid IAIMPPlaylistPreimageFolders = new Guid(IAIMPPlaylistPreimageFolders_IID);

		public const string IAIMPPlaylistPreimageDataProvider_IID = "41494D50-536D-506C-7344-617461507276";
		public static readonly Guid IAIMPPlaylistPreimageDataProvider = new Guid(IAIMPPlaylistPreimageDataProvider_IID);

		public const string IAIMPPlaylistPreimageListener_IID = "41494D50-536D-504C-4D6E-677200000000";
		public static readonly Guid IAIMPPlaylistPreimageListener = new Guid(IAIMPPlaylistPreimageListener_IID);

		public const string IAIMPPlaylistPreimage_IID = "41494D50-536D-504C-5372-630000000000";
		public static readonly Guid IAIMPPlaylistPreimage = new Guid(IAIMPPlaylistPreimage_IID);

		public const string IAIMPExtensionPlaylistPreimageFactory_IID = "41494D50-4578-7453-6D50-6C7346637400";
		public static readonly Guid IAIMPExtensionPlaylistPreimageFactory = new Guid(IAIMPExtensionPlaylistPreimageFactory_IID);
	}
}