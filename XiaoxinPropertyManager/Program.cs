using System;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;
using XiaoxinPropertyManager.Forms;
using XiaoxinPropertyManager.Pages;

namespace XiaoxinPropertyManager
{
    internal static class Program
    {
        // 程序从这里开始跑
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 没处理的异常，弹个提示
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += delegate(object s, System.Threading.ThreadExceptionEventArgs e)
            {
                ShowFatal(e.Exception);
            };
            AppDomain.CurrentDomain.UnhandledException += delegate(object s, UnhandledExceptionEventArgs e)
            {
                ShowFatal(e.ExceptionObject as Exception);
            };

            // 登录 → 主界面 → 注销回登录窗口，直到用户关闭程序
            while (true)
            {
                bool loggedIn;
                using (var login = new LoginForm())
                {
                    loggedIn = login.ShowDialog() == DialogResult.OK;
                }
                if (!loggedIn) break;

                bool logoutRequested;
                using (var main = new MainForm())
                {
                    Application.Run(main);
                    logoutRequested = main.LogoutRequested;
                }

                Session.Clear();
                if (!logoutRequested) break;
            }
        }

        private static void ShowFatal(Exception ex)
        {
            if (ex == null) return;
            MessageBox.Show(
                "程序遇到一个未处理的问题：\r\n\r\n" + DbHelper.FriendlyMessage(ex),
                "小鑫小区物业管理系统",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
