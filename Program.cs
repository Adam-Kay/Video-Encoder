using System;
using System.Windows.Forms;

namespace Video_Encoder__NET_Core_Version_ {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            //OPTIONAL: Process argument(s) for input source
        }
    }
}
