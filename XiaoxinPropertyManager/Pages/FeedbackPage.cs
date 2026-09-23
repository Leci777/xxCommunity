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
    // 反馈管理：业主提意见，管理员回复
    public partial class FeedbackPage : ModulePage
    {
        private static readonly string[] TypeList = { "投诉", "建议" };
        private static readonly string[] StatusList = { "待处理", "已回复" };

        public FeedbackPage()
        {
            InitializeComponent();
            ApplyRole();
        }

        // 管理员负责回复，业主负责提交，两边看到的按钮不一样
        private void ApplyRole()
        {
            if (DesignMode) return;

            bool admin = Session.IsAdmin;
            lblPageTitle.Text = admin ? "反馈管理" : "投诉建议";
            lblPageDescription.Text = admin ? "查看业主的投诉与建议并回复" : "向物业提交投诉或建议，并查看回复";
            lblKeyword.Visible = admin;
            txtKeyword.Visible = admin;
            btnReply.Visible = admin;
            btnDelete.Visible = admin;
            btnAdd.Visible = !admin;

            if (!admin)
            {
                // 管理员那行按钮藏起来后第二行就空了，把它收起来，筛选控件再往左挪
                pnlRoot.RowStyles[2].Height = 0F;
                lblType.Location = new Point(24, 12);
                cboType.Location = new Point(70, 12);
                lblStatus.Location = new Point(186, 12);
                cboStatus.Location = new Point(264, 12);
                btnSearch.Location = new Point(390, 12);
                btnReset.Location = new Point(474, 12);
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
            if (cboType.Items.Count > 0) cboType.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            Reload();
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            ReplyFeedback();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFeedback();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFeedback();
        }

        protected override void LoadData()
        {
            var sql = new StringBuilder();
            sql.Append("SELECT f.FeedbackId, f.HouseholdId, h.OwnerName, h.RoomNo, f.FType, f.Title, f.Content, ");
            sql.Append("       f.CreateTime, f.ReplyContent, f.ReplyUser, f.ReplyTime, f.Status ");
            sql.Append("FROM tb_Feedback f LEFT JOIN tb_Household h ON f.HouseholdId = h.HouseholdId ");

            var conditions = new List<string>();
            var parameters = new List<SqlParameter>();

            if (Session.IsAdmin)
            {
                string keyword = txtKeyword.Text.Trim();
                if (keyword.Length > 0)
                {
                    conditions.Add("(f.Title LIKE @like OR f.Content LIKE @like OR h.OwnerName LIKE @like OR h.RoomNo LIKE @like)");
                    parameters.Add(DbHelper.Like("@like", keyword));
                }
            }
            else
            {
                conditions.Add("f.HouseholdId = @hid");
                parameters.Add(DbHelper.P("@hid", Session.HouseholdId));
            }

            string type = FilterValue(cboType, "全部");
            if (type.Length > 0)
            {
                conditions.Add("f.FType = @type");
                parameters.Add(DbHelper.P("@type", type));
            }

            string status = FilterValue(cboStatus, "全部");
            if (status.Length > 0)
            {
                conditions.Add("f.Status = @status");
                parameters.Add(DbHelper.P("@status", status));
            }

            if (conditions.Count > 0)
            {
                sql.Append("WHERE ").Append(string.Join(" AND ", conditions.ToArray())).Append(" ");
            }
            sql.Append("ORDER BY CASE WHEN f.Status = N'待处理' THEN 1 ELSE 2 END, f.CreateTime DESC");

            DataTable table = DbHelper.Query(sql.ToString(), parameters.ToArray());

            var columns = new List<GridColumn>();
            columns.Add(new GridColumn("FeedbackId", "编号", 45, GridAlign.Center));
            if (Session.IsAdmin)
            {
                columns.Add(new GridColumn("OwnerName", "提交人", 70));
                columns.Add(new GridColumn("RoomNo", "门牌号", 100));
            }
            columns.Add(new GridColumn("FType", "类型", 50, GridAlign.Center));
            columns.Add(new GridColumn("Title", "标题", 140));
            columns.Add(new GridColumn("Content", "内容", 220));
            columns.Add(new GridColumn("CreateTime", "提交时间", 110, GridAlign.Right, "yyyy-MM-dd HH:mm"));
            columns.Add(new GridColumn("Status", "状态", 60, GridAlign.Center));
            columns.Add(new GridColumn("ReplyContent", "物业回复", 220));
            columns.Add(new GridColumn("ReplyUser", "回复人", 65, GridAlign.Center));

            Bind(table, columns.ToArray());
        }

        protected override void OnDataBound(DataTable data)
        {
            int pending = 0, replied = 0;
            foreach (DataRow row in data.Rows)
            {
                if (Convert.ToString(row["Status"]) == "已回复") replied++;
                else pending++;
            }

            if (Session.IsAdmin)
            {
                SetFooterSummary("待处理 " + pending + " 条　已回复 " + replied + " 条",
                    pending > 0 ? UiTheme.Warning : UiTheme.TextSecondary);
            }
            else
            {
                SetFooterSummary("共 " + data.Rows.Count + " 条反馈　等待回复 " + pending + " 条");
            }
        }

        protected override void OnDoubleClickRow()
        {
            ViewFeedback();
        }

        private void ViewFeedback()
        {
            int id = SelectedId("FeedbackId");
            if (id == 0)
            {
                Info("请先在列表中选择一条反馈。");
                return;
            }

            DataTable table = DbHelper.Query("SELECT * FROM tb_Feedback WHERE FeedbackId = @id",
                DbHelper.P("@id", id));
            if (table.Rows.Count == 0)
            {
                Warn("该反馈已不存在，请刷新后重试。");
                return;
            }

            DataRow row = table.Rows[0];
            string reply = Value(row, "ReplyContent");

            var dialog = new EditDialog("反馈详情", Value(row, "Title"));
            dialog.AddReadOnly("Type", "类型", Value(row, "FType"));
            dialog.AddReadOnly("Time", "提交时间", Date(row, "CreateTime"));
            dialog.AddReadOnlyText("Content", "反馈内容", Value(row, "Content"), 120);
            dialog.AddReadOnly("ReplyUser", "回复人", Value(row, "ReplyUser", "—"));
            dialog.AddReadOnlyText("ReplyContent", "物业回复",
                reply.Length == 0 ? "物业尚未回复，请耐心等待。" : reply, 110);

            dialog.ShowDialog(this);
        }

        // ---- 业主提交反馈 ----

        private void AddFeedback()
        {
            if (Session.HouseholdId <= 0)
            {
                Warn("当前账号还没有关联住户档案，请联系物业服务中心处理。");
                return;
            }

            var dialog = new EditDialog("提交投诉 / 建议", "物业会尽快处理并回复");
            dialog.AddCombo("FType", "类型", TypeList, TypeList[0], true, 110);
            dialog.AddText("Title", "标题", string.Empty, true, 300);
            dialog.AddMultiline("Content", "详细内容", string.Empty, true, 150);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            Run(delegate
            {
                DbHelper.Execute(
                    "INSERT INTO tb_Feedback (HouseholdId, FType, Title, Content, CreateTime, Status) " +
                    "VALUES (@hid, @type, @title, @content, GETDATE(), N'待处理')",
                    DbHelper.P("@hid", Session.HouseholdId),
                    DbHelper.P("@type", dialog.Value("FType")),
                    DbHelper.P("@title", dialog.Value("Title")),
                    DbHelper.P("@content", dialog.Value("Content")));
                LogHelper.Write("提交反馈", dialog.Value("FType") + "：" + dialog.Value("Title"));
            }, "已提交，物业会尽快处理。");
        }

        // ---- 管理员回复反馈 ----

        private void ReplyFeedback()
        {
            int id = SelectedId("FeedbackId");
            if (id == 0)
            {
                Info("请先在列表中选择一条反馈。");
                return;
            }

            DataTable table = DbHelper.Query("SELECT * FROM tb_Feedback WHERE FeedbackId = @id",
                DbHelper.P("@id", id));
            if (table.Rows.Count == 0)
            {
                Warn("该反馈已不存在，请刷新后重试。");
                return;
            }

            DataRow row = table.Rows[0];

            var dialog = new EditDialog("回复反馈", "回复内容会显示在业主的“投诉建议”里");
            dialog.AddReadOnly("Type", "类型 / 提交人",
                Value(row, "FType") + "　" + SelectedText("OwnerName") + "　" + SelectedText("RoomNo"), 240);
            dialog.AddReadOnlyText("Content", "反馈内容", Value(row, "Content"), 110);
            dialog.AddMultiline("ReplyContent", "回复内容", Value(row, "ReplyContent"), true, 130);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            Run(delegate
            {
                DbHelper.Execute(
                    "UPDATE tb_Feedback SET ReplyContent = @reply, ReplyUser = @user, ReplyTime = GETDATE(), " +
                    "Status = N'已回复' WHERE FeedbackId = @id",
                    DbHelper.P("@reply", dialog.Value("ReplyContent")),
                    DbHelper.P("@user", Session.LoginName),
                    DbHelper.P("@id", id));
                LogHelper.Write("回复反馈", "编号：" + id);
            }, "回复已提交。");
        }

        private void DeleteFeedback()
        {
            int id = SelectedId("FeedbackId");
            if (id == 0)
            {
                Info("请先在列表中选择一条反馈。");
                return;
            }

            if (!Confirm("确定要删除编号 " + id + " 的反馈吗？")) return;

            Run(delegate
            {
                DbHelper.Execute("DELETE FROM tb_Feedback WHERE FeedbackId = @id", DbHelper.P("@id", id));
                LogHelper.Write("删除反馈", "编号：" + id);
            }, "反馈已删除。");
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

        private static string Date(DataRow row, string column)
        {
            if (row[column] == DBNull.Value) return "—";
            return Convert.ToDateTime(row[column]).ToString("yyyy-MM-dd HH:mm");
        }
    }
}
