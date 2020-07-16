using System;
using System.Diagnostics;
using System.IO;

namespace AimpYouTubeDL.Utils
{
	public class Logger : TraceListener
	{
		private StreamWriter _stream;

		public Logger(string dirAppData)
		{
			var path = Path.Combine(dirAppData, Plugin.Name + ".log");
			_stream = new StreamWriter(path, false) { AutoFlush = true };
		}

		public override void Close()
		{
			base.Close();
			_stream?.Dispose();
			_stream = null;
		}

		public override void Write(string message)
		{
			WriteLine(message);
		}

		public override void WriteLine(string message)
		{
			WriteLine(message, string.Empty);
		}

		public override void WriteLine(string message, string category)
		{
			_stream?.WriteLine("{0:yyyy-MM-dd HH:mm:ss} [{1,20}] {2}", DateTime.Now, category, message);
#if DEBUG
			//_stream?.WriteLine(Environment.StackTrace);
#endif
		}

		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			WriteLine(message, eventType.ToString().ToUpperInvariant());
		}

		public override void Fail(string message)
		{
			WriteLine(message, nameof(TraceEventType.Critical).ToUpperInvariant());
		}
	}
}