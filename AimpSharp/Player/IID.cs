using System;

namespace AimpSharp.Player
{
	public static class IID
	{
		public const string IAIMPExtensionPlaybackQueue_IID = "41494D50-4578-7450-6C61-796261636B51";
		public static readonly Guid IAIMPExtensionPlaybackQueue = new Guid(IAIMPExtensionPlaybackQueue_IID);

		public const string IAIMPExtensionPlayerHook_IID = "41494D50-4578-7450-6C72-486F6F6B0000";
		public static readonly Guid IAIMPExtensionPlayerHook = new Guid(IAIMPExtensionPlayerHook_IID);

		public const string IAIMPEqualizerPreset_IID = "41494D50-4571-5072-7374-000000000000";
		public static readonly Guid IAIMPEqualizerPreset = new Guid(IAIMPEqualizerPreset_IID);

		public const string IAIMPPlaybackQueueItem_IID = "41494D50-506C-6179-6261-636B5149746D";
		public static readonly Guid IAIMPPlaybackQueueItem = new Guid(IAIMPPlaybackQueueItem_IID);

		public const string IAIMPServicePlaybackQueue_IID = "41494D50-5372-7650-6C62-61636B510000";
		public static readonly Guid IAIMPServicePlaybackQueue = new Guid(IAIMPServicePlaybackQueue_IID);

		public const string IAIMPServicePlayer_IID = "41494D50-5372-7650-6C61-796572000000";
		public static readonly Guid IAIMPServicePlayer = new Guid(IAIMPServicePlayer_IID);

		public const string IAIMPServicePlayerEqualizerPresets_IID = "41494D50-5372-7645-5150-727374730000";
		public static readonly Guid IAIMPServicePlayerEqualizerPresets = new Guid(IAIMPServicePlayerEqualizerPresets_IID);

		public const string IAIMPServicePlayerEqualizer_IID = "41494D50-5372-7645-5100-000000000000";
		public static readonly Guid IAIMPServicePlayerEqualizer = new Guid(IAIMPServicePlayerEqualizer_IID);

		public const string IAIMPServiceWaveform_IID = "41494D50-5372-7657-6176-650000000000";
		public static readonly Guid IAIMPServiceWaveform = new Guid(IAIMPServiceWaveform_IID);

		public const string IAIMPExtensionWaveformProvider_IID = "41494D50-4578-7457-6176-507276000000";
		public static readonly Guid IAIMPExtensionWaveformProvider = new Guid(IAIMPExtensionWaveformProvider_IID);
	}
}