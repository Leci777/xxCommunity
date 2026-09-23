using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Forms
{
    // 登录窗口
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtUser.Focus();
            CheckDatabaseAsync();
        }

        // 后台线程试数据库通不通，直接在主线程试界面会卡住
        private void CheckDatabaseAsync()
        {
            lblDbStatus.Text = "正在检查数据库连接…";
            lblDbStatus.ForeColor = UiTheme.TextSecondary;

            string connString = DbHelper.ConnString;

            Task.Factory.StartNew(delegate
            {
                string message;
                bool ok = DbHelper.TestConnection(connString, out message);
                return new object[] { ok, message };
            }).ContinueWith(delegate(Task<object[]> task)
            {
                bool ok = task.Status == TaskStatus.RanToCompletion && task.Result != null && (bool)task.Result[0];

                // 后台线程不能直接改控件，要绕回 UI 线程
                if (IsDisposed || !IsHandleCreated) return;
                try
                {
                    BeginInvoke((MethodInvoker)delegate { ApplyDbStatus(ok); });
                }
                catch (ObjectDisposedException)
                {
                    // 窗口已经关了就跳过
                }
                catch (InvalidOperationException)
                {
                    // 句柄已销毁，跳过
                }
            }, TaskContinuationOptions.ExecuteSynchronously);
        }

        private void ApplyDbStatus(bool ok)
        {
            lblDbStatus.Text = ok
                ? "数据库连接正常（" + DbHelper.DatabaseName + "）"
                : "数据库连接异常，请点击“数据库设置”检查配置";
            lblDbStatus.ForeColor = ok ? UiTheme.Success : UiTheme.Danger;
        }

        private void LnkRegisterClick(object sender, EventArgs e)
        {
            using (var form = new RegisterForm())
            {
                form.ShowDialog(this);
            }
        }

        private void LnkDbClick(object sender, EventArgs e)
        {
            using (var form = new DbSettingForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    CheckDatabaseAsync();
                }
            }
        }

        private void BtnLoginClick(object sender, EventArgs e)
        {
            string loginName = txtUser.Text.Trim();
            string password = txtPwd.Text;

            if (loginName.Length == 0)
            {
                Warn("请输入登录账号。");
                txtUser.Focus();
                return;
            }
            if (password.Length == 0)
            {
                Warn("请输入登录密码。");
                txtPwd.Focus();
                return;
            }

            string role = rdoAdmin.Checked ? Session.RoleAdmin : Session.RoleOwner;

            try
            {
                DataTable table = DbHelper.Query(
                    "SELECT UserId, LoginName, RealName, Role, HouseholdId, Status " +
                    "FROM tb_SysUser WHERE LoginName = @name AND Password = @pwd",
                    DbHelper.P("@name", loginName),
                    DbHelper.P("@pwd", HashHelper.Md5(password)));

                if (table.Rows.Count == 0)
                {
                    Warn("账号或密码不正确，请重新输入。");
                    txtPwd.SelectAll();
                    txtPwd.Focus();
                    return;
                }

                DataRow row = table.Rows[0];
                string dbRole = Convert.ToString(row["Role"]);

                if (dbRole != role)
                {
                    Warn("该账号的身份是“" + dbRole + "”，请在下方切换登录身份后重试。");
                    return;
                }

                if (Convert.ToInt32(row["Status"]) != 1)
                {
                    Warn("该账号已被停用，请联系物业服务中心。");
                    return;
                }

                Session.UserId = Convert.ToInt32(row["UserId"]);
                Session.LoginName = Convert.ToString(row["LoginName"]);
                Session.RealName = Convert.ToString(row["RealName"]);
                Session.Role = dbRole;
                Session.HouseholdId = row["HouseholdId"] == DBNull.Value
                    ? 0
                    : Convert.ToInt32(row["HouseholdId"]);

                LogHelper.Write("登录", dbRole + "登录系统");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    DbHelper.FriendlyMessage(ex) + "\r\n\r\n可以点击“数据库设置”修改连接信息。",
                    "数据库连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Warn(string message)
        {
            MessageBox.Show(this, message, "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
