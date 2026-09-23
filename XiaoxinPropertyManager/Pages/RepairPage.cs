using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 报修管理：管理员代报、派单、登记完工，业主提交报修看进度
    public partial class RepairPage : ModulePage
    {
        private static readonly string[] StatusList = { "待处理", "处理中", "已完成" };

        public RepairPage()
        {
            InitializeComponent();
            ApplyRole();
        }

        // 管理员管工单，业主只能提交和撤销自己的报修
        private void ApplyRole()
        {
            if (DesignMode) return;

            bool admin = Session.IsAdmin;
            lblPageTitle.Text = admin ? "报修管理" : "我的报修";
            lblPageDescription.Text = admin ? "受理报修工单，派单并登记完工情况" : "在线提交报修，随时查看处理进度";
            lblKeyword.Visible = admin;
            txtKeyword.Visible = admin;
            btnReset.Visible = admin;
            btnAdd.Visible = admin;
            btnHandle.Visible = admin;
            btnDelete.Visible = admin;
            lblContent.Visible = !admin;
            txtContent.Visible = !admin;
            btnSubmit.Visible = !admin;
            btnCancel.Visible = !admin;

            // 管理员和业主各用一行工具栏，把对方那一行收起来
            pnlRoot.RowStyles[2].Height = admin ? 44F : 0F;
            pnlRoot.RowStyles[3].Height = admin ? 0F : 44F;
        }

        // ---- 工具栏按钮的点击方法 ----

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            Reload();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitRepair();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelRepair();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRepair();
        }

        private void btnHandle_Click(object sender, EventArgs e)
        {
            HandleRepair();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRepair();
        }

        protected override void LoadData()
        {
            var sql = new StringBuilder();
            sql.Append("SELECT r.RepairId, r.HouseholdId, h.OwnerName, h.RoomNo, r.Content, r.ReportDate, r.SolveDate, ");
            sql.Append("       CASE WHEN r.Status = N'已完成' THEN N'是' ELSE N'否' END AS RepairText, ");
            sql.Append("       r.RepairMan, r.Fee, r.Status, r.Remark ");
            sql.Append("FROM tb_Repair r LEFT JOIN tb_Household h ON r.HouseholdId = h.HouseholdId ");

            var conditions = new List<string>();
            var parameters = new List<SqlParameter>();

            if (Session.IsAdmin)
            {
                string keyword = txtKeyword == null ? string.Empty : txtKeyword.Text.Trim();
                if (keyword.Length > 0)
                {
                    conditions.Add("(h.OwnerName LIKE @like OR h.RoomNo LIKE @like OR r.Content LIKE @like)");
                    parameters.Add(DbHelper.Like("@like", keyword));
                }
            }
            else
            {
                conditions.Add("r.HouseholdId = @hid");
                parameters.Add(DbHelper.P("@hid", Session.HouseholdId));
            }

            string status = FilterValue(cboStatus, "全部");
            if (status.Length > 0)
            {
                conditions.Add("r.Status = @status");
                parameters.Add(DbHelper.P("@status", status));
            }

            // 没有筛选条件就不能拼 WHERE，否则拼出“WHERE ORDER BY”会报错
            if (conditions.Count > 0)
            {
                sql.Append("WHERE ").Append(string.Join(" AND ", conditions.ToArray())).Append(" ");
            }
            sql.Append("ORDER BY CASE r.Status WHEN N'待处理' THEN 1 WHEN N'处理中' THEN 2 ELSE 3 END, r.ReportDate DESC");

            DataTable table = DbHelper.Query(sql.ToString(), parameters.ToArray());

            var columns = new List<GridColumn>();
            columns.Add(new GridColumn("RepairId", "工单号", 55, GridAlign.Center));
            if (Session.IsAdmin)
            {
                columns.Add(new GridColumn("OwnerName", "报修住户", 80));
                columns.Add(new GridColumn("RoomNo", "门牌号", 105));
            }
            columns.Add(new GridColumn("Content", "报修内容", 220));
            columns.Add(new GridColumn("ReportDate", "上报时间", 115, GridAlign.Right, "yyyy-MM-dd HH:mm"));
            columns.Add(new GridColumn("SolveDate", "维修时间", 115, GridAlign.Right, "yyyy-MM-dd HH:mm"));
            columns.Add(new GridColumn("RepairText", "已维修", 55, GridAlign.Center));
            columns.Add(new GridColumn("RepairMan", "维修人", 70, GridAlign.Center));
            columns.Add(new GridColumn("Fee", "费用", 65, GridAlign.Right, "0.00"));
            columns.Add(new GridColumn("Status", "状态", 65, GridAlign.Center));

            Bind(table, columns.ToArray());
        }

        protected override void OnDataBound(DataTable data)
        {
            int pending = 0, working = 0, done = 0;
            decimal fee = 0m;
            foreach (DataRow row in data.Rows)
            {
                string status = Convert.ToString(row["Status"]);
                if (status == "待处理") pending++;
                else if (status == "处理中") working++;
                else done++;
                if (row["Fee"] != DBNull.Value) fee += Convert.ToDecimal(row["Fee"]);
            }

            SetFooterSummary("待处理 " + pending + " 单　处理中 " + working + " 单　已完成 " + done
                + " 单　维修费用合计 " + fee.ToString("0.00") + " 元");
        }

        protected override void OnDoubleClickRow()
        {
            if (Session.IsAdmin) HandleRepair();
        }

        //业主这边：提交报修、撤销报修

        private void SubmitRepair()
        {
            string content = txtContent.Text.Trim();
            if (content.Length == 0)
            {
                Warn("请先填写报修内容，例如“厨房水管漏水”。");
                txtContent.Focus();
                return;
            }
            if (Session.HouseholdId <= 0)
            {
                Warn("当前账号还没有关联住户档案，请联系物业服务中心处理。");
                return;
            }

            Run(delegate
            {
                DbHelper.Execute(
                    "INSERT INTO tb_Repair (HouseholdId, Content, ReportDate, Status, CreateTime) " +
                    "VALUES (@hid, @content, GETDATE(), N'待处理', GETDATE())",
                    DbHelper.P("@hid", Session.HouseholdId),
                    DbHelper.P("@content", content));
                LogHelper.Write("提交报修", "报修内容：" + content);
            }, "报修已提交，物业会尽快安排师傅上门。");

            txtContent.Clear();
        }

        private void CancelRepair()
        {
            int id = SelectedId("RepairId");
            if (id == 0)
            {
                Info("请先在列表中选择一条报修记录。");
                return;
            }

            string status = SelectedText("Status");
            if (status != "待处理")
            {
                Warn("只有“待处理”的报修才能撤销，该工单当前状态为“" + status + "”。");
                return;
            }

            if (!Confirm("确定要撤销这条报修吗？")) return;

            Run(delegate
            {
                DbHelper.Execute("DELETE FROM tb_Repair WHERE RepairId = @id AND HouseholdId = @hid",
                    DbHelper.P("@id", id),
                    DbHelper.P("@hid", Session.HouseholdId));
                LogHelper.Write("撤销报修", "工单号：" + id);
            }, "报修已撤销。");
        }

        //管理员这边：代报、处理、删除

        private void AddRepair()
        {
            DataTable households = DbHelper.Query(
                "SELECT HouseholdId, OwnerName, RoomNo FROM tb_Household ORDER BY HouseholdId");
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

            var dialog = new EditDialog("新增报修工单", "物业代业主登记报修");
            dialog.AddCombo("Household", "报修住户", labels, labels[0], true, 240);
            dialog.AddMultiline("Content", "报修内容", string.Empty, true, 90);
            dialog.AddDate("ReportDate", "上报时间", DateTime.Now);
            dialog.AddCombo("Status", "处理状态", StatusList, StatusList[0], true, 120);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            int index = Array.IndexOf(labels, dialog.Value("Household"));
            int householdId = index < 0 ? 0 : Convert.ToInt32(households.Rows[index]["HouseholdId"]);

            Run(delegate
            {
                DbHelper.Execute(
                    "INSERT INTO tb_Repair (HouseholdId, Content, ReportDate, Status, CreateTime) " +
                    "VALUES (@hid, @content, @date, @status, GETDATE())",
                    DbHelper.P("@hid", householdId),
                    DbHelper.P("@content", dialog.Value("Content")),
                    DbHelper.P("@date", dialog.ValueDate("ReportDate")),
                    DbHelper.P("@status", dialog.Value("Status")));
                LogHelper.Write("新增报修", "住户编号：" + householdId + "，内容：" + dialog.Value("Content"));
            }, "报修工单已新增。");
        }

        private void HandleRepair()
        {
            int id = SelectedId("RepairId");
            if (id == 0)
            {
                Info("请先在列表中选择一条报修记录。");
                return;
            }

            DataTable table = DbHelper.Query("SELECT * FROM tb_Repair WHERE RepairId = @id",
                DbHelper.P("@id", id));
            if (table.Rows.Count == 0)
            {
                Warn("该工单已不存在，请刷新后重试。");
                return;
            }

            DataRow row = table.Rows[0];
            string currentStatus = Convert.ToString(row["Status"]);
            string owner = SelectedText("OwnerName");
            string room = SelectedText("RoomNo");

            var dialog = new EditDialog("处理报修工单",
                "#" + id + "　" + owner + "　" + room + "　" + Convert.ToString(row["Content"]));
            dialog.AddReadOnly("Content", "报修内容", Convert.ToString(row["Content"]), 300);
            dialog.AddCombo("Status", "处理状态", StatusList, currentStatus, true, 130);
            dialog.AddText("RepairMan", "维修人", Str(row, "RepairMan"), false, 160);
            dialog.AddNumber("Fee", "维修费用(元)", Str(row, "Fee"), false, 160);
            dialog.AddDate("SolveDate", "维修时间",
                row["SolveDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row["SolveDate"]));
            dialog.AddMultiline("Remark", "处理说明", Str(row, "Remark"), false, 60);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            string status = dialog.Value("Status");
            string repairMan = dialog.Value("RepairMan");
            decimal fee = dialog.ValueDecimal("Fee");
            DateTime solveDate = dialog.ValueDate("SolveDate");
            string remark = dialog.Value("Remark");

            if (status == "已完成" && repairMan.Length == 0)
            {
                Warn("工单标记为“已完成”时，请填写维修人。");
                return;
            }

            Run(delegate
            {
                object solveValue = status == "待处理" ? (object)DBNull.Value : solveDate;
                DbHelper.Execute(
                    "UPDATE tb_Repair SET Status = @status, RepairMan = @man, Fee = @fee, " +
                    "SolveDate = @solve, Remark = @remark WHERE RepairId = @id",
                    DbHelper.P("@status", status),
                    DbHelper.P("@man", repairMan),
                    DbHelper.P("@fee", fee),
                    DbHelper.P("@solve", solveValue),
                    DbHelper.P("@remark", remark),
                    DbHelper.P("@id", id));
                LogHelper.Write("处理报修", "工单号 " + id + " → " + status);
            }, "工单已更新。");
        }

        private void DeleteRepair()
        {
            int id = SelectedId("RepairId");
            if (id == 0)
            {
                Info("请先在列表中选择一条报修记录。");
                return;
            }

            if (!Confirm("确定要删除工单 #" + id + " 吗？删除后不可恢复。")) return;

            Run(delegate
            {
                DbHelper.Execute("DELETE FROM tb_Repair WHERE RepairId = @id", DbHelper.P("@id", id));
                LogHelper.Write("删除报修", "工单号：" + id);
            }, "工单已删除。");
        }

        private static string Str(DataRow row, string column)
        {
            object value = row[column];
            if (value == null || value == DBNull.Value) return string.Empty;
            return Convert.ToString(value);
        }
    }
}
