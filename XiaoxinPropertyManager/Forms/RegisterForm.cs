using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Forms
{
    // 业主注册窗口，姓名和门牌号要跟物业登记的住户档案对得上才能注册
    public partial class RegisterForm : Form
    {
        private string _captchaCode;

        public RegisterForm()
        {
            InitializeComponent();
            RefreshCaptcha();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadBuildings();
        }

        private void LoadBuildings()
        {
            try
            {
                DataTable table = DbHelper.Query("SELECT BuildingName FROM tb_Building ORDER BY BuildingId");
                cboBuilding.Items.Clear();
                foreach (DataRow row in table.Rows)
                {
                    cboBuilding.Items.Add(Convert.ToString(row["BuildingName"]));
                }
                if (cboBuilding.Items.Count > 0) cboBuilding.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, DbHelper.FriendlyMessage(ex), "读取楼栋失败",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCaptcha()
        {
            const string chars = "23456789ABCDEFGHJKLMNPQRSTUVWXYZ";
            var random = new Random(Guid.NewGuid().GetHashCode());
            var sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }
            _captchaCode = sb.ToString();
            lblCaptcha.Text = _captchaCode;
        }

        private void LnkRefreshClick(object sender, EventArgs e)
        {
            RefreshCaptcha();
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRegisterClick(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string room = txtRoom.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pwd = txtPwd.Text;
            string pwd2 = txtPwd2.Text;
            string captcha = txtCaptcha.Text.Trim();

            if (name.Length == 0) { Warn("请填写姓名。", txtName); return; }
            if (!IsPhone(phone)) { Warn("手机号应为 11 位数字，且以 1 开头。", txtPhone); return; }
            if (cboBuilding.SelectedItem == null) { Warn("请选择楼栋。", cboBuilding); return; }
            if (room.Length == 0) { Warn("请填写门牌号。", txtRoom); return; }
            if (pwd.Length < 6 || pwd.Length > 20) { Warn("密码长度应在 6-20 位之间。", txtPwd); return; }
            if (pwd != pwd2) { Warn("两次输入的密码不一致。", txtPwd2); return; }
            if (email.Length > 0 && email.IndexOf("@", StringComparison.Ordinal) <= 0)
            {
                Warn("邮箱格式不正确。", txtEmail);
                return;
            }
            if (!string.Equals(captcha, _captchaCode, StringComparison.OrdinalIgnoreCase))
            {
                RefreshCaptcha();
                txtCaptcha.Clear();
                Warn("验证码不正确，请重新输入。", txtCaptcha);
                return;
            }

            try
            {
                // 检查手机号有没有注册过
                int exists = DbHelper.ScalarInt(
                    "SELECT COUNT(1) FROM tb_SysUser WHERE LoginName = @name",
                    DbHelper.P("@name", phone));
                if (exists > 0)
                {
                    Warn("该手机号已经注册过账号，请直接登录。", txtPhone);
                    return;
                }

                // 检查姓名 + 门牌号能不能对上住户档案
                DataTable household = DbHelper.Query(
                    "SELECT HouseholdId, OwnerName FROM tb_Household WHERE RoomNo = @room AND OwnerName = @owner",
                    DbHelper.P("@room", room),
                    DbHelper.P("@owner", name));

                if (household.Rows.Count == 0)
                {
                    MessageBox.Show(this,
                        "没有找到与该信息匹配的住户档案。\r\n\r\n" +
                        "请核对姓名和门牌号（例如：1栋1单元101）。\r\n" +
                        "如果确实还没登记，请先到物业服务中心登记住户信息。",
                        "无法完成注册", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int householdId = Convert.ToInt32(household.Rows[0]["HouseholdId"]);

                // 一户只能注册一个账号
                int bound = DbHelper.ScalarInt(
                    "SELECT COUNT(1) FROM tb_SysUser WHERE HouseholdId = @id",
                    DbHelper.P("@id", householdId));
                if (bound > 0)
                {
                    MessageBox.Show(this,
                        "该住户已经注册过登录账号，请直接登录或联系物业重置密码。",
                        "无法完成注册", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 检查通过，写进数据库
                DbHelper.Execute(
                    "INSERT INTO tb_SysUser (LoginName, Password, RealName, Phone, Email, Role, HouseholdId, Status, CreateTime) " +
                    "VALUES (@login, @pwd, @real, @phone, @email, @role, @hid, 1, GETDATE())",
                    DbHelper.P("@login", phone),
                    DbHelper.P("@pwd", HashHelper.Md5(pwd)),
                    DbHelper.P("@real", name),
                    DbHelper.P("@phone", phone),
                    DbHelper.P("@email", email),
                    DbHelper.P("@role", Session.RoleOwner),
                    DbHelper.P("@hid", householdId));

                LogHelper.Write("业主注册", "注册账号：" + phone + "（" + name + "）");

                MessageBox.Show(this,
                    "注册成功！\r\n\r\n登录账号：" + phone + "\r\n登录身份：业主\r\n\r\n" +
                    "请使用该账号登录系统。",
                    "注册成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, DbHelper.FriendlyMessage(ex), "注册失败",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool IsPhone(string value)
        {
            if (value.Length != 11) return false;
            if (value[0] != '1') return false;
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i])) return false;
            }
            return true;
        }

        private void Warn(string message, Control focus)
        {
            MessageBox.Show(this, message, "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (focus != null) focus.Focus();
        }
    }
}
