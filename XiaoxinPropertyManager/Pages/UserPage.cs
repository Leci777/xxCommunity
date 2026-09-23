using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 用户管理：维护管理员和业主的登录账号
    public partial class UserPage : ModulePage
    {
        private static readonly string[] RoleList = { "管理员", "业主" };
        private static readonly string[] StateList = { "启用", "停用" };
        private const string NoHousehold = "（不关联住户）";

        public UserPage()
        {
            InitializeComponent();
        }

        // ---- 工具栏按钮的点击方法 ----

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            if (cboRole.Items.Count > 0) cboRole.SelectedIndex = 0;
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditUser(0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = SelectedId("UserId");
            if (id == 0)
            {
                Info("请先在列表中选择一个账号。");
                return;
            }
            EditUser(id);
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            ToggleStatus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        protected override void LoadData()
        {
            var sql = new StringBuilder();
            sql.Append("SELECT u.UserId, u.LoginName, u.RealName, u.Phone, u.Email, u.Role, u.HouseholdId, u.Status, ");
            sql.Append("       u.CreateTime, ");
            sql.Append("       ISNULL(h.OwnerName + N'　' + h.RoomNo, N'—') AS HouseholdText, ");
            sql.Append("       CASE WHEN u.Status = 1 THEN N'启用' ELSE N'停用' END AS StateText ");
            sql.Append("FROM tb_SysUser u LEFT JOIN tb_Household h ON u.HouseholdId = h.HouseholdId ");

            var conditions = new List<string>();
            var parameters = new List<SqlParameter>();

            string keyword = txtKeyword.Text.Trim();
            if (keyword.Length > 0)
            {
                conditions.Add("(u.LoginName LIKE @like OR u.RealName LIKE @like OR u.Phone LIKE @like)");
                parameters.Add(DbHelper.Like("@like", keyword));
            }

            string role = FilterValue(cboRole, "全部");
            if (role.Length > 0)
            {
                conditions.Add("u.Role = @role");
                parameters.Add(DbHelper.P("@role", role));
            }

            if (conditions.Count > 0)
            {
                sql.Append("WHERE ").Append(string.Join(" AND ", conditions.ToArray())).Append(" ");
            }
            sql.Append("ORDER BY u.Role, u.UserId");

            DataTable table = DbHelper.Query(sql.ToString(), parameters.ToArray());

            Bind(table,
                new GridColumn("UserId", "编号", 45, GridAlign.Center),
                new GridColumn("LoginName", "登录账号", 105),
                new GridColumn("RealName", "姓名", 70),
                new GridColumn("Phone", "手机号", 90),
                new GridColumn("Email", "邮箱", 150),
                new GridColumn("Role", "身份", 60, GridAlign.Center),
                new GridColumn("HouseholdText", "关联住户", 150),
                new GridColumn("StateText", "状态", 55, GridAlign.Center),
                new GridColumn("CreateTime", "注册时间", 95, GridAlign.Right, "yyyy-MM-dd"));
        }

        protected override void OnDataBound(DataTable data)
        {
            int admins = 0, owners = 0, disabled = 0;
            foreach (DataRow row in data.Rows)
            {
                if (Convert.ToString(row["Role"]) == Session.RoleAdmin) admins++;
                else owners++;
                if (Convert.ToInt32(row["Status"]) != 1) disabled++;
            }
            SetFooterSummary("管理员 " + admins + " 个　业主 " + owners + " 个　已停用 " + disabled + " 个");
        }

        protected override void OnDoubleClickRow()
        {
            int id = SelectedId("UserId");
            if (id > 0) EditUser(id);
        }

        // ---- 新增、修改账号 ----

        private void EditUser(int userId)
        {
            DataTable households = DbHelper.Query(
                "SELECT HouseholdId, OwnerName, RoomNo FROM tb_Household ORDER BY HouseholdId");

            var labels = new string[households.Rows.Count + 1];
            labels[0] = NoHousehold;
            for (int i = 0; i < households.Rows.Count; i++)
            {
                labels[i + 1] = Convert.ToString(households.Rows[i]["OwnerName"])
                    + "　" + Convert.ToString(households.Rows[i]["RoomNo"]);
            }

            DataRow row = null;
            if (userId > 0)
            {
                DataTable table = DbHelper.Query(
                    "SELECT u.*, h.OwnerName, h.RoomNo FROM tb_SysUser u " +
                    "LEFT JOIN tb_Household h ON u.HouseholdId = h.HouseholdId WHERE u.UserId = @id",
                    DbHelper.P("@id", userId));
                if (table.Rows.Count == 0)
                {
                    Warn("该账号已不存在，请刷新后重试。");
                    return;
                }
                row = table.Rows[0];
            }

            bool isNew = row == null;

            string currentLabel = NoHousehold;
            if (!isNew && row["HouseholdId"] != DBNull.Value)
            {
                currentLabel = Convert.ToString(row["OwnerName"]) + "　" + Convert.ToString(row["RoomNo"]);
            }

            string currentState = "启用";
            if (!isNew && Convert.ToInt32(row["Status"]) != 1) currentState = "停用";

            var dialog = new EditDialog(isNew ? "新增账号" : "修改账号",
                isNew ? "新增账号的初始密码为 123456，可在此直接修改" : "密码留空表示不修改");
            dialog.AddText("LoginName", "登录账号", Value(row, "LoginName"), true, 200);
            dialog.AddText("RealName", "姓名", Value(row, "RealName"), true, 160);
            dialog.AddText("Phone", "手机号", Value(row, "Phone"), true, 160);
            dialog.AddText("Email", "邮箱", Value(row, "Email"), false, 240);
            dialog.AddCombo("Role", "登录身份", RoleList, Value(row, "Role", Session.RoleAdmin), true, 110);
            dialog.AddCombo("Household", "关联住户", labels, currentLabel, false, 240);
            dialog.AddCombo("State", "账号状态", StateList, currentState, true, 110);
            dialog.AddPassword("Password", "登录密码", string.Empty, isNew, 160);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            string loginName = dialog.Value("LoginName");
            string password = dialog.Value("Password");

            if (password.Length > 0 && (password.Length < 6 || password.Length > 20))
            {
                Warn("密码长度应在 6-20 位之间。");
                return;
            }

            int duplicate = DbHelper.ScalarInt(
                "SELECT COUNT(1) FROM tb_SysUser WHERE LoginName = @name AND UserId <> @id",
                DbHelper.P("@name", loginName),
                DbHelper.P("@id", userId));
            if (duplicate > 0)
            {
                Warn("登录账号“" + loginName + "”已被占用，请换一个。");
                return;
            }

            string householdLabel = dialog.Value("Household");
            int householdId = 0;
            if (householdLabel != NoHousehold)
            {
                int index = Array.IndexOf(labels, householdLabel);
                if (index > 0) householdId = Convert.ToInt32(households.Rows[index - 1]["HouseholdId"]);
            }

            int state = dialog.Value("State") == "启用" ? 1 : 0;

            Run(delegate
            {
                var list = new List<SqlParameter>
                {
                    DbHelper.P("@login", loginName),
                    DbHelper.P("@real", dialog.Value("RealName")),
                    DbHelper.P("@phone", dialog.Value("Phone")),
                    DbHelper.P("@email", dialog.Value("Email")),
                    DbHelper.P("@role", dialog.Value("Role")),
                    DbHelper.P("@hid", householdId > 0 ? (object)householdId : DBNull.Value),
                    DbHelper.P("@status", state)
                };

                if (isNew)
                {
                    list.Add(DbHelper.P("@pwd", HashHelper.Md5(password.Length == 0 ? "123456" : password)));
                    DbHelper.Execute(
                        "INSERT INTO tb_SysUser (LoginName, Password, RealName, Phone, Email, Role, HouseholdId, Status, CreateTime) " +
                        "VALUES (@login, @pwd, @real, @phone, @email, @role, @hid, @status, GETDATE())",
                        list.ToArray());
                    LogHelper.Write("新增账号", "账号：" + loginName + "（" + dialog.Value("Role") + "）");
                }
                else
                {
                    string sql = "UPDATE tb_SysUser SET LoginName = @login, RealName = @real, Phone = @phone, " +
                                 "Email = @email, Role = @role, HouseholdId = @hid, Status = @status ";
                    if (password.Length > 0)
                    {
                        sql += ", Password = @pwd ";
                        list.Add(DbHelper.P("@pwd", HashHelper.Md5(password)));
                    }
                    sql += " WHERE UserId = @id";
                    list.Add(DbHelper.P("@id", userId));

                    DbHelper.Execute(sql, list.ToArray());
                    LogHelper.Write("修改账号", "账号：" + loginName);
                }
            }, isNew ? "账号已新增，初始密码 123456。" : "账号信息已更新。");
        }

        // ---- 其他几个操作，比如重置密码、停用账号 ----

        private void ResetPassword()
        {
            int id = SelectedId("UserId");
            if (id == 0)
            {
                Info("请先在列表中选择一个账号。");
                return;
            }

            string loginName = SelectedText("LoginName");
            if (!Confirm("确定要把账号“" + loginName + "”的密码重置为 123456 吗？")) return;

            Run(delegate
            {
                DbHelper.Execute("UPDATE tb_SysUser SET Password = @pwd WHERE UserId = @id",
                    DbHelper.P("@pwd", HashHelper.DefaultPasswordHash),
                    DbHelper.P("@id", id));
                LogHelper.Write("重置密码", "账号：" + loginName);
            }, "密码已重置为 123456。");
        }

        private void ToggleStatus()
        {
            int id = SelectedId("UserId");
            if (id == 0)
            {
                Info("请先在列表中选择一个账号。");
                return;
            }

            if (id == Session.UserId)
            {
                Warn("不能停用当前正在使用的账号。");
                return;
            }

            int status = DbHelper.ScalarInt("SELECT Status FROM tb_SysUser WHERE UserId = @id",
                DbHelper.P("@id", id));
            int newStatus = status == 1 ? 0 : 1;
            string loginName = SelectedText("LoginName");

            string action = newStatus == 1 ? "启用" : "停用";
            if (!Confirm("确定要" + action + "账号“" + loginName + "”吗？")) return;

            Run(delegate
            {
                DbHelper.Execute("UPDATE tb_SysUser SET Status = @status WHERE UserId = @id",
                    DbHelper.P("@status", newStatus),
                    DbHelper.P("@id", id));
                LogHelper.Write(action + "账号", "账号：" + loginName);
            }, "账号已" + action + "。");
        }

        private void DeleteUser()
        {
            int id = SelectedId("UserId");
            if (id == 0)
            {
                Info("请先在列表中选择一个账号。");
                return;
            }

            if (id == Session.UserId)
            {
                Warn("不能删除当前正在使用的账号。");
                return;
            }

            string role = SelectedText("Role");
            if (role == Session.RoleAdmin)
            {
                int adminCount = DbHelper.ScalarInt(
                    "SELECT COUNT(1) FROM tb_SysUser WHERE Role = @role",
                    DbHelper.P("@role", Session.RoleAdmin));
                if (adminCount <= 1)
                {
                    Warn("系统里至少要保留一个管理员账号。");
                    return;
                }
            }

            string loginName = SelectedText("LoginName");
            if (!Confirm("确定要删除账号“" + loginName + "”吗？删除后无法恢复。")) return;

            Run(delegate
            {
                DbHelper.Execute("DELETE FROM tb_SysUser WHERE UserId = @id", DbHelper.P("@id", id));
                LogHelper.Write("删除账号", "账号：" + loginName);
            }, "账号已删除。");
        }

        private static string Value(DataRow row, string column)
        {
            return Value(row, column, string.Empty);
        }

        private static string Value(DataRow row, string column, string fallback)
        {
            if (row == null) return fallback;
            object value = row[column];
            if (value == null || value == DBNull.Value) return fallback;
            string text = Convert.ToString(value).Trim();
            return text.Length == 0 ? fallback : text;
        }
    }
}
