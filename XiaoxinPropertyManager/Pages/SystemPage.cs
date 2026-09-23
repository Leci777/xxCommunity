using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 系统管理：系统信息、数据库备份、操作日志
    public partial class SystemPage : ModulePage
    {
        private string _lastBackupPath;

        public SystemPage()
        {
            InitializeComponent();
        }

        // ---- 工具栏按钮的点击方法 ----

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupDatabase();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLogs();
        }

        protected override void LoadData()
        {
            lblServer.Text = DbHelper.ServerName;
            lblDatabase.Text = DbHelper.DatabaseName;
            lblVersion.Text = Application.ProductVersion;

            try
            {
                int tableCount = DbHelper.ScalarInt("SELECT COUNT(1) FROM sys.tables WHERE is_ms_shipped = 0");
                lblTables.Text = tableCount + " 张";
                lblConnection.Text = "正常";
                lblConnection.ForeColor = UiTheme.Success;
            }
            catch (Exception ex)
            {
                lblTables.Text = "—";
                lblConnection.Text = "异常";
                lblConnection.ForeColor = UiTheme.Danger;
                lblBackupStatus.Text = DbHelper.FriendlyMessage(ex);
            }

            lblUser.Text = Session.LoginName + "（" + Session.DisplayName + "）";
            lblRole.Text = Session.Role;
            lblBackup.Text = string.IsNullOrEmpty(_lastBackupPath) ? "—" : Path.GetFileName(_lastBackupPath);
            lblBackupStatus.Text = string.IsNullOrEmpty(_lastBackupPath)
                ? "建议每周备份一次数据库。"
                : "备份位置：" + _lastBackupPath;

            LoadLogs();
        }

        private void LoadLogs()
        {
            DataTable table = DbHelper.Query(
                "SELECT TOP 200 LogId, UserName, Action, Detail, LogTime FROM tb_SysLog ORDER BY LogId DESC");

            Bind(table,
                new GridColumn("LogId", "序号", 45, GridAlign.Center),
                new GridColumn("UserName", "操作账号", 110),
                new GridColumn("Action", "操作类型", 90, GridAlign.Center),
                new GridColumn("Detail", "操作内容", 380),
                new GridColumn("LogTime", "操作时间", 130, GridAlign.Right, "yyyy-MM-dd HH:mm:ss"));
        }

        protected override void OnDataBound(DataTable data)
        {
            SetFooterSummary("日志按时间倒序显示最近 200 条");
        }

        // ---- 数据库备份 ----

        private void BackupDatabase()
        {
            string database = DbHelper.DatabaseName;
            if (string.IsNullOrEmpty(database) || database == "(未识别)")
            {
                Warn("无法识别当前数据库名称，请先检查数据库连接设置。");
                return;
            }

            string path;
            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "选择数据库备份文件保存位置";
                dialog.Filter = "SQL Server 备份文件 (*.bak)|*.bak";
                dialog.FileName = database + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bak";
                dialog.InitialDirectory = GetDefaultBackupFolder();
                dialog.OverwritePrompt = true;

                if (dialog.ShowDialog(this) != DialogResult.OK) return;
                path = dialog.FileName;
            }

            string sql = "BACKUP DATABASE [" + database.Replace("]", "]]") + "] TO DISK = N'"
                + path.Replace("'", "''") + "' WITH INIT";

            try
            {
                DbHelper.Execute(sql);
                _lastBackupPath = path;
                LogHelper.Write("备份数据库", "备份到：" + path);
                MessageBox.Show(this,
                    "数据库已成功备份。\r\n\r\n备份文件：" + path,
                    "备份完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    "备份失败：\r\n\r\n" + DbHelper.FriendlyMessage(ex) +
                    "\r\n\r\n提示：SQL Server 服务账号需要对该目录有写入权限，" +
                    "如果提示“拒绝访问”，可以换一个目录（例如 SQL Server 安装目录下的 Backup 文件夹）再试。",
                    "备份失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 优先用 SQL Server 自带 Backup 目录，服务账号不一定有写权限
        private static string GetDefaultBackupFolder()
        {
            try
            {
                string dataPath = DbHelper.ScalarString(
                    "SELECT CAST(SERVERPROPERTY('InstanceDefaultDataPath') AS NVARCHAR(400))");
                if (!string.IsNullOrEmpty(dataPath))
                {
                    var parent = Directory.GetParent(dataPath.TrimEnd('\\', '/'));
                    if (parent != null)
                    {
                        string backup = Path.Combine(parent.FullName, "Backup");
                        if (Directory.Exists(backup)) return backup;
                    }
                }
            }
            catch
            {
                // 万一读不到，就用程序自己所在的目录顶上
            }

            string local = Path.Combine(Application.StartupPath, "backup");
            try
            {
                if (!Directory.Exists(local)) Directory.CreateDirectory(local);
            }
            catch
            {
                return Application.StartupPath;
            }
            return local;
        }

        private void ClearLogs()
        {
            if (!Confirm("确定要清空全部操作日志吗？清空后无法恢复。")) return;

            Run(delegate
            {
                DbHelper.Execute("DELETE FROM tb_SysLog");
                LogHelper.Write("清空日志", "操作日志已被清空");
            }, "操作日志已清空。");
        }
    }
}
