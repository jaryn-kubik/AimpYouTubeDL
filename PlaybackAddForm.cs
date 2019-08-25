using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public partial class PlaybackAddForm : Form
	{
		private readonly VisualStyle _style;

		public PlaybackAddForm(VisualStyle style)
		{
			InitializeComponent();

			_style = style;
			if (_style == VisualStyle.Dark)
			{
				BackColor = Color.FromArgb(38, 38, 38);
				ForeColor = Color.WhiteSmoke;
				_url.BackColor = _playlist.BackColor = Color.FromArgb(42, 42, 42);
				_url.ForeColor = _playlist.ForeColor = Color.WhiteSmoke;
				button1.BackColor = button2.BackColor = Color.FromArgb(56, 56, 56);
				button1.FlatAppearance.BorderColor = button2.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
			}

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
			if (_style == VisualStyle.Dark)
			{
				if (_playlist.Enabled)
				{
					_playlist.BackColor = Color.FromArgb(42, 42, 42);
				}
				else
				{
					_playlist.BackColor = Color.FromArgb(21, 21, 21);
				}
			}
		}

		public string Url => _url.Text?.Trim();
		public string Playlist => _playlistCheck.Checked ? _playlist.Text?.Trim() : null;
	}
}