using System;
using System.Windows.Forms;

namespace Innovation.Voice.Win.UI
{
    static class Program
    {
        public static MainForm _mainFormInstance;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm();
            _mainFormInstance = mainForm;
            Application.Run(mainForm);
        }
    }
}
