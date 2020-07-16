namespace AIMPYoutubeDL
{
	partial class OptionsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._caption = new System.Windows.Forms.Label();
			this._optionAutoUpdate = new System.Windows.Forms.CheckBox();
			this._optionFormat = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._update = new System.Windows.Forms.Button();
			this._version = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this._authList = new System.Windows.Forms.ListBox();
			this._authRemove = new System.Windows.Forms.Button();
			this._authAdd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._authExtractor = new System.Windows.Forms.ComboBox();
			this._authUserName = new System.Windows.Forms.TextBox();
			this._authPassword = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// _caption
			// 
			this._caption.BackColor = System.Drawing.SystemColors.ControlLight;
			this._caption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._caption.Dock = System.Windows.Forms.DockStyle.Top;
			this._caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._caption.Location = new System.Drawing.Point(0, 0);
			this._caption.Name = "_caption";
			this._caption.Size = new System.Drawing.Size(500, 23);
			this._caption.TabIndex = 0;
			this._caption.Text = "YouTube-DL";
			this._caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _optionAutoUpdate
			// 
			this._optionAutoUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._optionAutoUpdate.AutoSize = true;
			this._optionAutoUpdate.Location = new System.Drawing.Point(216, 10);
			this._optionAutoUpdate.Name = "_optionAutoUpdate";
			this._optionAutoUpdate.Size = new System.Drawing.Size(18, 17);
			this._optionAutoUpdate.TabIndex = 0;
			this._optionAutoUpdate.CheckedChanged += new System.EventHandler(this.OnOptionsChanged);
			// 
			// _optionFormat
			// 
			this._optionFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._optionFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._optionFormat.Location = new System.Drawing.Point(216, 44);
			this._optionFormat.Name = "_optionFormat";
			this._optionFormat.Size = new System.Drawing.Size(281, 22);
			this._optionFormat.TabIndex = 1;
			this._optionFormat.TextChanged += new System.EventHandler(this.OnOptionsChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this._optionFormat, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this._optionAutoUpdate, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._update, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this._version, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 477);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 121);
			this.label3.Margin = new System.Windows.Forms.Padding(10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "youtube-dl authentication";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Update youtube-dl on startup";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 47);
			this.label2.Margin = new System.Windows.Forms.Padding(10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "youtube-dl --format";
			// 
			// _update
			// 
			this._update.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._update.AutoSize = true;
			this._update.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this._update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._update.Location = new System.Drawing.Point(216, 78);
			this._update.Name = "_update";
			this._update.Size = new System.Drawing.Size(75, 29);
			this._update.TabIndex = 5;
			this._update.Text = "Update";
			this._update.UseVisualStyleBackColor = true;
			this._update.Click += new System.EventHandler(this.OnUpdateYouTubeDL);
			// 
			// _version
			// 
			this._version.AutoSize = true;
			this._version.Location = new System.Drawing.Point(10, 84);
			this._version.Margin = new System.Windows.Forms.Padding(10);
			this._version.Name = "_version";
			this._version.Size = new System.Drawing.Size(75, 17);
			this._version.TabIndex = 7;
			this._version.Text = "youtube-dl";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this._authList, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this._authRemove, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this._authAdd, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this._authExtractor, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this._authUserName, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this._authPassword, 1, 4);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(216, 114);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 5;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 294);
			this.tableLayoutPanel2.TabIndex = 9;
			// 
			// _authList
			// 
			this._authList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._authList.Dock = System.Windows.Forms.DockStyle.Fill;
			this._authList.FormattingEnabled = true;
			this._authList.ItemHeight = 16;
			this._authList.Location = new System.Drawing.Point(88, 3);
			this._authList.Name = "_authList";
			this.tableLayoutPanel2.SetRowSpan(this._authList, 2);
			this._authList.Size = new System.Drawing.Size(190, 195);
			this._authList.TabIndex = 0;
			// 
			// _authRemove
			// 
			this._authRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._authRemove.AutoSize = true;
			this._authRemove.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this._authRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._authRemove.Location = new System.Drawing.Point(5, 134);
			this._authRemove.Name = "_authRemove";
			this._authRemove.Size = new System.Drawing.Size(75, 29);
			this._authRemove.TabIndex = 1;
			this._authRemove.Text = "Remove";
			this._authRemove.UseVisualStyleBackColor = true;
			this._authRemove.Click += new System.EventHandler(this.OnAuthRemove);
			// 
			// _authAdd
			// 
			this._authAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._authAdd.AutoSize = true;
			this._authAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this._authAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._authAdd.Location = new System.Drawing.Point(5, 169);
			this._authAdd.Name = "_authAdd";
			this._authAdd.Size = new System.Drawing.Size(75, 29);
			this._authAdd.TabIndex = 2;
			this._authAdd.Text = "Add";
			this._authAdd.UseVisualStyleBackColor = true;
			this._authAdd.Click += new System.EventHandler(this.OnAuthAdd);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 208);
			this.label4.Margin = new System.Windows.Forms.Padding(7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "extractor";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 239);
			this.label5.Margin = new System.Windows.Forms.Padding(7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "username";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 270);
			this.label6.Margin = new System.Windows.Forms.Padding(7);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "password";
			// 
			// _authExtractor
			// 
			this._authExtractor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._authExtractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._authExtractor.FormattingEnabled = true;
			this._authExtractor.Location = new System.Drawing.Point(88, 204);
			this._authExtractor.Name = "_authExtractor";
			this._authExtractor.Size = new System.Drawing.Size(190, 24);
			this._authExtractor.TabIndex = 3;
			// 
			// _authUserName
			// 
			this._authUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._authUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._authUserName.Location = new System.Drawing.Point(88, 236);
			this._authUserName.Name = "_authUserName";
			this._authUserName.Size = new System.Drawing.Size(190, 22);
			this._authUserName.TabIndex = 4;
			// 
			// _authPassword
			// 
			this._authPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._authPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._authPassword.Location = new System.Drawing.Point(88, 267);
			this._authPassword.Name = "_authPassword";
			this._authPassword.Size = new System.Drawing.Size(190, 22);
			this._authPassword.TabIndex = 5;
			this._authPassword.UseSystemPasswordChar = true;
			// 
			// OptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 500);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this._caption);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OptionsForm";
			this.Text = "OptionsForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label _caption;
		private System.Windows.Forms.CheckBox _optionAutoUpdate;
		private System.Windows.Forms.TextBox _optionFormat;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button _update;
		private System.Windows.Forms.Label _version;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ListBox _authList;
		private System.Windows.Forms.TextBox _authUserName;
		private System.Windows.Forms.Button _authRemove;
		private System.Windows.Forms.Button _authAdd;
		private System.Windows.Forms.ComboBox _authExtractor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _authPassword;
	}
}