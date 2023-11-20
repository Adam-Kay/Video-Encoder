using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace Video_Encoder__NET_Core_Version_ {
    public partial class DownloadWindow : Form {
        public DownloadWindow() {
            InitializeComponent();
        }

        #region /// Draggable Form /// 

        /// System for making form draggable. SRC: https://stackoverflow.com/a/1592899/8233240 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void DownloadWindow_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        public SettingsWindow settingsWindow;
        public int currentProgress = -1;

        public string tempPath = Path.GetDirectoryName
            ($"{Path.GetTempPath()}\\FFmpeg\\");

        public string downloadLocation = Path.GetDirectoryName
            ($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\FFmpeg\\");

        private void button_Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_Download_Click(object sender, EventArgs e) {

            button_Download.Visible = false;
            label_underBar.Visible = false;
            coloredProgressBar_totalProgress.Visible = true;
            coloredProgressBar_currentTask.Visible = true;

            using (WebClient client = new()) { //FIX: Migrate to using HttpClient
                client.DownloadProgressChanged += client_DownloadProgressChanged;
                client.DownloadFileCompleted += client_DownloadProgressComplete;
                Debug.WriteLine("Writing data to: " + $"{tempPath}\\FFmpeg.zip.tmp");

                if (!Directory.Exists(tempPath)) { Directory.CreateDirectory(tempPath); }

                client.DownloadFileAsync(new System.Uri(
                    "https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.zip"),
                    $"{tempPath}\\FFmpeg.zip.tmp");

                if (File.Exists($"{tempPath}\\FFmpeg.zip")) { File.Delete($"{tempPath}\\FFmpeg.zip"); }

                //client.DownloadFileCompleted += delegate { File.Move($"{tempPath}\\FFmpeg.zip.tmp", $"{tempPath}\\FFmpeg.zip"); };
            }
        }
        /// Event to track the progress
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs a) {
            coloredProgressBar_currentTask.Value = a.ProgressPercentage;
            coloredProgressBar_totalProgress.Value = (coloredProgressBar_currentTask.Value / 2);

            if (currentProgress != a.ProgressPercentage) {
                currentProgress = a.ProgressPercentage;
                Debug.Write($"\b\b\b\b\b {currentProgress}%\n");
            };
        }

        void client_DownloadProgressComplete(object sender, AsyncCompletedEventArgs a) {

            coloredProgressBar_currentTask.Value = 0;

            try {
                File.Move($"{tempPath}\\FFmpeg.zip.tmp", $"{tempPath}\\FFmpeg.zip");
                ZipFile.ExtractToDirectory($"{tempPath}\\FFmpeg.zip", $"{tempPath}", true);
            } catch (Exception e) {
                DialogResult wingetVerdict = MessageBox.Show(
                    $"There was an error downloading and extracting the file. Please try again or contact the developer. " +
                    $"\n\nMessage:\n{e}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); /// TODO: change buttons (failsafe).

                ///TODO: Add winget ffmpeg failsafe option with confirmation. 

                this.Close();
                return;
            }

            Debug.WriteLine("Extraction Complete");
            coloredProgressBar_totalProgress.Value = 75;
            coloredProgressBar_currentTask.Value = 100;
            coloredProgressBar_currentTask.Refresh();

            Thread.Sleep(250); /// Artificial wait of 250ms
            coloredProgressBar_currentTask.Value = 0;
            Thread.Sleep(250); /// And again

            try {
                Directory.Delete(downloadLocation, true); /// Yeet any existing files in AppData into the sun
                Debug.WriteLine($"Existing files at \"{downloadLocation}\" deleted.");
            } catch (DirectoryNotFoundException) {
                Debug.WriteLine("FFmpeg directory does not exist in AppData, so there was nothing to delete.");
            } catch (Exception e) {
                Debug.WriteLine("An error occurred during the deletion of the FFmpeg directory in AppData.\n" + e.Message);
            }

            string internalFolder = Directory.GetDirectories(tempPath)[0];
            Directory.Move(internalFolder, downloadLocation);
            Debug.WriteLine($"Downloaded files successfully moved to \"{downloadLocation}\"");
            Directory.Delete($"{tempPath}", true);    /// Remove temporary files

            coloredProgressBar_currentTask.Value = 100;
            coloredProgressBar_totalProgress.Value = 100;

            panel_checkmark.BringToFront();
            panel_checkmark.Update();
            label_underBar.Text = "You may now close this dialog.";
            label_underBar.Visible = true;
            label_underBar.Update();

            /// Sets the textbox in SettingWindow to the new FFmpeg path
            settingsWindow.textBox_ffmpegLoc.Text = $"{downloadLocation}\\bin\\ffmpeg.exe";
        }
    }
}
