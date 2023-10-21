namespace Video_Encoder__NET_Core_Version_
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            button_Confirm = new System.Windows.Forms.Button();
            tablePanel_Src = new System.Windows.Forms.TableLayoutPanel();
            label_SourceFile = new System.Windows.Forms.Label();
            button_SourceSelect = new System.Windows.Forms.Button();
            textBox_Source = new System.Windows.Forms.TextBox();
            label_Title = new System.Windows.Forms.Label();
            tablePanel_Dest = new System.Windows.Forms.TableLayoutPanel();
            label_Destination = new System.Windows.Forms.Label();
            button_DestinationSelect = new System.Windows.Forms.Button();
            textBox_DestinationFilename = new System.Windows.Forms.TextBox();
            customComboBox_DestinationFolder = new CustomComboBox();
            customComboBox_DestinationExtension = new CustomComboBox();
            tablePanel_Main = new System.Windows.Forms.TableLayoutPanel();
            label_Encoding = new System.Windows.Forms.Label();
            panel_Top = new System.Windows.Forms.Panel();
            button_Close = new System.Windows.Forms.Button();
            button_Minimize = new System.Windows.Forms.Button();
            button_Settings = new System.Windows.Forms.Button();
            tablePanel_Src.SuspendLayout();
            tablePanel_Dest.SuspendLayout();
            tablePanel_Main.SuspendLayout();
            panel_Top.SuspendLayout();
            SuspendLayout();
            // 
            // button_Confirm
            // 
            button_Confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            tablePanel_Main.SetColumnSpan(button_Confirm, 2);
            button_Confirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            button_Confirm.FlatAppearance.BorderSize = 2;
            button_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            button_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Confirm.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_Confirm.ForeColor = System.Drawing.SystemColors.Control;
            button_Confirm.Location = new System.Drawing.Point(378, 302);
            button_Confirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new System.Drawing.Size(160, 67);
            button_Confirm.TabIndex = 6;
            button_Confirm.Text = "Do It!";
            button_Confirm.UseVisualStyleBackColor = true;
            button_Confirm.Click += button_Confirm_Click;
            // 
            // tablePanel_Src
            // 
            tablePanel_Src.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tablePanel_Src.ColumnCount = 2;
            tablePanel_Main.SetColumnSpan(tablePanel_Src, 2);
            tablePanel_Src.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92F));
            tablePanel_Src.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            tablePanel_Src.Controls.Add(label_SourceFile, 0, 0);
            tablePanel_Src.Controls.Add(button_SourceSelect, 1, 1);
            tablePanel_Src.Controls.Add(textBox_Source, 0, 1);
            tablePanel_Src.Location = new System.Drawing.Point(8, 83);
            tablePanel_Src.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tablePanel_Src.Name = "tablePanel_Src";
            tablePanel_Src.RowCount = 2;
            tablePanel_Src.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tablePanel_Src.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tablePanel_Src.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tablePanel_Src.Size = new System.Drawing.Size(900, 66);
            tablePanel_Src.TabIndex = 3;
            // 
            // label_SourceFile
            // 
            label_SourceFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label_SourceFile.AutoSize = true;
            tablePanel_Src.SetColumnSpan(label_SourceFile, 2);
            label_SourceFile.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_SourceFile.ForeColor = System.Drawing.SystemColors.Control;
            label_SourceFile.Location = new System.Drawing.Point(398, 2);
            label_SourceFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
            label_SourceFile.Name = "label_SourceFile";
            label_SourceFile.Size = new System.Drawing.Size(104, 25);
            label_SourceFile.TabIndex = 2;
            label_SourceFile.Text = "Source File:";
            // 
            // button_SourceSelect
            // 
            button_SourceSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            button_SourceSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            button_SourceSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_SourceSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_SourceSelect.ForeColor = System.Drawing.SystemColors.Control;
            button_SourceSelect.Location = new System.Drawing.Point(832, 33);
            button_SourceSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_SourceSelect.Name = "button_SourceSelect";
            button_SourceSelect.Size = new System.Drawing.Size(63, 29);
            button_SourceSelect.TabIndex = 4;
            button_SourceSelect.Text = "•••";
            button_SourceSelect.UseVisualStyleBackColor = true;
            button_SourceSelect.Click += button_SourceSelect_Click;
            // 
            // textBox_Source
            // 
            textBox_Source.AllowDrop = true;
            textBox_Source.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox_Source.BackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            textBox_Source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox_Source.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox_Source.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            textBox_Source.Location = new System.Drawing.Point(4, 33);
            textBox_Source.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_Source.Name = "textBox_Source";
            textBox_Source.PlaceholderText = "Enter directory, select file, or drag file here";
            textBox_Source.Size = new System.Drawing.Size(820, 29);
            textBox_Source.TabIndex = 3;
            textBox_Source.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBox_Source.DragDrop += textBox_Source_DragDrop;
            textBox_Source.DragEnter += textBox_Source_DragEnter;
            // 
            // label_Title
            // 
            label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            label_Title.AutoSize = true;
            tablePanel_Main.SetColumnSpan(label_Title, 2);
            label_Title.Font = new System.Drawing.Font("Segoe UI Semilight", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_Title.ForeColor = System.Drawing.SystemColors.Control;
            label_Title.Location = new System.Drawing.Point(309, 10);
            label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new System.Drawing.Size(297, 59);
            label_Title.TabIndex = 0;
            label_Title.Text = "Video Encoder";
            // 
            // tablePanel_Dest
            // 
            tablePanel_Dest.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tablePanel_Dest.ColumnCount = 4;
            tablePanel_Main.SetColumnSpan(tablePanel_Dest, 2);
            tablePanel_Dest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 439F));
            tablePanel_Dest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            tablePanel_Dest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            tablePanel_Dest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            tablePanel_Dest.Controls.Add(label_Destination, 0, 0);
            tablePanel_Dest.Controls.Add(button_DestinationSelect, 1, 1);
            tablePanel_Dest.Controls.Add(textBox_DestinationFilename, 2, 1);
            tablePanel_Dest.Controls.Add(customComboBox_DestinationFolder, 0, 1);
            tablePanel_Dest.Controls.Add(customComboBox_DestinationExtension, 3, 1);
            tablePanel_Dest.Location = new System.Drawing.Point(8, 173);
            tablePanel_Dest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tablePanel_Dest.Name = "tablePanel_Dest";
            tablePanel_Dest.RowCount = 2;
            tablePanel_Dest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tablePanel_Dest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            tablePanel_Dest.Size = new System.Drawing.Size(900, 67);
            tablePanel_Dest.TabIndex = 4;
            // 
            // label_Destination
            // 
            label_Destination.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label_Destination.AutoSize = true;
            tablePanel_Dest.SetColumnSpan(label_Destination, 5);
            label_Destination.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_Destination.ForeColor = System.Drawing.SystemColors.Control;
            label_Destination.Location = new System.Drawing.Point(398, 2);
            label_Destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
            label_Destination.Name = "label_Destination";
            label_Destination.Size = new System.Drawing.Size(108, 25);
            label_Destination.TabIndex = 2;
            label_Destination.Text = "Destination:";
            // 
            // button_DestinationSelect
            // 
            button_DestinationSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            button_DestinationSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            button_DestinationSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_DestinationSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_DestinationSelect.ForeColor = System.Drawing.SystemColors.Control;
            button_DestinationSelect.Location = new System.Drawing.Point(443, 33);
            button_DestinationSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_DestinationSelect.Name = "button_DestinationSelect";
            button_DestinationSelect.Size = new System.Drawing.Size(64, 29);
            button_DestinationSelect.TabIndex = 4;
            button_DestinationSelect.Text = "•••";
            button_DestinationSelect.UseVisualStyleBackColor = true;
            button_DestinationSelect.Click += button_DestinationSelect_Click;
            // 
            // textBox_DestinationFilename
            // 
            textBox_DestinationFilename.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox_DestinationFilename.BackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            textBox_DestinationFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox_DestinationFilename.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox_DestinationFilename.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            textBox_DestinationFilename.Location = new System.Drawing.Point(515, 33);
            textBox_DestinationFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_DestinationFilename.Name = "textBox_DestinationFilename";
            textBox_DestinationFilename.PlaceholderText = "Enter filename";
            textBox_DestinationFilename.Size = new System.Drawing.Size(265, 29);
            textBox_DestinationFilename.TabIndex = 5;
            textBox_DestinationFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customComboBox_DestinationFolder
            // 
            customComboBox_DestinationFolder.BackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            customComboBox_DestinationFolder.BorderColor = System.Drawing.SystemColors.WindowFrame;
            customComboBox_DestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            customComboBox_DestinationFolder.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            customComboBox_DestinationFolder.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            customComboBox_DestinationFolder.FormattingEnabled = true;
            customComboBox_DestinationFolder.Items.AddRange(new object[] { "" });
            customComboBox_DestinationFolder.Location = new System.Drawing.Point(3, 33);
            customComboBox_DestinationFolder.Name = "customComboBox_DestinationFolder";
            customComboBox_DestinationFolder.PlaceholderText = "Enter directory or select folder";
            customComboBox_DestinationFolder.Size = new System.Drawing.Size(433, 29);
            customComboBox_DestinationFolder.TabIndex = 6;
            customComboBox_DestinationFolder.Text = "                        Enter directory or select folder";
            customComboBox_DestinationFolder.TextAppearance = CustomComboBox.AppearanceTypes.Passive;
            customComboBox_DestinationFolder.Leave += customComboBox_DestinationFolder_Leave;
            // 
            // customComboBox_DestinationExtension
            // 
            customComboBox_DestinationExtension.BackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            customComboBox_DestinationExtension.BorderColor = System.Drawing.SystemColors.WindowFrame;
            customComboBox_DestinationExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            customComboBox_DestinationExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            customComboBox_DestinationExtension.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            customComboBox_DestinationExtension.ForeColor = System.Drawing.SystemColors.Control;
            customComboBox_DestinationExtension.FormattingEnabled = true;
            customComboBox_DestinationExtension.Items.AddRange(new object[] { ".mp4", ".webm", ".avi", ".mov", ".wmv", ".mkv" });
            customComboBox_DestinationExtension.Location = new System.Drawing.Point(787, 33);
            customComboBox_DestinationExtension.Name = "customComboBox_DestinationExtension";
            customComboBox_DestinationExtension.PlaceholderText = "";
            customComboBox_DestinationExtension.Size = new System.Drawing.Size(108, 29);
            customComboBox_DestinationExtension.TabIndex = 6;
            // 
            // tablePanel_Main
            // 
            tablePanel_Main.ColumnCount = 2;
            tablePanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablePanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablePanel_Main.Controls.Add(tablePanel_Dest, 0, 2);
            tablePanel_Main.Controls.Add(label_Title, 0, 0);
            tablePanel_Main.Controls.Add(tablePanel_Src, 0, 1);
            tablePanel_Main.Controls.Add(button_Confirm, 0, 4);
            tablePanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel_Main.Location = new System.Drawing.Point(0, 0);
            tablePanel_Main.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tablePanel_Main.Name = "tablePanel_Main";
            tablePanel_Main.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            tablePanel_Main.RowCount = 5;
            tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            tablePanel_Main.Size = new System.Drawing.Size(916, 378);
            tablePanel_Main.TabIndex = 0;
            // 
            // label_Encoding
            // 
            label_Encoding.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label_Encoding.AutoSize = true;
            label_Encoding.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_Encoding.ForeColor = System.Drawing.Color.Firebrick;
            label_Encoding.Location = new System.Drawing.Point(43, 6);
            label_Encoding.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label_Encoding.Name = "label_Encoding";
            label_Encoding.Size = new System.Drawing.Size(176, 25);
            label_Encoding.TabIndex = 3;
            label_Encoding.Text = "🔴 Ready to encode";
            label_Encoding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Top
            // 
            panel_Top.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
            panel_Top.Controls.Add(tablePanel_Main);
            panel_Top.Location = new System.Drawing.Point(2, 40);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new System.Drawing.Size(916, 378);
            panel_Top.TabIndex = 1;
            // 
            // button_Close
            // 
            button_Close.FlatAppearance.BorderSize = 0;
            button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Close.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button_Close.ForeColor = System.Drawing.SystemColors.Control;
            button_Close.Location = new System.Drawing.Point(880, 0);
            button_Close.Margin = new System.Windows.Forms.Padding(0);
            button_Close.Name = "button_Close";
            button_Close.Size = new System.Drawing.Size(40, 40);
            button_Close.TabIndex = 2;
            button_Close.Text = "╳";
            button_Close.UseVisualStyleBackColor = true;
            button_Close.Click += close_Application;
            // 
            // button_Minimize
            // 
            button_Minimize.FlatAppearance.BorderSize = 0;
            button_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Minimize.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button_Minimize.ForeColor = System.Drawing.SystemColors.Control;
            button_Minimize.Location = new System.Drawing.Point(840, 0);
            button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            button_Minimize.Name = "button_Minimize";
            button_Minimize.Size = new System.Drawing.Size(40, 40);
            button_Minimize.TabIndex = 2;
            button_Minimize.Tag = "Disabled for now";
            button_Minimize.Text = "___";
            button_Minimize.UseVisualStyleBackColor = true;
            button_Minimize.Visible = false;
            button_Minimize.Click += button_Minimize_Click;
            // 
            // button_Settings
            // 
            button_Settings.BackgroundImage = Properties.Resources.gearpng;
            button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button_Settings.FlatAppearance.BorderSize = 0;
            button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Settings.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_Settings.ForeColor = System.Drawing.SystemColors.Control;
            button_Settings.Location = new System.Drawing.Point(0, 0);
            button_Settings.Margin = new System.Windows.Forms.Padding(0);
            button_Settings.Name = "button_Settings";
            button_Settings.Size = new System.Drawing.Size(40, 40);
            button_Settings.TabIndex = 2;
            button_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            button_Settings.UseVisualStyleBackColor = true;
            button_Settings.Click += button_Settings_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            ClientSize = new System.Drawing.Size(920, 420);
            Controls.Add(button_Settings);
            Controls.Add(button_Minimize);
            Controls.Add(button_Close);
            Controls.Add(panel_Top);
            Controls.Add(label_Encoding);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Encoder";
            FormClosing += close_Application;
            MouseDown += MainWindow_MouseDown;
            tablePanel_Src.ResumeLayout(false);
            tablePanel_Src.PerformLayout();
            tablePanel_Dest.ResumeLayout(false);
            tablePanel_Dest.PerformLayout();
            tablePanel_Main.ResumeLayout(false);
            tablePanel_Main.PerformLayout();
            panel_Top.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Src;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Main;
        private System.Windows.Forms.TableLayoutPanel tablePanel_Dest;
        private System.Windows.Forms.Label label_Destination;
        private System.Windows.Forms.Button button_DestinationSelect;
        private System.Windows.Forms.TextBox textBox_DestinationFilename;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_SourceFile;
        private System.Windows.Forms.Button button_SourceSelect;
        private System.Windows.Forms.TextBox textBox_Source;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button button_Close;
        private CustomComboBox customComboBox_DestinationFolder;
        private CustomComboBox customComboBox_DestinationExtension;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Label label_Encoding;
    }
}

