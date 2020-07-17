using System;

namespace AimpYouTubeDL.Api.Decoders
{
	public static class IID
	{
		public const string IAIMPAudioDecoder_IID = "41494D50-4175-6469-6F44-656300000000";
		public static readonly Guid IAIMPAudioDecoder = new Guid(IAIMPAudioDecoder_IID);

		public const string IAIMPAudioDecoderBufferingProgress_IID = "41494D50-4175-6469-6F44-656342756666";
		public static readonly Guid IAIMPAudioDecoderBufferingProgress = new Guid(IAIMPAudioDecoderBufferingProgress_IID);

		public const string IAIMPExtensionAudioDecoder_IID = "41494D50-4578-7441-7564-696F44656300";
		public static readonly Guid IAIMPExtensionAudioDecoder = new Guid(IAIMPExtensionAudioDecoder_IID);

		public const string IAIMPExtensionAudioDecoderOld_IID = "41494D50-4578-7441-7564-696F4465634F";
		public static readonly Guid IAIMPExtensionAudioDecoderOld = new Guid(IAIMPExtensionAudioDecoderOld_IID);

		public const string IAIMPExtensionAudioDecoderPriority_IID = "41494D50-4578-7444-6563-5072696F7200";
		public static readonly Guid IAIMPExtensionAudioDecoderPriority = new Guid(IAIMPExtensionAudioDecoderPriority_IID);

		public const string IAIMPServiceAudioDecoders_IID = "41494D50-5372-7641-7564-696F44656300";
		public static readonly Guid IAIMPServiceAudioDecoders = new Guid(IAIMPServiceAudioDecoders_IID);

		public const string IAIMPAudioDecoderListener_IID = "41494D50-4175-6469-6F44-65634C737400";
		public static readonly Guid IAIMPAudioDecoderListener = new Guid(IAIMPAudioDecoderListener_IID);

		public const string IAIMPAudioDecoderNotifications_IID = "41494D50-4175-6469-6F44-65634E746679";
		public static readonly Guid IAIMPAudioDecoderNotifications = new Guid(IAIMPAudioDecoderNotifications_IID);
	}
}