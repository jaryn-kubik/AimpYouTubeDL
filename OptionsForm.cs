using System;
using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public partial class OptionsForm : Form
	{
		public OptionsForm()
		{
			InitializeComponent();

			_caption.Text = $"{Plugin.PluginName} v{Plugin.PluginVersion}";
		}

		private void OnOptionsChanged(object sender, EventArgs e)
		{
			OptionsChanged?.Invoke(sender, e);
		}

		private void OnUpdateYouTubeDL(object sender, EventArgs e)
		{
			UpdateYouTubeDL?.Invoke(sender, e);
		}

		public event EventHandler<EventArgs> OptionsChanged;
		public event EventHandler<EventArgs> UpdateYouTubeDL;

		public string Version
		{
			set => _version.Text = $"youtube-dl v{value}";
		}

		public bool OptionAutoUpdate
		{
			get => _optionAutoUpdate.Checked;
			set => _optionAutoUpdate.Checked = value;
		}

		public string OptionFormat
		{
			get => _optionFormat.Text;
			set => _optionFormat.Text = value;
		}
	}
}