using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public class YouTubeDLLogger
	{
		public void debug(string msg)
		{

		}

		public void warning(string msg)
		{
		}

		public void error(string msg)
		{
			MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}