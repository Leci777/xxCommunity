using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 我的信息：业主看自己的档案，能改电话、家庭人数、备注和密码
    public partial class OwnerInfoPage : ModulePage
    {
        public OwnerInfoPage()
        {
            InitializeComponent();

            // 账号没绑住户档案时，只留“提示”那张卡片，另外两张整行收起来
            if (!DesignMode && Session.HouseholdId <= 0)
            {
                Body.RowStyles[1].Height = 0F;
                Body.RowStyles[2].Height = 0F;
                cardProfile.Visible = false;
                cardEditable.Visible = false;
                btnSave.Visible = false;
            }
            else
            {
                Body.RowStyles[0].Height = 0F;
                tipCard.Visible = false;
            }
        }

        // ---- 工具栏按钮的点击方法 ----

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        protected override void LoadData()
        {
            LoadAccount();

            if (Session.HouseholdId <= 0) return;

            DataTable table = DbHelper.Query(
                "SELECT h.*, b.BuildingName FROM tb_Household h " +
                "LEFT JOIN tb_Building b ON h.BuildingId = b.BuildingId WHERE h.HouseholdId = @id",
                DbHelper.P("@id", Session.HouseholdId));

            if (table.Rows.Count == 0)
            {
                SetStatus("未找到对应的住户档案，请联系物业服务中心");
                return;
            }

            DataRow row = table.Rows[0];

            lblOwnerName.Text = Str(row, "OwnerName");
            lblGender.Text = Str(row, "Gender", "—");
            lblIdCard.Text = Str(row, "IdCard", "—");
            lblMoveIn.Text = row["MoveInDate"] == DBNull.Value
                ? "—" : Convert.ToDateTime(row["MoveInDate"]).ToString("yyyy-MM-dd");
            lblBuilding.Text = Str(row, "BuildingName", "—");
            lblRoomNo.Text = Str(row, "RoomNo", "—");
            lblArea.Text = row["Area"] == DBNull.Value
                ? "—" : Convert.ToDecimal(row["Area"]).ToString("0.00") + " 平方米";
            lblLoginName.Text = Session.LoginName;

            txtPhone.Text = Str(row, "Phone");
            txtFamily.Text = row["FamilyCount"] == DBNull.Value ? "0" : Convert.ToString(row["FamilyCount"]);
            txtRemark.Text = Str(row, "Remark");

            SetStatus("档案编号：" + Convert.ToString(row["HouseholdId"]));
        }

        private void LoadAccount()
        {
            if (txtEmail == null) return;

            DataTable table = DbHelper.Query(
                "SELECT Email FROM tb_SysUser WHERE UserId = @id",
                DbHelper.P("@id", Session.UserId));

            if (table.Rows.Count == 0) return;
            txtEmail.Text = Str(table.Rows[0], "Email");
        }

        private void SaveChanges()
        {
            if (Session.HouseholdId <= 0)
            {
                Warn("当前账号没有关联住户档案，无法保存。");
                return;
            }

            string password = txtNewPassword.Text;
            string password2 = txtNewPassword2.Text;

            if (password.Length > 0 || password2.Length > 0)
            {
                if (password.Length < 6 || password.Length > 20)
                {
                    Warn("新密码长度应在 6-20 位之间。");
                    txtNewPassword.Focus();
                    return;
                }
                if (password != password2)
                {
                    Warn("两次输入的新密码不一致。");
                    txtNewPassword2.Focus();
                    return;
                }
            }

            string phone = txtPhone.Text.Trim();
            if (phone.Length > 0)
            {
                string digits = phone.Replace("-", string.Empty);
                if (digits.Length < 7)
                {
                    Warn("联系电话格式不正确。");
                    txtPhone.Focus();
                    return;
                }
            }

            int family = DbHelper.ToInt(txtFamily.Text, 0);
            if (family < 0 || family > 30)
            {
                Warn("家庭人数请填写 0-30 之间的数字。");
                txtFamily.Focus();
                return;
            }

            Run(delegate
            {
                DbHelper.Execute(
                    "UPDATE tb_Household SET Phone = @phone, FamilyCount = @family, Remark = @remark " +
                    "WHERE HouseholdId = @id",
                    DbHelper.P("@phone", phone),
                    DbHelper.P("@family", family),
                    DbHelper.P("@remark", txtRemark.Text.Trim()),
                    DbHelper.P("@id", Session.HouseholdId));

                DbHelper.Execute(
                    "UPDATE tb_SysUser SET Email = @email WHERE UserId = @id",
                    DbHelper.P("@email", txtEmail.Text.Trim()),
                    DbHelper.P("@id", Session.UserId));

                if (password.Length > 0)
                {
                    DbHelper.Execute(
                        "UPDATE tb_SysUser SET Password = @pwd WHERE UserId = @id",
                        DbHelper.P("@pwd", HashHelper.Md5(password)),
                        DbHelper.P("@id", Session.UserId));
                }

                LogHelper.Write("修改个人信息", password.Length > 0 ? "包含密码修改" : "联系方式更新");
            }, password.Length > 0 ? "信息已保存，密码修改成功。" : "信息已保存。");

            txtNewPassword.Clear();
            txtNewPassword2.Clear();
        }

        private static string Str(DataRow row, string column)
        {
            return Str(row, column, string.Empty);
        }

        private static string Str(DataRow row, string column, string fallback)
        {
            if (row == null) return fallback;
            object value = row[column];
            if (value == null || value == DBNull.Value) return fallback;
            string text = Convert.ToString(value).Trim();
            return text.Length == 0 ? fallback : text;
        }
    }
}
