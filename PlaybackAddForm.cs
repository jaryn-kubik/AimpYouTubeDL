using System;
using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public partial class PlaybackAddForm : Form
	{
		public PlaybackAddForm()
		{
			InitializeComponent();

			OnCheckedChanged(this, EventArgs.Empty);
			if (Clipboard.ContainsText())
			{
				var text = Clipboard.GetText();
				if (text.StartsWith("http"))
				{
					_url.Text = text;
				}
			}
		}

		private void OnCheckedChanged(object sender, EventArgs e)
		{
			_playlist.Enabled = _playlistCheck.Checked;
		}

		public string Url => _url.Text?.Trim();
		public string Playlist => _playlistCheck.Checked ? _playlist.Text?.Trim() : null;
	}
}