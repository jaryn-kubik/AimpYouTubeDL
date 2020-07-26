using AimpYouTubeDL.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AimpYouTubeDL.Config
{
	public partial class OptionsForm : Form
	{
		public OptionsForm(VisualStyle style)
		{
			InitializeComponent();

			if (style == VisualStyle.Dark)
			{
				BackColor = Color.FromArgb(38, 38, 38);
				ForeColor = Color.WhiteSmoke;
				_caption.BackColor = Color.FromArgb(74, 74, 74);
				_optionFormat.BackColor = _authList.BackColor = _authExtractor.BackColor = _authUserName.BackColor = _authPassword.BackColor = Color.FromArgb(42, 42, 42);
				_optionFormat.ForeColor = _authList.ForeColor = _authExtractor.ForeColor = _authUserName.ForeColor = _authPassword.ForeColor = Color.WhiteSmoke;
				_update.BackColor = _authRemove.BackColor = _authAdd.BackColor = Color.FromArgb(56, 56, 56);
				_update.FlatAppearance.BorderColor = _authRemove.FlatAppearance.BorderColor = _authAdd.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
			}

			_caption.Text = $"{Plugin.Name} v{Plugin.Version}";
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