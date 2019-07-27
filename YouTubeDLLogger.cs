using System.Diagnostics;

namespace AIMPYoutubeDL
{
	public class YouTubeDLLogger
	{
		public void debug(string msg)
		{
			Trace.WriteLine(msg, "youtube-dl DEBUG");
		}

		public void warning(string msg)
		{
			Trace.WriteLine(msg, "youtube-dl WARNING");
		}

		public void error(string msg)
		{
			Trace.WriteLine(msg, "youtube-dl ERROR");
		}
	}
}