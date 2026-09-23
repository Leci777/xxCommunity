using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Forms
{
    // 数据库连接设置窗口，不用去改 App.config 里的 XML
    public partial class DbSettingForm : Form
    {
        public DbSettingForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txtServer.Text = ".";
            txtDatabase.Text = "XiaoxinCommunityDB";
            cboAuth.SelectedIndex = 0;

            try
            {
                var builder = new SqlConnectionStringBuilder(DbHelper.ConnString);
                txtServer.Text = string.IsNullOrEmpty(builder.DataSource) ? "." : builder.DataSource;
                txtDatabase.Text = string.IsNullOrEmpty(builder.InitialCatalog)
                    ? "XiaoxinCommunityDB" : builder.InitialCatalog;

                if (builder.IntegratedSecurity)
                {
                    cboAuth.SelectedIndex = 0;
                }
                else
                {
                    cboAuth.SelectedIndex = 1;
                    txtUser.Text = builder.UserID;
                    txtPassword.Text = builder.Password;
                }
            }
            catch
            {
                // 解析不了就用上面填的默认值
            }

            UpdateAuthState();
        }

        private void CboAuthSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAuthState();
        }

        private void UpdateAuthState()
        {
            bool sqlAuth = cboAuth.SelectedIndex == 1;
            txtUser.Enabled = sqlAuth;
            txtPassword.Enabled = sqlAuth;
            txtUser.BackColor = sqlAuth ? UiTheme.Surface : Color.FromArgb(248, 249, 251);
            txtPassword.BackColor = sqlAuth ? UiTheme.Surface : Color.FromArgb(248, 249, 251);
        }

        private string BuildConnString()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = txtServer.Text.Trim().Length == 0 ? "." : txtServer.Text.Trim();
            builder.InitialCatalog = txtDatabase.Text.Trim().Length == 0
                ? "XiaoxinCommunityDB" : txtDatabase.Text.Trim();
            builder.ConnectTimeout = 15;

            if (cboAuth.SelectedIndex == 1)
            {
                builder.IntegratedSecurity = false;
                builder.UserID = txtUser.Text.Trim();
                builder.Password = txtPassword.Text;
            }
            else
            {
                builder.IntegratedSecurity = true;
            }
            return builder.ConnectionString;
        }

        private bool TestConnection(bool showResult)
        {
            string connString = BuildConnString();
            string message;
            bool ok = DbHelper.TestConnection(connString, out message);

            if (showResult)
            {
                lblStatus.Text = ok ? "连接成功：" + message : "连接失败：" + message;
                lblStatus.ForeColor = ok ? UiTheme.Success : UiTheme.Danger;
            }
            return ok;
        }

        private void BtnTestClick(object sender, EventArgs e)
        {
            TestConnection(true);
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            if (!TestConnection(false))
            {
                string message;
                DbHelper.TestConnection(BuildConnString(), out message);
                var answer = MessageBox.Show(this,
                    "连接测试没有通过：\r\n\r\n" + message + "\r\n\r\n是否仍然保存这个配置？",
                    "连接失败", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer != DialogResult.Yes) return;
            }

            try
            {
                DbHelper.SaveConnString(BuildConnString());
                MessageBox.Show(this, "数据库连接设置已保存，并写回 App.config。",
                    "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    "保存失败：" + ex.Message + "\r\n\r\n如果程序放在只读目录下，请手工修改 App.config。",
                    "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
