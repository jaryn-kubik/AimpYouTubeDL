using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public partial class OptionsForm : Form
	{
		public OptionsForm()
		{
			InitializeComponent();

			_caption.Text = $"{Plugin.PluginName} v{Plugin.PluginVersion}";
			_authList.DisplayMember = nameof(OptionsAuth.Extractor);
		}

		private void OnOptionsChanged(object sender, EventArgs e)
		{
			OptionsChanged?.Invoke(sender, e);
		}

		private void OnUpdateYouTubeDL(object sender, EventArgs e)
		{
			UpdateYouTubeDL?.Invoke(sender, e);
		}

		private void OnAuthRemove(object sender, EventArgs e)
		{
			var item = _authList.SelectedItem as OptionsAuth;
			if (OptionAuths.Remove(item))
			{
				OptionsChanged?.Invoke(sender, e);
			}
		}

		private void OnAuthAdd(object sender, EventArgs e)
		{
			var item = new OptionsAuth
			{
				Extractor = _authExtractor.SelectedItem as string,
				UserName = _authUserName.Text,
				Password = _authPassword.Text
			};
			if (!string.IsNullOrWhiteSpace(item.Extractor)
				&& !string.IsNullOrWhiteSpace(item.UserName)
				&& !string.IsNullOrWhiteSpace(item.Password)
				&& !OptionAuths.Any(x => x.Extractor == item.Extractor))
			{
				OptionAuths.Add(item);
				OptionsChanged?.Invoke(sender, e);

				_authExtractor.SelectedIndex = 0;
				_authUserName.Clear();
				_authPassword.Clear();
			}
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

		public IList<OptionsAuth> OptionAuths
		{
			get => _authList.DataSource as IList<OptionsAuth>;
			set => _authList.DataSource = new BindingList<OptionsAuth>(value);
		}

		public IEnumerable<string> Extractors
		{
			set => _authExtractor.DataSource = value;
		}
	}
}