using System;

namespace AimpYouTubeDL.Api.Visuals
{
	public static class IID
	{
		public const string IAIMPExtensionCustomVisualization_IID = "41494D50-4578-7443-7374-6D5669730000";
		public static readonly Guid IAIMPExtensionCustomVisualization = new Guid(IAIMPExtensionCustomVisualization_IID);

		public const string IAIMPExtensionEmbeddedVisualization_IID = "41494D50-4578-7445-6D62-645669730000";
		public static readonly Guid IAIMPExtensionEmbeddedVisualization = new Guid(IAIMPExtensionEmbeddedVisualization_IID);

		public const string IAIMPServiceVisualizations_IID = "41494D50-5372-7656-6973-75616C000000";
		public static readonly Guid IAIMPServiceVisualizations = new Guid(IAIMPServiceVisualizations_IID);
	}
}