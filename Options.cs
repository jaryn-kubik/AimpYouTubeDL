using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace AIMPYoutubeDL
{
	public class Options
	{
		private static readonly byte[] _entropy = Encoding.ASCII.GetBytes("youtube-dl");
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

		public string UserName
		{
			get => GetEncrypted(string.Empty);
			set => SetEncrypted(value);
		}

		public string Password
		{
			get => GetEncrypted(string.Empty);
			set => SetEncrypted(value);
		}

		private T Get<T>(T def, string key, Func<string, T> convertValue) where T : IConvertible
		{
			try
			{
				var value = _root.Element(key)?.Value;
				if (value != null)
				{
					return convertValue(value);
				}
			}
			catch (Exception ex)
			{
				Trace.Fail(ex.ToString());
			}
			return def;
		}

		private T Get<T>(T def, [CallerMemberName] string key = null) where T : IConvertible
		{
			return Get(def, key, value => (T)Convert.ChangeType(value, typeof(T)));
		}

		private T GetEncrypted<T>(T def, [CallerMemberName] string key = null) where T : IConvertible
		{
			return Get(def, key, value =>
			{
				var encrypted = Convert.FromBase64String(value);
				var decrypted = ProtectedData.Unprotect(encrypted, _entropy, DataProtectionScope.CurrentUser);

				value = Encoding.UTF8.GetString(decrypted);
				return (T)Convert.ChangeType(value, typeof(T));
			});
		}

		private void Set(object value, [CallerMemberName] string key = null)
		{
			_root.SetElementValue(key, value);
			_root.Document.Save(_fileName);
		}

		private void SetEncrypted(object value, [CallerMemberName] string key = null)
		{
			var decrypted = Encoding.UTF8.GetBytes(value.ToString());
			var encrypted = ProtectedData.Protect(decrypted, _entropy, DataProtectionScope.CurrentUser);

			var base64 = Convert.ToBase64String(encrypted);
			Set(base64, key);
		}
	}
}