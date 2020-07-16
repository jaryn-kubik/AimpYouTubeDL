﻿using AIMP.SDK.Options;
using AIMP.SDK.Player;
using AimpYouTubeDL.Config;
using AimpYouTubeDL.Utils;
using AimpYouTubeDL.YouTube;
using System;
using System.Collections.Generic;
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
			_form = new OptionsForm(Utils.GetVisualStyle(_player));
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
			Utils.TryCatch(() =>
			{
				if (id == OptionsDialogFrameNotificationType.AIMP_SERVICE_OPTIONSDIALOG_NOTIFICATION_SAVE)
				{
					_options.AutoUpdate = _form.OptionAutoUpdate;
					_options.Format = _form.OptionFormat;
					_options.Auths = new List<OptionsAuth>(_form.OptionAuths);
					_options.Auths.Sort((x, y) => x.Extractor.CompareTo(y.Extractor));
					_options.Save();
					_ytb.Clear();
				}
				if (id == OptionsDialogFrameNotificationType.AIMP_SERVICE_OPTIONSDIALOG_NOTIFICATION_LOAD)
				{
					_form.OptionAutoUpdate = _options.AutoUpdate;
					_form.OptionFormat = _options.Format;
					_form.Version = _ytb.Version;
					_form.OptionAuths = new List<OptionsAuth>(_options.Auths);
					_form.Extractors = _ytb.GetExtractors();
				}
			});
		}

		private void OnOptionsChanged(object sender, EventArgs e)
		{
			_player.ServiceOptionsDialog.FrameModified(this);
		}

		private void OnUpdateYouTubeDL(object sender, EventArgs e)
		{
			Utils.TryCatch(() =>
			{
				(var prev, var current) = _ytb.Update();
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