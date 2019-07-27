using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace AIMPYoutubeDL
{
	public class Options
	{
		private readonly string _fileName;
		private readonly XElement _root;

		public Options(string dirAppData, string fileName)
		{
			try
			{
				_fileName = Path.Combine(dirAppData, fileName + ".xml");
				var xml = XDocument.Load(_fileName);
				_root = xml.Root;
			}
			catch (Exception ex)
			{
				if (!(ex is FileNotFoundException))
				{
					Trace.Fail(ex.ToString());
				}
				_root = new XDocument(new XElement("ydl")).Root;
			}
		}

		public bool AutoUpdate
		{
			get => Get(false);
			set => Set(value);
		}

		public string Format
		{
			get => Get("best[ext=mp4]/best");
			set => Set(value.Trim());
		}

		private T Get<T>(T def, [CallerMemberName] string key = null) where T : IConvertible
		{
			try
			{
				var value = _root.Element(key)?.Value;
				if (value != null)
				{
					return (T)Convert.ChangeType(value, typeof(T));
				}
			}
			catch (Exception ex)
			{
				Trace.Fail(ex.ToString());
			}
			return def;
		}

		private void Set(object value, [CallerMemberName] string key = null)
		{
			_root.SetElementValue(key, value);
			_root.Document.Save(_fileName);
		}
	}
}