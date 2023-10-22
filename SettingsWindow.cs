using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Threading;

namespace Video_Encoder__NET_Core_Version_ {
    public partial class SettingsWindow : Form {
        public SettingsWindow(Form _mainWindow) {
            InitializeComponent();

            /// List of fields that will be saved and loaded from the savefile.
            savedFields.AddRange(new List<Control>
            { textBox_ffmpegLoc, checkBox_CopyDate, checkBox_Shadowplay });

            mainWindow = _mainWindow;

            loadSettings();

            this.ActiveControl = label_Title; /// Set focus to label to draw focus away from buttons
        }

        #region /// Draggable Form /// 

        /// System for making form draggable. SRC: https://stackoverflow.com/a/1592899/8233240 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void SettingsWindow_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        public string settingsLocation = Path.GetDirectoryName
                ($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\VideoEncoder\\");

        public List<Control> savedFields = new();
        private readonly Form mainWindow;


        public void loadSettings() {

            Dictionary<string, string> jsonDict = new();

            try {
                jsonDict = (Dictionary<string, string>) /// Explicit cast as return type of Deserialize() is object
                    JsonSerializer.Deserialize(File.ReadAllText($"{settingsLocation}\\settings.json"), jsonDict.GetType());

                //foreach (KeyValuePair<string, string> p in jsonDict) {
                //    Debug.WriteLine($"Setting: {p.Key}; Value: {p.Value}");
                //    if (bool.TryParse(p.Value, out bool result)) { Debug.WriteLine(result); }
                //}

                foreach (Control c in savedFields) {

                    if (jsonDict.TryGetValue(c.Tag.ToString(), out string settingValue)) {
                        //Debug.WriteLine($"{c.Name}: {settingValue}");

                        /// Conditional expression unsuitable for this function. Will replace with if statement
                        //c.GetType() != typeof(CheckBox) ? c.Text = settingValue : ((CheckBox)c).Checked = bool.Parse(settingValue);

                        /// Clunky if statement
                        //if (c.GetType() == typeof(CheckBox)) {
                        //    ((CheckBox)c).Checked = bool.Parse(settingValue);
                        //} else {
                        //    c.Text = settingValue;
                        //}

                        /// Cleaner if statement; uses 'is' operator and pattern matching
                        if (c is CheckBox cb) { cb.Checked = bool.Parse(settingValue); } else { c.Text = settingValue; }

                    }
                }

                ((MainWindow)mainWindow).ffmpegPath = textBox_ffmpegLoc.Text;
                Debug.WriteLine($"Settings loaded from {settingsLocation}\\settings.json .");

            } catch (Exception e) when (e is FileNotFoundException || e is DirectoryNotFoundException) { /// If file not found
                Debug.WriteLine($"Settings file not found at {settingsLocation}. One will be generated later.");
            } catch (Exception e) { /// Any other error
                Debug.WriteLine($"An error occurred while the settings file was being read. \n {e}");
            }
        }

        private void button_Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_download_ffmpeg_Click(object sender, EventArgs e) {
            using (var downloadwindow = new DownloadWindow()) {
                downloadwindow.StartPosition = FormStartPosition.CenterParent;
                downloadwindow.settingsWindow = this;
                downloadwindow.ShowDialog();
            }
        }

        private void button_Save_Click(object sender, EventArgs e) {

            Dictionary<string, string> jsonDict = new();

            foreach (Control c in savedFields) {
                /// Print out tag text and then the control text, unless it's a checkbox, in which case checked state.
                //Debug.WriteLine($"{c.Tag}: { (c.GetType() != typeof(CheckBox) ? c.Text : ((CheckBox)c).Checked) }");

                jsonDict.Add(c.Tag.ToString(), c.GetType() != typeof(CheckBox) ? c.Text : ((CheckBox)c).Checked.ToString());

            }

            JsonSerializerOptions jsonOptionsPretty = new() { WriteIndented = true };
            string jsonText = JsonSerializer.Serialize(jsonDict, jsonOptionsPretty);
        //Debug.WriteLine(jsonText);

        SaveSettings:
            try {
                File.WriteAllText($"{settingsLocation}\\settings.json", jsonText);
                Debug.WriteLine($"Settings saved to {settingsLocation}\\settings.json .");
                button_Save.Text = "Saved!"; ///TODO: Make sure to change text back after window is closed.
                button_Save.Update();
            } catch (DirectoryNotFoundException) { /// If directory doesn't exist
                try {
                    Debug.WriteLine("Error in saving file; directory non-existent. Attempting creation.");
                    Directory.CreateDirectory(settingsLocation); /// Try to create
                    goto SaveSettings; /// Really shouldn't be using goto, it's a little dirty but it works.
                } catch (Exception exc) { /// If error in creation
                    Debug.WriteLine("Error in creation of directory. \n" + exc.Message);
                }
            } catch (Exception ex) { /// If any other error other than non-existent directory
                Debug.WriteLine($"Other error in saving settings to file. \n" + ex.Message);
            }

            ((MainWindow)mainWindow).ffmpegPath = textBox_ffmpegLoc.Text;

            Thread.Sleep(500); /// Artifical wait of 500ms
            this.Close();
        }

        private void button_select_ffmpegLoc_Click(object sender, EventArgs e) {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "FFmpeg|*.exe";
            openFileDialog.FilterIndex = 0;
            openFileDialog.Title = "Find FFmpeg";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = openFileDialog.FileName;
                textBox_ffmpegLoc.Text = filePath;
            }

        }

        private void SettingsWindow_DragEnter(object sender, DragEventArgs e) {
            ///TODO: Come up with filtering OTF for dragging files in. Use code from Main as reference
        }

        private void SettingsWindow_DragDrop(object sender, DragEventArgs e) {
            ///TODO: Manage extraction of path and putting into textbox
        }
    }
}
