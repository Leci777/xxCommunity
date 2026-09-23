using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 收费管理：管理员登记物业费、水电费、停车费并核销，业主查自己的费用
    public partial class FeePage : ModulePage
    {
        private static readonly string[] FeeTypes = { "物业费", "水费", "电费", "停车费" };
        private static readonly string[] PayStatusList = { "未缴", "已缴" };

        public FeePage()
        {
            InitializeComponent();
            ApplyRole();
        }

        // 管理员登记和核销费用，业主只能查自己的账单
        private void ApplyRole()
        {
            if (DesignMode) return;

            bool admin = Session.IsAdmin;
            lblPageTitle.Text = admin ? "收费管理" : "我的费用";
            lblPageDescription.Text = admin ? "登记各项费用并核销，随时掌握收缴情况" : "查询各项费用的缴纳情况";
            lblKeyword.Visible = admin;
            txtKeyword.Visible = admin;
            lblMonth.Visible = admin;
            txtMonth.Visible = admin;
            btnAdd.Visible = admin;
            btnPay.Visible = admin;
            btnBatch.Visible = admin;
            btnDelete.Visible = admin;

            txtMonth.Text = DateTime.Now.ToString("yyyy-MM");

            if (!admin)
            {
                // 管理员那一行整个藏掉了，把它收起来，筛选这行正好顶上去
                pnlRoot.RowStyles[1].Height = 0F;
            }
        }

        // ---- 工具栏按钮的点击方法 ----

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Visible) txtKeyword.Clear();
            if (txtMonth.Visible) txtMonth.Clear();
            if (cboType.Items.Count > 0) cboType.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditFee(0);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MarkPaid();
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            GeneratePropertyFee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFee();
        }

        protected override void LoadData()
        {
            var sql = new StringBuilder();
            sql.Append("SELECT f.FeeId, f.HouseholdId, h.OwnerName, h.RoomNo, f.FeeType, f.FeeMonth, f.Amount, ");
            sql.Append("       f.PayStatus, f.PayDate, f.Operator, f.Remark ");
            sql.Append("FROM tb_Fee f LEFT JOIN tb_Household h ON f.HouseholdId = h.HouseholdId ");

            var conditions = new List<string>();
            var parameters = new List<SqlParameter>();

            if (Session.IsAdmin)
            {
                string keyword = txtKeyword.Text.Trim();
                if (keyword.Length > 0)
                {
                    conditions.Add("(h.OwnerName LIKE @like OR h.RoomNo LIKE @like OR f.Operator LIKE @like)");
                    parameters.Add(DbHelper.Like("@like", keyword));
                }
                string month = txtMonth.Text.Trim();
                if (month.Length > 0)
                {
                    conditions.Add("f.FeeMonth LIKE @month");
                    parameters.Add(DbHelper.Like("@month", month));
                }
            }
            else
            {
                conditions.Add("f.HouseholdId = @hid");
                parameters.Add(DbHelper.P("@hid", Session.HouseholdId));
            }

            string feeType = FilterValue(cboType, "全部");
            if (feeType.Length > 0)
            {
                conditions.Add("f.FeeType = @type");
                parameters.Add(DbHelper.P("@type", feeType));
            }

            string payStatus = FilterValue(cboStatus, "全部");
            if (payStatus.Length > 0)
            {
                conditions.Add("f.PayStatus = @status");
                parameters.Add(DbHelper.P("@status", payStatus));
            }

            if (conditions.Count > 0)
            {
                sql.Append("WHERE ").Append(string.Join(" AND ", conditions.ToArray())).Append(" ");
            }
            sql.Append("ORDER BY f.FeeMonth DESC, f.FeeId DESC");

            DataTable table = DbHelper.Query(sql.ToString(), parameters.ToArray());

            var columns = new List<GridColumn>();
            columns.Add(new GridColumn("FeeId", "编号", 45, GridAlign.Center));
            if (Session.IsAdmin)
            {
                columns.Add(new GridColumn("OwnerName", "住户", 75));
                columns.Add(new GridColumn("RoomNo", "门牌号", 100));
            }
            columns.Add(new GridColumn("FeeType", "费用类型", 70, GridAlign.Center));
            columns.Add(new GridColumn("FeeMonth", "费用月份", 80, GridAlign.Center));
            columns.Add(new GridColumn("Amount", "金额(元)", 80, GridAlign.Right, "0.00"));
            columns.Add(new GridColumn("PayStatus", "缴费状态", 70, GridAlign.Center));
            columns.Add(new GridColumn("PayDate", "缴费时间", 115, GridAlign.Right, "yyyy-MM-dd HH:mm"));
            columns.Add(new GridColumn("Operator", "经办人", 75, GridAlign.Center));
            if (Session.IsAdmin) columns.Add(new GridColumn("Remark", "备注", 140));

            Bind(table, columns.ToArray());
        }

        protected override void OnDataBound(DataTable data)
        {
            decimal total = 0m, paid = 0m, unpaid = 0m;
            foreach (DataRow row in data.Rows)
            {
                decimal amount = row["Amount"] == DBNull.Value ? 0m : Convert.ToDecimal(row["Amount"]);
                total += amount;
                if (Convert.ToString(row["PayStatus"]) == "已缴") paid += amount;
                else unpaid += amount;
            }

            SetFooterSummary("合计 " + total.ToString("0.00") + " 元　已缴 " + paid.ToString("0.00")
                + " 元　未缴 " + unpaid.ToString("0.00") + " 元",
                unpaid > 0 ? UiTheme.Danger : UiTheme.TextSecondary);
        }

        protected override void OnDoubleClickRow()
        {
            if (Session.IsAdmin) MarkPaid();
        }

        // ---- 新增、修改费用 ----

        private void EditFee(int feeId)
        {
            DataTable households = DbHelper.Query(
                "SELECT HouseholdId, OwnerName, RoomNo, Area FROM tb_Household ORDER BY HouseholdId");
            if (households.Rows.Count == 0)
            {
                Warn("还没有住户档案，请先到“住户管理”登记住户。");
                return;
            }

            var labels = new string[households.Rows.Count];
            for (int i = 0; i < households.Rows.Count; i++)
            {
                labels[i] = Convert.ToString(households.Rows[i]["OwnerName"])
                    + "　" + Convert.ToString(households.Rows[i]["RoomNo"]);
            }

            DataRow row = null;
            if (feeId > 0)
            {
                DataTable table = DbHelper.Query(
                    "SELECT f.*, h.OwnerName, h.RoomNo FROM tb_Fee f " +
                    "LEFT JOIN tb_Household h ON f.HouseholdId = h.HouseholdId WHERE f.FeeId = @id",
                    DbHelper.P("@id", feeId));
                if (table.Rows.Count == 0)
                {
                    Warn("该收费记录已不存在，请刷新后重试。");
                    return;
                }
                row = table.Rows[0];
            }

            string currentLabel = null;
            if (row != null && row["HouseholdId"] != DBNull.Value)
            {
                currentLabel = Convert.ToString(row["OwnerName"]) + "　" + Convert.ToString(row["RoomNo"]);
            }

            var dialog = new EditDialog(feeId > 0 ? "修改收费记录" : "新增收费记录",
                "物业费标准见“小区管理”，也可用“生成本月物业费”批量登记");
            dialog.AddCombo("Household", "住户", labels, currentLabel, true, 240);
            dialog.AddCombo("FeeType", "费用类型", FeeTypes, Str(row, "FeeType", FeeTypes[0]), true, 130);
            dialog.AddText("FeeMonth", "费用月份", Str(row, "FeeMonth", DateTime.Now.ToString("yyyy-MM")), true, 130);
            dialog.AddNumber("Amount", "金额(元)", Str(row, "Amount"), true, 130);
            dialog.AddCombo("PayStatus", "缴费状态", PayStatusList, Str(row, "PayStatus", "未缴"), true, 110);
            dialog.AddDate("PayDate", "缴费时间",
                row == null || row["PayDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row["PayDate"]));
            dialog.AddText("Operator", "经办人", Str(row, "Operator", Session.LoginName), false, 160);
            dialog.AddText("Remark", "备注", Str(row, "Remark"), false, 260);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            int index = Array.IndexOf(labels, dialog.Value("Household"));
            int householdId = index < 0 ? 0 : Convert.ToInt32(households.Rows[index]["HouseholdId"]);

            string payStatus = dialog.Value("PayStatus");
            object payDate = payStatus == "已缴" ? (object)dialog.ValueDate("PayDate") : DBNull.Value;

            Run(delegate
            {
                if (feeId > 0)
                {
                    DbHelper.Execute(
                        "UPDATE tb_Fee SET HouseholdId = @hid, FeeType = @type, FeeMonth = @month, Amount = @amount, " +
                        "PayStatus = @status, PayDate = @paydate, Operator = @operator, Remark = @remark WHERE FeeId = @id",
                        FeeParameters(dialog, householdId, payStatus, payDate, feeId));
                    LogHelper.Write("修改收费", "编号 " + feeId + "：" + dialog.Value("FeeType") + " " + dialog.Value("Amount") + " 元");
                }
                else
                {
                    DbHelper.Execute(
                        "INSERT INTO tb_Fee (HouseholdId, FeeType, FeeMonth, Amount, PayStatus, PayDate, Operator, Remark, CreateTime) " +
                        "VALUES (@hid, @type, @month, @amount, @status, @paydate, @operator, @remark, GETDATE())",
                        FeeParameters(dialog, householdId, payStatus, payDate, 0));
                    LogHelper.Write("新增收费", dialog.Value("FeeType") + " " + dialog.Value("Amount") + " 元");
                }
            }, feeId > 0 ? "收费记录已更新。" : "收费记录已新增。");
        }

        private static SqlParameter[] FeeParameters(EditDialog dialog, int householdId, string payStatus, object payDate, int feeId)
        {
            var list = new List<SqlParameter>
            {
                DbHelper.P("@hid", householdId),
                DbHelper.P("@type", dialog.Value("FeeType")),
                DbHelper.P("@month", dialog.Value("FeeMonth")),
                DbHelper.P("@amount", dialog.ValueDecimal("Amount")),
                DbHelper.P("@status", payStatus),
                DbHelper.P("@paydate", payDate),
                DbHelper.P("@operator", dialog.Value("Operator")),
                DbHelper.P("@remark", dialog.Value("Remark"))
            };
            if (feeId > 0) list.Add(DbHelper.P("@id", feeId));
            return list.ToArray();
        }

        // ---- 收到钱以后做核销 ----

        private void MarkPaid()
        {
            int id = SelectedId("FeeId");
            if (id == 0)
            {
                Info("请先在列表中选择一条收费记录。");
                return;
            }

            DataTable table = DbHelper.Query("SELECT * FROM tb_Fee WHERE FeeId = @id", DbHelper.P("@id", id));
            if (table.Rows.Count == 0)
            {
                Warn("该收费记录已不存在，请刷新后重试。");
                return;
            }

            DataRow row = table.Rows[0];
            string feeType = Convert.ToString(row["FeeType"]);
            string month = Convert.ToString(row["FeeMonth"]);
            decimal amount = row["Amount"] == DBNull.Value ? 0m : Convert.ToDecimal(row["Amount"]);

            var dialog = new EditDialog("核销缴费", feeType + "　" + month + "　" + amount.ToString("0.00") + " 元");
            dialog.AddCombo("PayStatus", "缴费状态", PayStatusList, Convert.ToString(row["PayStatus"]), true, 110);
            dialog.AddDate("PayDate", "缴费时间",
                row["PayDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row["PayDate"]));
            dialog.AddText("Operator", "经办人", Str(row, "Operator", Session.LoginName), false, 160);
            dialog.AddText("Remark", "备注", Str(row, "Remark"), false, 260);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            string status = dialog.Value("PayStatus");
            object payDate = status == "已缴" ? (object)dialog.ValueDate("PayDate") : DBNull.Value;

            Run(delegate
            {
                DbHelper.Execute(
                    "UPDATE tb_Fee SET PayStatus = @status, PayDate = @paydate, Operator = @operator, Remark = @remark " +
                    "WHERE FeeId = @id",
                    DbHelper.P("@status", status),
                    DbHelper.P("@paydate", payDate),
                    DbHelper.P("@operator", dialog.Value("Operator")),
                    DbHelper.P("@remark", dialog.Value("Remark")),
                    DbHelper.P("@id", id));
                LogHelper.Write("核销缴费", feeType + " " + month + " → " + status);
            }, "缴费状态已更新。");
        }

        // ---- 批量生成物业费 ----

        private void GeneratePropertyFee()
        {
            string month = txtMonth.Text.Trim();
            if (month.Length == 0) month = DateTime.Now.ToString("yyyy-MM");

            decimal rate = ReadPropertyFeeRate();

            if (!Confirm("将按 " + rate.ToString("0.00") + " 元/㎡ 为所有尚未登记 " + month
                + " 物业费的住户批量生成收费记录，是否继续？"))
            {
                return;
            }

            Run(delegate
            {
                int created = DbHelper.Execute(
                    "INSERT INTO tb_Fee (HouseholdId, FeeType, FeeMonth, Amount, PayStatus, Operator, Remark, CreateTime) " +
                    "SELECT h.HouseholdId, N'物业费', @month, ROUND(ISNULL(h.Area, 0) * @rate, 2), N'未缴', @operator, " +
                    "       N'按建筑面积自动生成', GETDATE() " +
                    "FROM tb_Household h " +
                    "WHERE NOT EXISTS (SELECT 1 FROM tb_Fee f WHERE f.HouseholdId = h.HouseholdId " +
                    "                  AND f.FeeType = N'物业费' AND f.FeeMonth = @month)",
                    DbHelper.P("@month", month),
                    DbHelper.P("@rate", rate),
                    DbHelper.P("@operator", Session.LoginName));

                if (created == 0)
                {
                    throw new InvalidOperationException("所有住户都已经登记了 " + month + " 的物业费，无需重复生成。");
                }

                LogHelper.Write("批量生成物业费", month + " 共生成 " + created + " 条，单价 " + rate.ToString("0.00"));
            }, "物业费已生成。");
        }

        // 从“物业费标准”文字里抠出单价，如 1.80 元/平方米·月
        private static decimal ReadPropertyFeeRate()
        {
            const decimal fallback = 1.80m;

            string text = DbHelper.ScalarString("SELECT TOP 1 PropertyFeeRate FROM tb_Community ORDER BY CommunityId");
            if (string.IsNullOrEmpty(text)) return fallback;

            var digits = new StringBuilder();
            bool started = false;
            foreach (char c in text)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    digits.Append(c);
                    started = true;
                }
                else if (started)
                {
                    break;
                }
            }

            decimal rate;
            if (decimal.TryParse(digits.ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out rate) && rate > 0)
            {
                return rate;
            }
            return fallback;
        }

        private void DeleteFee()
        {
            int id = SelectedId("FeeId");
            if (id == 0)
            {
                Info("请先在列表中选择一条收费记录。");
                return;
            }

            if (!Confirm("确定要删除编号 " + id + " 的收费记录吗？")) return;

            Run(delegate
            {
                DbHelper.Execute("DELETE FROM tb_Fee WHERE FeeId = @id", DbHelper.P("@id", id));
                LogHelper.Write("删除收费", "编号：" + id);
            }, "收费记录已删除。");
        }

        private static string Str(DataRow row, string column, string fallback)
        {
            if (row == null) return fallback;
            object value = row[column];
            if (value == null || value == DBNull.Value) return fallback;
            string text = Convert.ToString(value).Trim();
            return text.Length == 0 ? fallback : text;
        }

        private static string Str(DataRow row, string column)
        {
            return Str(row, column, string.Empty);
        }
    }
}
