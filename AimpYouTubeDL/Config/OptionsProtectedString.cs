using System;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace AimpYouTubeDL.Config
{
	public sealed class OptionsProtectedString : IXmlSerializable
	{
		private static readonly byte[] _entropy = Encoding.ASCII.GetBytes(nameof(OptionsProtectedString));
		private string _value;

		private OptionsProtectedString() { }
		private OptionsProtectedString(string value) { _value = value; }

		public XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(XmlReader reader)
		{
			_value = reader.ReadElementContentAsString();
		}

		public void WriteXml(XmlWriter writer)
		{
			writer.WriteString(_value);
		}

		public static implicit operator string(OptionsProtectedString value)
		{
			var encrypted = Convert.FromBase64String(value._value);
			var decrypted = ProtectedData.Unprotect(encrypted, _entropy, DataProtectionScope.CurrentUser);
			return Encoding.UTF8.GetString(decrypted);
		}

		public static implicit operator OptionsProtectedString(string value)
		{
			var decrypted = Encoding.UTF8.GetBytes(value);
			var encrypted = ProtectedData.Protect(decrypted, _entropy, DataProtectionScope.CurrentUser);
			return new OptionsProtectedString(Convert.ToBase64String(encrypted));
		}
	}
}