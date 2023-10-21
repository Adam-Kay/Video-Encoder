namespace Video_Encoder__NET_Core_Version_ {
    partial class SettingsWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.tablePanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.label_Title = new System.Windows.Forms.Label();
            this.tablePanel_Sub = new System.Windows.Forms.TableLayoutPanel();
            this.label_ffmpegLoc = new System.Windows.Forms.Label();
            this.button_download_ffmpeg = new System.Windows.Forms.Button();
            this.tablePanel_Location = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_ffmpegLoc = new System.Windows.Forms.TextBox();
            this.button_select_ffmpegLoc = new System.Windows.Forms.Button();
            this.label_ffmpegDownload = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_OtherSettings = new System.Windows.Forms.Label();
            this.checkBox_Shadowplay = new System.Windows.Forms.CheckBox();
            this.checkBox_CopyDate = new System.Windows.Forms.CheckBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Top.SuspendLayout();
            this.tablePanel_Main.SuspendLayout();
            this.tablePanel_Sub.SuspendLayout();
            this.tablePanel_Location.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel_Top.Controls.Add(this.tablePanel_Main);
            this.panel_Top.Location = new System.Drawing.Point(2, 40);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(696, 358);
            this.panel_Top.TabIndex = 1;
            // 
            // tablePanel_Main
            // 
            this.tablePanel_Main.ColumnCount = 2;
            this.tablePanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_Main.Controls.Add(this.label_Title, 0, 0);
            this.tablePanel_Main.Controls.Add(this.tablePanel_Sub, 0, 1);
            this.tablePanel_Main.Controls.Add(this.button_Save, 0, 3);
            this.tablePanel_Main.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tablePanel_Main.Location = new System.Drawing.Point(10, 9);
            this.tablePanel_Main.Name = "tablePanel_Main";
            this.tablePanel_Main.RowCount = 4;
            this.tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tablePanel_Main.Size = new System.Drawing.Size(676, 339);
            this.tablePanel_Main.TabIndex = 0;
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Title.AutoSize = true;
            this.tablePanel_Main.SetColumnSpan(this.label_Title, 2);
            this.label_Title.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Title.Location = new System.Drawing.Point(274, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(128, 45);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Settings";
            // 
            // tablePanel_Sub
            // 
            this.tablePanel_Sub.ColumnCount = 1;
            this.tablePanel_Main.SetColumnSpan(this.tablePanel_Sub, 2);
            this.tablePanel_Sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel_Sub.Controls.Add(this.label_ffmpegLoc, 0, 0);
            this.tablePanel_Sub.Controls.Add(this.button_download_ffmpeg, 0, 3);
            this.tablePanel_Sub.Controls.Add(this.tablePanel_Location, 0, 1);
            this.tablePanel_Sub.Controls.Add(this.label_ffmpegDownload, 0, 2);
            this.tablePanel_Sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_Sub.Location = new System.Drawing.Point(3, 48);
            this.tablePanel_Sub.Name = "tablePanel_Sub";
            this.tablePanel_Sub.RowCount = 4;
            this.tablePanel_Sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanel_Sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tablePanel_Sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tablePanel_Sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanel_Sub.Size = new System.Drawing.Size(670, 124);
            this.tablePanel_Sub.TabIndex = 1;
            // 
            // label_ffmpegLoc
            // 
            this.label_ffmpegLoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_ffmpegLoc.AutoSize = true;
            this.label_ffmpegLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_ffmpegLoc.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ffmpegLoc.ForeColor = System.Drawing.SystemColors.Control;
            this.label_ffmpegLoc.Location = new System.Drawing.Point(257, 6);
            this.label_ffmpegLoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.label_ffmpegLoc.Name = "label_ffmpegLoc";
            this.label_ffmpegLoc.Size = new System.Drawing.Size(158, 21);
            this.label_ffmpegLoc.TabIndex = 2;
            this.label_ffmpegLoc.Text = "FFmpeg.exe Location:";
            // 
            // button_download_ffmpeg
            // 
            this.button_download_ffmpeg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_download_ffmpeg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.button_download_ffmpeg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_download_ffmpeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_download_ffmpeg.Font = new System.Drawing.Font("Segoe UI Semilight", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_download_ffmpeg.ForeColor = System.Drawing.SystemColors.Control;
            this.button_download_ffmpeg.Location = new System.Drawing.Point(294, 97);
            this.button_download_ffmpeg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_download_ffmpeg.Name = "button_download_ffmpeg";
            this.button_download_ffmpeg.Size = new System.Drawing.Size(84, 24);
            this.button_download_ffmpeg.TabIndex = 4;
            this.button_download_ffmpeg.Text = "Download";
            this.button_download_ffmpeg.UseVisualStyleBackColor = true;
            this.button_download_ffmpeg.Click += new System.EventHandler(this.button_download_ffmpeg_Click);
            // 
            // tablePanel_Location
            // 
            this.tablePanel_Location.ColumnCount = 2;
            this.tablePanel_Location.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.45427F));
            this.tablePanel_Location.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.545727F));
            this.tablePanel_Location.Controls.Add(this.textBox_ffmpegLoc, 0, 0);
            this.tablePanel_Location.Controls.Add(this.button_select_ffmpegLoc, 1, 0);
            this.tablePanel_Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_Location.Location = new System.Drawing.Point(3, 33);
            this.tablePanel_Location.Name = "tablePanel_Location";
            this.tablePanel_Location.RowCount = 1;
            this.tablePanel_Location.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel_Location.Size = new System.Drawing.Size(667, 34);
            this.tablePanel_Location.TabIndex = 0;
            // 
            // textBox_ffmpegLoc
            // 
            this.textBox_ffmpegLoc.AllowDrop = true;
            this.textBox_ffmpegLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ffmpegLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox_ffmpegLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ffmpegLoc.Font = new System.Drawing.Font("Segoe UI Semilight", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ffmpegLoc.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox_ffmpegLoc.Location = new System.Drawing.Point(3, 3);
            this.textBox_ffmpegLoc.Name = "textBox_ffmpegLoc";
            this.textBox_ffmpegLoc.PlaceholderText = "Enter path, select file, or drag FFmpeg.exe here";
            this.textBox_ffmpegLoc.Size = new System.Drawing.Size(603, 28);
            this.textBox_ffmpegLoc.TabIndex = 0;
            this.textBox_ffmpegLoc.Tag = "FFmpegLocation";
            this.textBox_ffmpegLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_select_ffmpegLoc
            // 
            this.button_select_ffmpegLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_select_ffmpegLoc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.button_select_ffmpegLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_select_ffmpegLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_select_ffmpegLoc.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_select_ffmpegLoc.ForeColor = System.Drawing.SystemColors.Control;
            this.button_select_ffmpegLoc.Location = new System.Drawing.Point(613, 3);
            this.button_select_ffmpegLoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_select_ffmpegLoc.Name = "button_select_ffmpegLoc";
            this.button_select_ffmpegLoc.Size = new System.Drawing.Size(50, 28);
            this.button_select_ffmpegLoc.TabIndex = 4;
            this.button_select_ffmpegLoc.Text = "•••";
            this.button_select_ffmpegLoc.UseVisualStyleBackColor = true;
            this.button_select_ffmpegLoc.Click += new System.EventHandler(this.button_select_ffmpegLoc_Click);
            // 
            // label_ffmpegDownload
            // 
            this.label_ffmpegDownload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_ffmpegDownload.AutoSize = true;
            this.label_ffmpegDownload.Font = new System.Drawing.Font("Segoe UI Semilight", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ffmpegDownload.ForeColor = System.Drawing.SystemColors.Control;
            this.label_ffmpegDownload.Location = new System.Drawing.Point(218, 76);
            this.label_ffmpegDownload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.label_ffmpegDownload.Name = "label_ffmpegDownload";
            this.label_ffmpegDownload.Size = new System.Drawing.Size(237, 15);
            this.label_ffmpegDownload.TabIndex = 2;
            this.label_ffmpegDownload.Text = "Don\'t have FFmpeg or don\'t know what it is?";
            // 
            // button_Save
            // 
            this.button_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablePanel_Main.SetColumnSpan(this.button_Save, 2);
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.button_Save.FlatAppearance.BorderSize = 2;
            this.button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Save.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Save.Location = new System.Drawing.Point(251, 286);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(174, 46);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Save Changes";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tablePanel_Main.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_OtherSettings, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_Shadowplay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_CopyDate, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 178);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 99);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label_OtherSettings
            // 
            this.label_OtherSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_OtherSettings.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_OtherSettings, 9);
            this.label_OtherSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_OtherSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.label_OtherSettings.Location = new System.Drawing.Point(279, 16);
            this.label_OtherSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.label_OtherSettings.Name = "label_OtherSettings";
            this.label_OtherSettings.Size = new System.Drawing.Size(112, 21);
            this.label_OtherSettings.TabIndex = 2;
            this.label_OtherSettings.Text = "Other Settings:";
            // 
            // checkBox_Shadowplay
            // 
            this.checkBox_Shadowplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Shadowplay.AutoSize = true;
            this.checkBox_Shadowplay.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Shadowplay.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_Shadowplay.Location = new System.Drawing.Point(180, 75);
            this.checkBox_Shadowplay.Margin = new System.Windows.Forms.Padding(180, 3, 3, 3);
            this.checkBox_Shadowplay.Name = "checkBox_Shadowplay";
            this.checkBox_Shadowplay.Size = new System.Drawing.Size(357, 19);
            this.checkBox_Shadowplay.TabIndex = 3;
            this.checkBox_Shadowplay.Tag = "ShadowPlayNaming";
            this.checkBox_Shadowplay.Text = "[WIP] Apply custom naming scheme for ShadowPlay recordings";
            this.checkBox_Shadowplay.UseVisualStyleBackColor = true;
            // 
            // checkBox_CopyDate
            // 
            this.checkBox_CopyDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_CopyDate.AutoSize = true;
            this.checkBox_CopyDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_CopyDate.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_CopyDate.Location = new System.Drawing.Point(180, 45);
            this.checkBox_CopyDate.Margin = new System.Windows.Forms.Padding(180, 3, 3, 3);
            this.checkBox_CopyDate.Name = "checkBox_CopyDate";
            this.checkBox_CopyDate.Size = new System.Drawing.Size(387, 19);
            this.checkBox_CopyDate.TabIndex = 3;
            this.checkBox_CopyDate.Tag = "CopyDate";
            this.checkBox_CopyDate.Text = "[WIP] Copy date information from the original file to the encoded file";
            this.checkBox_CopyDate.UseVisualStyleBackColor = true;
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Close.Location = new System.Drawing.Point(660, 0);
            this.button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(40, 40);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "╳";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "SettingsWindow";
            this.Text = "Encoder Settings";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SettingsWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SettingsWindow_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsWindow_MouseDown);
            this.panel_Top.ResumeLayout(false);
            this.tablePanel_Main.ResumeLayout(false);
            this.tablePanel_Main.PerformLayout();
            this.tablePanel_Sub.ResumeLayout(false);
            this.tablePanel_Sub.PerformLayout();
            this.tablePanel_Location.ResumeLayout(false);
            this.tablePanel_Location.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Main;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Sub;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Location;
        private System.Windows.Forms.Button button_select_ffmpegLoc;
        private System.Windows.Forms.Label label_ffmpegLoc;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_ffmpegDownload;
        private System.Windows.Forms.Button button_download_ffmpeg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_OtherSettings;
        private System.Windows.Forms.CheckBox checkBox_CopyDate;
        private System.Windows.Forms.CheckBox checkBox_Shadowplay;
        public System.Windows.Forms.TextBox textBox_ffmpegLoc;
    }
}

