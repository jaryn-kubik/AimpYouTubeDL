using AimpYouTubeDL.Api;
using AimpYouTubeDL.Api.Core;
using AimpYouTubeDL.Api.Objects;
using AimpYouTubeDL.Api.Options;
using AimpYouTubeDL.Utils;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AimpYouTubeDL.Config
{
	public class OptionsFrame : IAIMPOptionsDialogFrame
	{
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		private OptionsForm _form;

		public HRESULT GetName(out IAIMPString S)
		{
			S = PluginWrapper.Core.CreateString(Plugin.NameFriendly);
			return HRESULT.S_OK;
		}

		public IntPtr CreateFrame(IntPtr parentWindow)
		{
			_form = new OptionsForm(Helpers.GetVisualStyle());
			_form.OptionsChanged += OnOptionsChanged;
			_form.UpdateYouTubeDL += OnUpdateYouTubeDL;

			SetParent(_form.Handle, parentWindow);
			_form.Show();
			return _form.Handle;
		}

		public void DestroyFrame()
		{
			_form.Close();
			_form = null;
		}

		public void Notification(NotificationOptionsDialog id)
		{
			Helpers.TryCatch(() =>
			{
				if (id == NotificationOptionsDialog.AIMP_SERVICE_OPTIONSDIALOG_NOTIFICATION_SAVE)
				{
					Plugin.Options.AutoUpdate = _form.OptionAutoUpdate;
					Plugin.Options.Format = _form.OptionFormat;
					Plugin.Options.Auths = new List<OptionsAuth>(_form.OptionAuths);
					Plugin.Options.Auths.Sort((x, y) => x.Extractor.CompareTo(y.Extractor));
					Plugin.Options.Save();
					Plugin.YouTube.Clear();
				}
				if (id == NotificationOptionsDialog.AIMP_SERVICE_OPTIONSDIALOG_NOTIFICATION_LOAD)
				{
					_form.OptionAutoUpdate = Plugin.Options.AutoUpdate;
					_form.OptionFormat = Plugin.Options.Format;
					_form.Version = Plugin.YouTube.Version;
					_form.OptionAuths = new List<OptionsAuth>(Plugin.Options.Auths);
					_form.Extractors = Plugin.YouTube.GetExtractors();
				}
			});
		}

		private void OnOptionsChanged(object sender, EventArgs e)
		{
			PluginWrapper.Core.GetService<IAIMPServiceOptionsDialog>().FrameModified(this).EnsureSuccess();
		}

		private void OnUpdateYouTubeDL(object sender, EventArgs e)
		{
			Helpers.TryCatch(() =>
			{
				(var prev, var current) = Plugin.YouTube.Update();
				_form.Version = current;
				if (prev == current)
				{
					MessageBox.Show($"You already have the latest version '{current}'.");
				}
				else
				{
					MessageBox.Show($"Updated from version '{prev}' to '{current}'.\nRestart AIMP to see any effects!");
				}
			});
		}
	}
}