using System;
using System.Windows.Forms;
using ubåtspill.Views;

namespace ubåtspill
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Spill());
        }
    }
}
