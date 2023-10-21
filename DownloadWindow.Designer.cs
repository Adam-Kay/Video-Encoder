namespace Video_Encoder__NET_Core_Version_ {
    partial class DownloadWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadWindow));
            this.panel_Top_DownloadPage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.linkLabel_More = new System.Windows.Forms.LinkLabel();
            this.panel_buttonAndPB = new System.Windows.Forms.Panel();
            this.coloredProgressBar_currentTask = new Video_Encoder__NET_Core_Version_.CustomControls.ColoredProgressBar();
            this.label_underBar = new System.Windows.Forms.Label();
            this.coloredProgressBar_totalProgress = new Video_Encoder__NET_Core_Version_.CustomControls.ColoredProgressBar();
            this.button_Download = new System.Windows.Forms.Button();
            this.panel_checkmark = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Top_DownloadPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_buttonAndPB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top_DownloadPage
            // 
            this.panel_Top_DownloadPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Top_DownloadPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel_Top_DownloadPage.Controls.Add(this.tableLayoutPanel1);
            this.panel_Top_DownloadPage.Location = new System.Drawing.Point(2, 40);
            this.panel_Top_DownloadPage.Name = "panel_Top_DownloadPage";
            this.panel_Top_DownloadPage.Size = new System.Drawing.Size(496, 218);
            this.panel_Top_DownloadPage.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Description, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel_More, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_buttonAndPB, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 199);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_Title
            // 
            this.label_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Title.Location = new System.Drawing.Point(3, 6);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(470, 37);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Download FFmpeg";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Description
            // 
            this.label_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Description.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Description.Location = new System.Drawing.Point(3, 51);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(470, 38);
            this.label_Description.TabIndex = 0;
            this.label_Description.Text = "FFmpeg is a free, open-source encoding utlity used by many programs to process au" +
    "dio and video files.";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel_More
            // 
            this.linkLabel_More.ActiveLinkColor = System.Drawing.Color.Violet;
            this.linkLabel_More.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel_More.AutoSize = true;
            this.linkLabel_More.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_More.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_More.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel_More.Location = new System.Drawing.Point(218, 90);
            this.linkLabel_More.Name = "linkLabel_More";
            this.linkLabel_More.Size = new System.Drawing.Size(40, 15);
            this.linkLabel_More.TabIndex = 2;
            this.linkLabel_More.TabStop = true;
            this.linkLabel_More.Text = "More..";
            this.linkLabel_More.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // panel_buttonAndPB
            // 
            this.panel_buttonAndPB.Controls.Add(this.coloredProgressBar_currentTask);
            this.panel_buttonAndPB.Controls.Add(this.label_underBar);
            this.panel_buttonAndPB.Controls.Add(this.coloredProgressBar_totalProgress);
            this.panel_buttonAndPB.Controls.Add(this.button_Download);
            this.panel_buttonAndPB.Controls.Add(this.panel_checkmark);
            this.panel_buttonAndPB.Location = new System.Drawing.Point(3, 113);
            this.panel_buttonAndPB.Name = "panel_buttonAndPB";
            this.panel_buttonAndPB.Size = new System.Drawing.Size(470, 86);
            this.panel_buttonAndPB.TabIndex = 3;
            // 
            // coloredProgressBar_currentTask
            // 
            this.coloredProgressBar_currentTask.BackColor = System.Drawing.Color.Fuchsia;
            this.coloredProgressBar_currentTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.coloredProgressBar_currentTask.Location = new System.Drawing.Point(0, 21);
            this.coloredProgressBar_currentTask.Name = "coloredProgressBar_currentTask";
            this.coloredProgressBar_currentTask.Size = new System.Drawing.Size(470, 10);
            this.coloredProgressBar_currentTask.TabIndex = 10;
            this.coloredProgressBar_currentTask.Visible = false;
            // 
            // label_underBar
            // 
            this.label_underBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_underBar.Font = new System.Drawing.Font("Segoe UI Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_underBar.ForeColor = System.Drawing.SystemColors.Control;
            this.label_underBar.Location = new System.Drawing.Point(0, 73);
            this.label_underBar.Name = "label_underBar";
            this.label_underBar.Size = new System.Drawing.Size(470, 13);
            this.label_underBar.TabIndex = 9;
            this.label_underBar.Text = "This will only have to be downloaded once.";
            this.label_underBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coloredProgressBar_totalProgress
            // 
            this.coloredProgressBar_totalProgress.BackColor = System.Drawing.Color.Fuchsia;
            this.coloredProgressBar_totalProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.coloredProgressBar_totalProgress.Location = new System.Drawing.Point(0, 28);
            this.coloredProgressBar_totalProgress.Name = "coloredProgressBar_totalProgress";
            this.coloredProgressBar_totalProgress.Size = new System.Drawing.Size(470, 23);
            this.coloredProgressBar_totalProgress.TabIndex = 8;
            this.coloredProgressBar_totalProgress.Visible = false;
            // 
            // button_Download
            // 
            this.button_Download.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.button_Download.FlatAppearance.BorderSize = 2;
            this.button_Download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Download.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Download.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Download.Location = new System.Drawing.Point(163, 9);
            this.button_Download.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(136, 54);
            this.button_Download.TabIndex = 7;
            this.button_Download.Text = "Download";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // panel_checkmark
            // 
            this.panel_checkmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_checkmark.BackgroundImage = global::Video_Encoder__NET_Core_Version_.Properties.Resources.check_mark;
            this.panel_checkmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_checkmark.Location = new System.Drawing.Point(215, 32);
            this.panel_checkmark.Name = "panel_checkmark";
            this.panel_checkmark.Size = new System.Drawing.Size(40, 16);
            this.panel_checkmark.TabIndex = 11;
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Close.Location = new System.Drawing.Point(460, 0);
            this.button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(40, 40);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "╳";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // DownloadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(500, 260);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.panel_Top_DownloadPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "DownloadWindow";
            this.Text = "FFmpeg Download";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownloadWindow_MouseDown);
            this.panel_Top_DownloadPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_buttonAndPB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Top_DownloadPage;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.LinkLabel linkLabel_More;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Panel panel_buttonAndPB;
        private CustomControls.ColoredProgressBar coloredProgressBar_totalProgress;
        private System.Windows.Forms.Label label_underBar;
        private CustomControls.ColoredProgressBar coloredProgressBar_currentTask;
        private System.Windows.Forms.Panel panel_checkmark;
    }
}

