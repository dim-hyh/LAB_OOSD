using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Dòng ép hệ thống diệt sạch tiến trình ngay khi tắt ứng dụng
            AppDomain.CurrentDomain.ProcessExit += (s, e) => Process.GetCurrentProcess().Kill();

            Application.Run(new FrmMain());
        }
    }
}