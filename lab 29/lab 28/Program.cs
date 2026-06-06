using System;
using System.Windows.Forms;

namespace lab_29
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UdpChat.Form1());
        }
    }
}