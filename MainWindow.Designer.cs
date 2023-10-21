namespace Video_Encoder__NET_Core_Version_ {
    partial class MainWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button_Confirm = new System.Windows.Forms.Button();
            this.tablePanel_Src = new System.Windows.Forms.TableLayoutPanel();
            this.label_SourceFile = new System.Windows.Forms.Label();
            this.button_SourceSelect = new System.Windows.Forms.Button();
            this.textBox_Source = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.tablePanel_Dest = new System.Windows.Forms.TableLayoutPanel();
            this.label_Destination = new System.Windows.Forms.Label();
            this.button_DestinationSelect = new System.Windows.Forms.Button();
            this.textBox_DestinationFilename = new System.Windows.Forms.TextBox();
            this.customComboBox_DestinationFolder = new Video_Encoder__NET_Core_Version_.CustomComboBox();
            this.customComboBox_DestinationExtension = new Video_Encoder__NET_Core_Version_.CustomComboBox();
            this.tablePanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.label_Encoding = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.tablePanel_Src.SuspendLayout();
            this.tablePanel_Dest.SuspendLayout();
            this.tablePanel_Main.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Confirm
            // 
            this.button_Confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablePanel_Main.SetColumnSpan(this.button_Confirm, 2);
            this.button_Confirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.button_Confirm.FlatAppearance.BorderSize = 2;
            this.button_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Confirm.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Confirm.Location = new System.Drawing.Point(378, 302);
            this.button_Confirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(160, 67);
            this.button_Confirm.TabIndex = 6;
            this.button_Confirm.Text = "Do It!";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // tablePanel_Src
            // 
            this.tablePanel_Src.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel_Src.ColumnCount = 2;
            this.tablePanel_Main.SetColumnSpan(this.tablePanel_Src, 2);
            this.tablePanel_Src.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tablePanel_Src.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tablePanel_Src.Controls.Add(this.label_SourceFile, 0, 0);
            this.tablePanel_Src.Controls.Add(this.button_SourceSelect, 1, 1);
            this.tablePanel_Src.Controls.Add(this.textBox_Source, 0, 1);
            this.tablePanel_Src.Location = new System.Drawing.Point(8, 83);
            this.tablePanel_Src.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablePanel_Src.Name = "tablePanel_Src";
            this.tablePanel_Src.RowCount = 2;
            this.tablePanel_Src.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanel_Src.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel_Src.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel_Src.Size = new System.Drawing.Size(900, 66);
            this.tablePanel_Src.TabIndex = 3;
            // 
            // label_SourceFile
            // 
            this.label_SourceFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_SourceFile.AutoSize = true;
            this.tablePanel_Src.SetColumnSpan(this.label_SourceFile, 2);
            this.label_SourceFile.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SourceFile.ForeColor = System.Drawing.SystemColors.Control;
            this.label_SourceFile.Location = new System.Drawing.Point(398, 2);
            this.label_SourceFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.label_SourceFile.Name = "label_SourceFile";
            this.label_SourceFile.Size = new System.Drawing.Size(104, 25);
            this.label_SourceFile.TabIndex = 2;
            this.label_SourceFile.Text = "Source File:";
            // 
            // button_SourceSelect
            // 
            this.button_SourceSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.button_SourceSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_SourceSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SourceSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_SourceSelect.ForeColor = System.Drawing.SystemColors.Control;
            this.button_SourceSelect.Location = new System.Drawing.Point(832, 33);
            this.button_SourceSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_SourceSelect.Name = "button_SourceSelect";
            this.button_SourceSelect.Size = new System.Drawing.Size(63, 29);
            this.button_SourceSelect.TabIndex = 4;
            this.button_SourceSelect.Text = "•••";
            this.button_SourceSelect.UseVisualStyleBackColor = true;
            this.button_SourceSelect.Click += new System.EventHandler(this.button_SourceSelect_Click);
            // 
            // textBox_Source
            // 
            this.textBox_Source.AllowDrop = true;
            this.textBox_Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox_Source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Source.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Source.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.textBox_Source.Location = new System.Drawing.Point(4, 33);
            this.textBox_Source.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Source.Name = "textBox_Source";
            this.textBox_Source.PlaceholderText = "Enter directory, select file, or drag file here";
            this.textBox_Source.Size = new System.Drawing.Size(820, 29);
            this.textBox_Source.TabIndex = 3;
            this.textBox_Source.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Source.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_Source_DragDrop);
            this.textBox_Source.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_Source_DragEnter);
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.AutoSize = true;
            this.tablePanel_Main.SetColumnSpan(this.label_Title, 2);
            this.label_Title.Font = new System.Drawing.Font("Segoe UI Semilight", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Title.Location = new System.Drawing.Point(309, 10);
            this.label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(297, 59);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Video Encoder";
            // 
            // tablePanel_Dest
            // 
            this.tablePanel_Dest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel_Dest.ColumnCount = 4;
            this.tablePanel_Main.SetColumnSpan(this.tablePanel_Dest, 2);
            this.tablePanel_Dest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 439F));
            this.tablePanel_Dest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tablePanel_Dest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tablePanel_Dest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tablePanel_Dest.Controls.Add(this.label_Destination, 0, 0);
            this.tablePanel_Dest.Controls.Add(this.button_DestinationSelect, 1, 1);
            this.tablePanel_Dest.Controls.Add(this.textBox_DestinationFilename, 2, 1);
            this.tablePanel_Dest.Controls.Add(this.customComboBox_DestinationFolder, 0, 1);
            this.tablePanel_Dest.Controls.Add(this.customComboBox_DestinationExtension, 3, 1);
            this.tablePanel_Dest.Location = new System.Drawing.Point(8, 173);
            this.tablePanel_Dest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablePanel_Dest.Name = "tablePanel_Dest";
            this.tablePanel_Dest.RowCount = 2;
            this.tablePanel_Dest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanel_Dest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tablePanel_Dest.Size = new System.Drawing.Size(900, 67);
            this.tablePanel_Dest.TabIndex = 4;
            // 
            // label_Destination
            // 
            this.label_Destination.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Destination.AutoSize = true;
            this.tablePanel_Dest.SetColumnSpan(this.label_Destination, 5);
            this.label_Destination.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Destination.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Destination.Location = new System.Drawing.Point(398, 2);
            this.label_Destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.label_Destination.Name = "label_Destination";
            this.label_Destination.Size = new System.Drawing.Size(108, 25);
            this.label_Destination.TabIndex = 2;
            this.label_Destination.Text = "Destination:";
            // 
            // button_DestinationSelect
            // 
            this.button_DestinationSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.button_DestinationSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_DestinationSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DestinationSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_DestinationSelect.ForeColor = System.Drawing.SystemColors.Control;
            this.button_DestinationSelect.Location = new System.Drawing.Point(443, 33);
            this.button_DestinationSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_DestinationSelect.Name = "button_DestinationSelect";
            this.button_DestinationSelect.Size = new System.Drawing.Size(64, 29);
            this.button_DestinationSelect.TabIndex = 4;
            this.button_DestinationSelect.Text = "•••";
            this.button_DestinationSelect.UseVisualStyleBackColor = true;
            this.button_DestinationSelect.Click += new System.EventHandler(this.button_DestinationSelect_Click);
            // 
            // textBox_DestinationFilename
            // 
            this.textBox_DestinationFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_DestinationFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.textBox_DestinationFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_DestinationFilename.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_DestinationFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.textBox_DestinationFilename.Location = new System.Drawing.Point(515, 33);
            this.textBox_DestinationFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_DestinationFilename.Name = "textBox_DestinationFilename";
            this.textBox_DestinationFilename.PlaceholderText = "Enter filename";
            this.textBox_DestinationFilename.Size = new System.Drawing.Size(265, 29);
            this.textBox_DestinationFilename.TabIndex = 5;
            this.textBox_DestinationFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customComboBox_DestinationFolder
            // 
            this.customComboBox_DestinationFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.customComboBox_DestinationFolder.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.customComboBox_DestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customComboBox_DestinationFolder.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customComboBox_DestinationFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.customComboBox_DestinationFolder.FormattingEnabled = true;
            this.customComboBox_DestinationFolder.Items.AddRange(new object[] {
            ""});
            this.customComboBox_DestinationFolder.Location = new System.Drawing.Point(3, 33);
            this.customComboBox_DestinationFolder.Name = "customComboBox_DestinationFolder";
            this.customComboBox_DestinationFolder.PlaceholderText = "Enter directory or select folder";
            this.customComboBox_DestinationFolder.Size = new System.Drawing.Size(433, 29);
            this.customComboBox_DestinationFolder.TabIndex = 6;
            this.customComboBox_DestinationFolder.Text = "                        Enter directory or select folder";
            this.customComboBox_DestinationFolder.TextAppearance = Video_Encoder__NET_Core_Version_.CustomComboBox.AppearanceTypes.Passive;
            this.customComboBox_DestinationFolder.Leave += new System.EventHandler(this.customComboBox_DestinationFolder_Leave);
            // 
            // customComboBox_DestinationExtension
            // 
            this.customComboBox_DestinationExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.customComboBox_DestinationExtension.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.customComboBox_DestinationExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customComboBox_DestinationExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customComboBox_DestinationExtension.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customComboBox_DestinationExtension.ForeColor = System.Drawing.SystemColors.Control;
            this.customComboBox_DestinationExtension.FormattingEnabled = true;
            this.customComboBox_DestinationExtension.Items.AddRange(new object[] {
            ".mp4",
            ".webm",
            ".avi",
            ".mov",
            ".wmv",
            ".mkv"});
            this.customComboBox_DestinationExtension.Location = new System.Drawing.Point(787, 33);
            this.customComboBox_DestinationExtension.Name = "customComboBox_DestinationExtension";
            this.customComboBox_DestinationExtension.PlaceholderText = "";
            this.customComboBox_DestinationExtension.Size = new System.Drawing.Size(108, 29);
            this.customComboBox_DestinationExtension.TabIndex = 6;
            // 
            // tablePanel_Main
            // 
            this.tablePanel_Main.ColumnCount = 2;
            this.tablePanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.05286F));
            this.tablePanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.94714F));
            this.tablePanel_Main.Controls.Add(this.tablePanel_Dest, 0, 2);
            this.tablePanel_Main.Controls.Add(this.label_Title, 0, 0);
            this.tablePanel_Main.Controls.Add(this.tablePanel_Src, 0, 1);
            this.tablePanel_Main.Controls.Add(this.button_Confirm, 0, 4);
            this.tablePanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tablePanel_Main.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablePanel_Main.Name = "tablePanel_Main";
            this.tablePanel_Main.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.tablePanel_Main.RowCount = 5;
            this.tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tablePanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel_Main.Size = new System.Drawing.Size(916, 378);
            this.tablePanel_Main.TabIndex = 0;
            // 
            // label_Encoding
            // 
            this.label_Encoding.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Encoding.AutoSize = true;
            this.label_Encoding.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Encoding.ForeColor = System.Drawing.Color.Firebrick;
            this.label_Encoding.Location = new System.Drawing.Point(43, 6);
            this.label_Encoding.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label_Encoding.Name = "label_Encoding";
            this.label_Encoding.Size = new System.Drawing.Size(176, 25);
            this.label_Encoding.TabIndex = 3;
            this.label_Encoding.Text = "🔴 Ready to encode";
            this.label_Encoding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel_Top.Controls.Add(this.tablePanel_Main);
            this.panel_Top.Location = new System.Drawing.Point(2, 40);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(916, 378);
            this.panel_Top.TabIndex = 1;
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Close.Location = new System.Drawing.Point(880, 0);
            this.button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(40, 40);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "╳";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.close_Application);
            // 
            // button_Minimize
            // 
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Minimize.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Minimize.Location = new System.Drawing.Point(840, 0);
            this.button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(40, 40);
            this.button_Minimize.TabIndex = 2;
            this.button_Minimize.Tag = "Disabled for now";
            this.button_Minimize.Text = "___";
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Visible = false;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // button_Settings
            // 
            this.button_Settings.BackgroundImage = global::Video_Encoder__NET_Core_Version_.Properties.Resources.gearpng;
            this.button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Settings.FlatAppearance.BorderSize = 0;
            this.button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Settings.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Settings.Location = new System.Drawing.Point(0, 0);
            this.button_Settings.Margin = new System.Windows.Forms.Padding(0);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(40, 40);
            this.button_Settings.TabIndex = 2;
            this.button_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(920, 420);
            this.Controls.Add(this.button_Settings);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.label_Encoding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Encoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.close_Application);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.tablePanel_Src.ResumeLayout(false);
            this.tablePanel_Src.PerformLayout();
            this.tablePanel_Dest.ResumeLayout(false);
            this.tablePanel_Dest.PerformLayout();
            this.tablePanel_Main.ResumeLayout(false);
            this.tablePanel_Main.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

