using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace Video_Encoder__NET_Core_Version_ {

    public partial class MainWindow : Form {    ///TODO: Change form layout so it's suitable for batch file processing. 
        public MainWindow() {
            InitializeComponent();

            /// Reduces flicker on drawn controls (https://stackoverflow.com/a/64507)
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            this.ActiveControl = label_Title; /// Set focus to label to draw focus away from buttons
            customComboBox_DestinationExtension.SelectedIndex = 0;
            //customComboBox_DestinationFolder.BorderColor = SystemColors.GrayText;
            //button_Settings.BackgroundImage = Resources.gearpng;
            button_Settings.Text = "";

            /// Refresh text rendering inside cCB, now that the form is rendered at the correct size.
            /// This is necessary for the time being and I'm unsure how to code it out.
            customComboBox_DestinationFolder.CalculatePlaceholderText(null, EventArgs.Empty);

            settingswindow = new(this);
        }

        readonly string[] supportedSourceFormats = { ".mp4", ".webm", ".avi", ".mov", ".wmv", ".mkv" };

        public string ffmpegPath = "";

        private Process ffmpegProcess;

        SettingsWindow settingswindow;

        #region /// Draggable Form ///

        /// System for making form draggable. SRC: https://stackoverflow.com/a/1592899/8233240 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public void MainWindow_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void parse_TextBoxSource_for_DestinationComboBox() {

            string fileFolderDirectory = Path.GetDirectoryName(textBox_Source.Text);

            if (!string.IsNullOrWhiteSpace(fileFolderDirectory)) {
                Console.WriteLine("Directory is not null. Directory: " + fileFolderDirectory);
                if (customComboBox_DestinationFolder.Items.Count == 2) {
                    customComboBox_DestinationFolder.Items[1] = fileFolderDirectory;
                } else {
                    customComboBox_DestinationFolder.Items.Add(fileFolderDirectory);
                }
            } else {
                Console.WriteLine("Source path is invalid. No item has been added to Destination Folder ComboBox.");
                if (customComboBox_DestinationFolder.Items.Count == 2) {
                    customComboBox_DestinationFolder.Items.RemoveAt(1);

                }
            }
        }

        /// <summary>Parses a line of FFmpeg output into a <c>Dictionary</c> of values.</summary>
        private static bool tryParseFFmpegOutput(string line, out Dictionary<string, dynamic> valueDict, bool writeDebugErrors = false) {
            valueDict = new();

            try {
                /// Makes sure that there are no whitespace entries from splitting multiple spaces
                string[] splitvalues = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < splitvalues.Length; i++) {
                    if (splitvalues[i].EndsWith('=')) {
                        valueDict[splitvalues[i].Replace("=", "")] = splitvalues[i + 1]; /// Adds value to dict and removes "=" from key
                        i += 1;
                    } else if (splitvalues[i].Contains("=")) {
                        string[] doublesplitvalues = splitvalues[i].Split('=');
                        valueDict[doublesplitvalues[0]] = doublesplitvalues[1];
                    } else {
                        if (writeDebugErrors) { Debug.WriteLine($"{nameof(tryParseFFmpegOutput)}: Argument input invalid."); }
                        return false;
                    }
                }
                return true;

            } catch (Exception ex) {
                if (writeDebugErrors) { Debug.WriteLine($"{nameof(tryParseFFmpegOutput)}: {ex.Message}"); }
                return false;
            }
        }

        private void button_SourceSelect_Click(object sender, EventArgs e) { /// Support multiple files
            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Media Files (.mp4, .webm, .avi, .mov, .wmv, .mkv)|*.MP4; *.WEBM; *.AVI; *.MOV; *.WMV; *.MKV";
            openFileDialog.FilterIndex = 0;
            openFileDialog.Title = "Open Source File";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = openFileDialog.FileName;
                textBox_Source.Text = filePath;
            }
            parse_TextBoxSource_for_DestinationComboBox();
        }

        private void textBox_Source_DragEnter(object sender, DragEventArgs e) { ///TODO: Support multiple files
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string filepath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                string extension = System.IO.Path.GetExtension(filepath).ToLower();
                //Debug.WriteLine(filepath);
                //Debug.WriteLine(System.IO.Path.GetExtension(filepath));
                var matchingValue = supportedSourceFormats
                    .FirstOrDefault(check => check.Contains(extension));

                /// Original if statement
                //if (matchingValue != null) {
                //    e.Effect = DragDropEffects.Link;
                //} else {
                //    e.Effect = DragDropEffects.None;
                //}

                /// One-line condensed if statement
                //if (matchingValue != null) { e.Effect = DragDropEffects.Link; } else { e.Effect = DragDropEffects.None; }

                /// Conditional expression
                e.Effect = (matchingValue != null) ? DragDropEffects.Link : DragDropEffects.None;
            }
        }

        private void textBox_Source_DragDrop(object sender, DragEventArgs e) {
            string filepath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            textBox_Source.Text = filepath;
            parse_TextBoxSource_for_DestinationComboBox();
        }

        private void customComboBox_DestinationFolder_Leave(object sender, EventArgs e) {
            if (Directory.Exists(customComboBox_DestinationFolder.Text)) {
                if (customComboBox_DestinationFolder.Text.Last() != '\\') {
                    customComboBox_DestinationFolder.Text += "\\";
                }
            }
        }

        private void button_DestinationSelect_Click(object sender, EventArgs e) {
            using CommonOpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.DefaultFileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.IsFolderPicker = true;
            openFileDialog.Title = "Select Destination Folder";
            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(openFileDialog.FileName)) {
                customComboBox_DestinationFolder.Text = openFileDialog.FileName + "\\";
                customComboBox_DestinationFolder.TextAppearance = CustomComboBox.AppearanceTypes.Active;
            }
        }

        ///TODO: Figure out a naming scheme for output files.

        private void button_Confirm_Click(object sender, EventArgs e) { ///async?

            string destinationFullPath = $"{customComboBox_DestinationFolder.Text}" +
                                         $"{textBox_DestinationFilename.Text}" +
                                         $"{customComboBox_DestinationExtension.SelectedItem}";

            if (!File.Exists(textBox_Source.Text)) {
                /// TODO: Continue idiotproofing
                /// TODO: Be nice for once
                MessageBox.Show("You idiot. That doesn't exist now, does it?", "Dipshit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (File.Exists(destinationFullPath)) { /// If destination file already exists
                if (textBox_Source.Text == destinationFullPath) { /// If filepaths are the same
                    Debug.WriteLine("Destination file cannot be the same as source file.");
                    MessageBox.Show("The destination file cannot be the same as the source file.", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else {
                    Debug.WriteLine($"File already exists at \"{destinationFullPath}\""); /// TODO: Detect and handle overwrite
                }
            }

            ffmpegProcess = new() {
                StartInfo = new ProcessStartInfo {
                    FileName = $"{ffmpegPath}",
                    Arguments = $"-i \"{textBox_Source.Text}\" \"{destinationFullPath}\"",
                    WindowStyle = ProcessWindowStyle.Normal,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                }
            };

            /// Create copy without reference to original
            Label label_Encoding_or = new() { ForeColor = label_Encoding.ForeColor, Text = label_Encoding.Text };
            label_Encoding.ForeColor = Color.Orange;
            label_Encoding.Text = "🔴 Encoding...";
            label_Encoding.Update();
            string sourceFileLength;

            using (ShellObject shell = ShellObject.FromParsingName(textBox_Source.Text)) {
                sourceFileLength = shell.Properties.System.Media.Duration.FormatForDisplay(PropertyDescriptionFormatOptions.None);
            }

            try {
                this.UseWaitCursor = true;
                ffmpegProcess.Start();

                while (!ffmpegProcess.StandardError.EndOfStream) {
                    string line = ffmpegProcess.StandardError.ReadLine();
                    //string outlogTest = "frame=  173 fps=167 q=29.0 size=     768kB time=00:00:06.01 bitrate=1045.9kbits/s speed=5.82x";

                    if (tryParseFFmpegOutput(line, out var ffmpegDict)) { ///If the output is encoding progress data
                        foreach (string s in ffmpegDict.Keys) {
                            Debug.Write($"  {s}:{ffmpegDict[s]}");
                            if (s == "time") { Debug.Write($"/{sourceFileLength}.00"); }
                        }
                        Debug.WriteLine("");
                    }
                }

                ffmpegProcess.WaitForExit();
            } catch (Exception ex) {
                MessageBox.Show($"An error occurred during the encoding process: \n\n{ex.Message}\n{ex.StackTrace}", "Error in encoding.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label_Encoding.ForeColor = label_Encoding_or.ForeColor;
            label_Encoding.Text = label_Encoding_or.Text;
            label_Encoding.Update();
            this.UseWaitCursor = false; /// Have to have it here because if .Start() throws an error the cursor will never be reset

        }

        private void close_Application(object sender, EventArgs e) {
            // GET DONE: Figure out a way to terminate the ffmpeg process because currently after closing the app it continues encoding

            if (ffmpegProcess is not null) {
                ffmpegProcess.Close();
                //ffmpegProcess.WaitForExit();
            }

            Application.Exit();
        }

        private void button_Minimize_Click(object sender, EventArgs e) { /// Button disabled for now
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Settings_Click(object sender, EventArgs e) {
            settingswindow.StartPosition = FormStartPosition.CenterParent;
            settingswindow.ShowInTaskbar = false;
            settingswindow.ShowDialog();
        }

        private void button_Test_Click(object sender, EventArgs e) {
            Debug.WriteLine("Begin Test!");
            //int testnum = await TestAsync(5); //GET DONE: Try again.
        }

        private static async Task<int> TestAsync(int loops) {
            int numb = 2;
            for (int i = 0; i < loops; i++) {
                numb = numb * loops;
                Debug.WriteLine(numb);
            }
            return numb;
        }
    }
}