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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._update = new System.Windows.Forms.Button();
			this._version = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _caption
			// 
			this._caption.BackColor = System.Drawing.SystemColors.ControlLight;
			this._caption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._caption.Dock = System.Windows.Forms.DockStyle.Top;
			this._caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._caption.Location = new System.Drawing.Point(0, 0);
			this._caption.Name = "_caption";
			this._caption.Size = new System.Drawing.Size(800, 23);
			this._caption.TabIndex = 0;
			this._caption.Text = "YouTube-DL";
			this._caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _optionAutoUpdate
			// 
			this._optionAutoUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._optionAutoUpdate.AutoSize = true;
			this._optionAutoUpdate.Location = new System.Drawing.Point(227, 26);
			this._optionAutoUpdate.Name = "_optionAutoUpdate";
			this._optionAutoUpdate.Size = new System.Drawing.Size(18, 17);
			this._optionAutoUpdate.TabIndex = 0;
			this._optionAutoUpdate.CheckedChanged += new System.EventHandler(this.OnOptionsChanged);
			// 
			// _optionFormat
			// 
			this._optionFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._optionFormat.Location = new System.Drawing.Point(227, 74);
			this._optionFormat.Name = "_optionFormat";
			this._optionFormat.Size = new System.Drawing.Size(545, 22);
			this._optionFormat.TabIndex = 1;
			this._optionFormat.TextChanged += new System.EventHandler(this.OnOptionsChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this._optionFormat, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this._optionAutoUpdate, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._update, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this._version, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 427);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Update youtube-dl on startup";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "youtube-dl --format";
			// 
			// _update
			// 
			this._update.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._update.AutoSize = true;
			this._update.Location = new System.Drawing.Point(227, 121);
			this._update.Name = "_update";
			this._update.Size = new System.Drawing.Size(75, 27);
			this._update.TabIndex = 5;
			this._update.Text = "Update";
			this._update.UseVisualStyleBackColor = true;
			this._update.Click += new System.EventHandler(this.OnUpdateYouTubeDL);
			// 
			// _version
			// 
			this._version.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._version.AutoSize = true;
			this._version.Location = new System.Drawing.Point(28, 126);
			this._version.Name = "_version";
			this._version.Size = new System.Drawing.Size(75, 17);
			this._version.TabIndex = 7;
			this._version.Text = "youtube-dl";
			// 
			// OptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this._caption);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OptionsForm";
			this.Text = "OptionsForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
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
	}
}