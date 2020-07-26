using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace AimpYouTubeDL.Config
{
	public sealed class Options
	{
		private const string _formatDefault = "bestaudio[protocol=m3u8_native]/bestaudio[protocol=m3u8]/best[ext=mp4]/best";
		private string _path;
		private string _format = _formatDefault;

		private Options() { }
		private Options(string path) { _path = path; }

		[XmlElement, DefaultValue(_formatDefault)]
		public string Format
		{
			get => _format;
			set => _format = string.IsNullOrWhiteSpace(value) ? _formatDefault : value;
		}

		[XmlArray, XmlArrayItem("Auth")]
		public List<OptionsAuth> Auths { get; set; } = new List<OptionsAuth>();

		public void Save()
		{
			using var ms = new MemoryStream();
			using var stream = new StreamWriter(ms);

			var serializer = new XmlSerializer(GetType());
			serializer.Serialize(stream, this);
			stream.Flush();
			File.WriteAllBytes(_path, ms.ToArray());
		}

		public static Options Load(string dirAppData)
		{
			var path = Path.Combine(dirAppData, Plugin.Name + ".xml");
			try
			{
				using var stream = File.OpenRead(path);

				var serializer = new XmlSerializer(typeof(Options));
				var result = (Options)serializer.Deserialize(stream);
				result._path = path;
				return result;
			}
			catch (Exception ex)
			{
				if (!(ex is FileNotFoundException))
				{
					Trace.Fail(ex.ToString());
				}
				return new Options(path);
			}
		}
	}

	public class OptionsAuth
	{
		[XmlElement]
		public string Extractor { get; set; }

		[XmlElement]
		public OptionsProtectedString UserName { get; set; }

		[XmlElement]
		public OptionsProtectedString Password { get; set; }
	}
}