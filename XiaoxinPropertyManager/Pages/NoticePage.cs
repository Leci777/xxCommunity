using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 公告管理：管理员发布、修改、删除，业主只能看
    public partial class NoticePage : ModulePage
    {
        private static readonly string[] Categories = { "通知", "停水", "停电", "活动" };

        public NoticePage()
        {
            InitializeComponent();
            ApplyRole();
        }

        // 管理员能发布公告，业主只能看，这里按身份显示对应的按钮
        private void ApplyRole()
        {
            if (DesignMode) return;

            bool admin = Session.IsAdmin;
            lblPageTitle.Text = admin ? "公告管理" : "小区公告";
            lblPageDescription.Text = admin ? "发布停水停电、社区活动等通知" : "查阅物业发布的最新通知";
            btnAdd.Visible = admin;
            btnEdit.Visible = admin;
            btnDelete.Visible = admin;
            btnView.Visible = !admin;
        }

        // ---- 工具栏按钮的点击方法 ----

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditNotice(0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = SelectedId("NoticeId");
            if (id == 0)
            {
                Info("请先在列表中选择一条公告。");
                return;
            }
            EditNotice(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteNotice();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewNotice();
        }

        protected override void LoadData()
        {
            var sql = new StringBuilder();
            sql.Append("SELECT NoticeId, Title, Category, PublishUser, PublishTime, IsTop, ");
            sql.Append("       CASE WHEN IsTop = 1 THEN N'置顶' ELSE N'' END AS TopText, Content ");
            sql.Append("FROM tb_Notice ");

            var conditions = new List<string>();
            var parameters = new List<SqlParameter>();

            string keyword = txtKeyword.Text.Trim();
            string category = FilterValue(cboCategory, "全部");

            if (keyword.Length > 0)
            {
                conditions.Add("(Title LIKE @like OR Content LIKE @like)");
                parameters.Add(DbHelper.Like("@like", keyword));
            }
            if (category.Length > 0)
            {
                conditions.Add("Category = @category");
                parameters.Add(DbHelper.P("@category", category));
            }
            if (conditions.Count > 0)
            {
                sql.Append("WHERE ").Append(string.Join(" AND ", conditions.ToArray())).Append(" ");
            }
            sql.Append("ORDER BY IsTop DESC, PublishTime DESC");

            DataTable table = DbHelper.Query(sql.ToString(), parameters.ToArray());

            Bind(table,
                new GridColumn("NoticeId", "编号", 45, GridAlign.Center),
                new GridColumn("TopText", "置顶", 50, GridAlign.Center),
                new GridColumn("Title", "公告标题", 260),
                new GridColumn("Category", "类别", 60, GridAlign.Center),
                new GridColumn("PublishUser", "发布人", 80, GridAlign.Center),
                new GridColumn("PublishTime", "发布时间", 115, GridAlign.Right, "yyyy-MM-dd HH:mm"));
        }

        protected override void OnDataBound(DataTable data)
        {
            SetFooterSummary("提示：双击一行可查看公告全文");

            // 非管理员隐藏“置顶”列
            if (!Session.IsAdmin && Grid.Columns.Contains("TopText"))
            {
                Grid.Columns["TopText"].Visible = false;
            }
        }

        private void ViewNotice()
        {
            int id = SelectedId("NoticeId");
            if (id == 0)
            {
                Info("请先在列表中选择一条公告。");
                return;
            }

            DataTable table = DbHelper.Query("SELECT * FROM tb_Notice WHERE NoticeId = @id",
                DbHelper.P("@id", id));
            if (table.Rows.Count == 0)
            {
                Warn("该公告已不存在，请刷新后重试。");
                return;
            }
            ShowNotice(table.Rows[0], true);
        }

        private void ShowNotice(DataRow row, bool readOnly)
        {
            string title = Convert.ToString(row["Title"]);
            string category = Value(row, "Category");
            string publisher = Value(row, "PublishUser");
            string publishTime = row["PublishTime"] == DBNull.Value
                ? "—" : Convert.ToDateTime(row["PublishTime"]).ToString("yyyy-MM-dd HH:mm");
            string content = Value(row, "Content");
            bool isTop = row["IsTop"] != DBNull.Value && Convert.ToInt32(row["IsTop"]) == 1;

            var dialog = new EditDialog(readOnly ? "公告详情" : "修改公告", title);
            dialog.AddReadOnly("Meta", "类别 / 发布", category + "　·　" + publisher);
            dialog.AddReadOnly("Time", "发布时间", publishTime + (isTop ? "　（置顶）" : string.Empty));
            dialog.AddReadOnlyText("Content", "公告内容", content, 190);

            var editButton = Ui.NewButton("修改", 0, true);
            if (Session.IsAdmin)
            {
                dialog.AddExtraButton(editButton);
                editButton.Click += delegate
                {
                    int id = Convert.ToInt32(row["NoticeId"]);
                    dialog.DialogResult = DialogResult.Abort;
                    dialog.Close();
                    EditNotice(id);
                };
            }

            dialog.ShowDialog(this);
        }

        // ---- 发布和修改公告 ----

        private void EditNotice(int noticeId)
        {
            DataRow row = null;
            if (noticeId > 0)
            {
                DataTable table = DbHelper.Query("SELECT * FROM tb_Notice WHERE NoticeId = @id",
                    DbHelper.P("@id", noticeId));
                if (table.Rows.Count == 0)
                {
                    Warn("该公告已不存在，请刷新后重试。");
                    return;
                }
                row = table.Rows[0];
            }

            var dialog = new EditDialog(noticeId > 0 ? "修改公告" : "发布公告", "发布后会立即出现在业主的“小区公告”里");
            dialog.AddText("Title", "公告标题", Value(row, "Title"), true);
            dialog.AddCombo("Category", "公告类别", Categories, Value(row, "Category", Categories[0]), true, 130);
            dialog.AddMultiline("Content", "公告内容", Value(row, "Content"), true, 170);
            dialog.AddCombo("IsTop", "是否置顶", new[] { "否", "是" },
                row != null && row["IsTop"] != DBNull.Value && Convert.ToInt32(row["IsTop"]) == 1 ? "是" : "否",
                false, 110);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            Run(delegate
            {
                int isTop = dialog.Value("IsTop") == "是" ? 1 : 0;
                if (noticeId > 0)
                {
                    DbHelper.Execute(
                        "UPDATE tb_Notice SET Title = @title, Category = @category, Content = @content, " +
                        "IsTop = @top WHERE NoticeId = @id",
                        DbHelper.P("@title", dialog.Value("Title")),
                        DbHelper.P("@category", dialog.Value("Category")),
                        DbHelper.P("@content", dialog.Value("Content")),
                        DbHelper.P("@top", isTop),
                        DbHelper.P("@id", noticeId));
                    LogHelper.Write("修改公告", "公告：" + dialog.Value("Title"));
                }
                else
                {
                    DbHelper.Execute(
                        "INSERT INTO tb_Notice (Title, Category, Content, PublishUser, PublishTime, IsTop) " +
                        "VALUES (@title, @category, @content, @user, GETDATE(), @top)",
                        DbHelper.P("@title", dialog.Value("Title")),
                        DbHelper.P("@category", dialog.Value("Category")),
                        DbHelper.P("@content", dialog.Value("Content")),
                        DbHelper.P("@user", Session.LoginName),
                        DbHelper.P("@top", isTop));
                    LogHelper.Write("发布公告", "公告：" + dialog.Value("Title"));
                }
            }, noticeId > 0 ? "公告已更新。" : "公告已发布。");
        }

        private void DeleteNotice()
        {
            int id = SelectedId("NoticeId");
            if (id == 0)
            {
                Info("请先在列表中选择一条公告。");
                return;
            }

            string title = SelectedText("Title");
            if (!Confirm("确定要删除公告“" + title + "”吗？")) return;

            Run(delegate
            {
                DbHelper.Execute("DELETE FROM tb_Notice WHERE NoticeId = @id", DbHelper.P("@id", id));
                LogHelper.Write("删除公告", "公告：" + title);
            }, "公告已删除。");
        }

        protected override void OnDoubleClickRow()
        {
            ViewNotice();
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
