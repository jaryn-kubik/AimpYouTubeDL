using AIMP.SDK.Options;
using AIMP.SDK.Player;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AIMPYoutubeDL
{
	public class OptionsFrame : IAimpOptionsDialogFrame, IDisposable
	{
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		private readonly IAimpPlayer _player;
		private readonly YouTubeDL _ytb;
		private readonly Options _options;
		private OptionsForm _form;

		public OptionsFrame(IAimpPlayer player, YouTubeDL ytb, Options options)
		{
			_player = player;
			_ytb = ytb;
			_options = options;

			_player.Core.RegisterExtension(this);
		}

		public void Dispose()
		{
			_player.Core.UnregisterExtension(this);
		}

		public string GetName()
		{
			return Plugin.PluginName;
		}

		public IntPtr CreateFrame(IntPtr parentWindow)
		{
			_form = new OptionsForm();
			_form.OptionsChanged += OnOptionsChanged;
			_form.UpdateYouTubeDL += OnUpdateYouTubeDL;

			SetParent(_form.Handle, parentWindow);
			_form.Show();
			return _form.Handle;
		}

		public void DestroyFrame()
		{
			_form.Hide();
			_form = null;
		}

		public void Notification(OptionsDialogFrameNotificationType id)
		{
			if (id == OptionsDialogFrameNotificationType.AIMP_SERVICE_OPTIONSDIALOG_NOTIFICATION_SAVE)
			{
				_options.AutoUpdate = _form.OptionAutoUpdate;
				_options.Format = _form.OptionFormat;
			}
			if (id == OptionsDialogFrameNotificationType.AIMP_SERVICE_OPTIONSDIALOG_NOTIFICATION_LOAD)
			{
				_form.OptionAutoUpdate = _options.AutoUpdate;
				_form.OptionFormat = _options.Format;
				_form.Version = _ytb.Version;
			}
		}

		private void OnOptionsChanged(object sender, EventArgs e)
		{
			_player.ServiceOptionsDialog.FrameModified(this);
		}

		private void OnUpdateYouTubeDL(object sender, EventArgs e)
		{
			Utils.HandleException(() =>
			{
				(var prev, var current) = _ytb.Update();
				_form.Version = current;
				MessageBox.Show($"Updated from version '{prev}' to '{current}'.\nRestart AIMP to see any effects!");
			});
		}
	}
}