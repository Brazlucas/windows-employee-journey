using System;
using System.Windows.Forms;

namespace e_journey_windows
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.MainForm());
        }
    }
}