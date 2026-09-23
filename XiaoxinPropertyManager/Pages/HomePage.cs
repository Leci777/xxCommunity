using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 首页：上面几个统计数字，下面功能介绍和最新公告
    public partial class HomePage : UserControl
    {
        private DataTable _featureTable;

        public HomePage()
        {
            InitializeComponent();

            // 设计器拖出来的表格，运行时再统一套一次项目里的表格样式
            Ui.StyleGrid(gridFeature);
            Ui.StyleGrid(gridNotice);

            _featureTable = BuildFeatureTable();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void LoadData()
        {
            // 标题信息
            string communityName = "小鑫小区";
            try
            {
                string name = DbHelper.ScalarString("SELECT TOP 1 CommunityName FROM tb_Community ORDER BY CommunityId");
                if (!string.IsNullOrEmpty(name)) communityName = name;
            }
            catch
            {
                // 数据库没建好就显示默认文字
            }

            DateTime today = DateTime.Now;
            string[] week = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            lblGreeting.Text = "您好，" + Session.DisplayName;
            lblSubtitle.Text = communityName + "　|　今天是 " + today.ToString("yyyy年M月d日")
                + " " + week[(int)today.DayOfWeek]
                + "　|　当前身份：" + Session.Role;

            // 指标卡片
            try
            {
                if (Session.IsAdmin)
                {
                    card1.SetCaption("住户总数"); card1.SetUnit("户");
                    card2.SetCaption("待处理报修"); card2.SetUnit("单");
                    card3.SetCaption("未缴费用"); card3.SetUnit("笔");
                    card4.SetCaption("空闲车位"); card4.SetUnit("个");

                    card1.SetValue(DbHelper.ScalarInt("SELECT COUNT(1) FROM tb_Household").ToString());
                    card2.SetValue(DbHelper.ScalarInt(
                        "SELECT COUNT(1) FROM tb_Repair WHERE Status <> N'已完成'").ToString());
                    card3.SetValue(DbHelper.ScalarInt(
                        "SELECT COUNT(1) FROM tb_Fee WHERE PayStatus = N'未缴'").ToString());
                    card4.SetValue(DbHelper.ScalarInt(
                        "SELECT COUNT(1) FROM tb_Parking WHERE Status = N'空闲'").ToString());
                }
                else
                {
                    int householdId = Session.HouseholdId;

                    card1.SetCaption("我的报修（未完成）"); card1.SetUnit("单");
                    card2.SetCaption("待缴费用合计"); card2.SetUnit("元");
                    card3.SetCaption("我的车位"); card3.SetUnit("个");
                    card4.SetCaption("小区公告"); card4.SetUnit("条");

                    card1.SetValue(DbHelper.ScalarInt(
                        "SELECT COUNT(1) FROM tb_Repair WHERE HouseholdId = @id AND Status <> N'已完成'",
                        DbHelper.P("@id", householdId)).ToString());

                    decimal unpaid = DbHelper.ScalarDecimal(
                        "SELECT ISNULL(SUM(Amount), 0) FROM tb_Fee WHERE HouseholdId = @id AND PayStatus = N'未缴'",
                        DbHelper.P("@id", householdId));
                    card2.SetValue(unpaid.ToString("0.00"));

                    card3.SetValue(DbHelper.ScalarInt(
                        "SELECT COUNT(1) FROM tb_Parking WHERE HouseholdId = @id",
                        DbHelper.P("@id", householdId)).ToString());

                    card4.SetValue(DbHelper.ScalarInt("SELECT COUNT(1) FROM tb_Notice").ToString());
                }
            }
            catch (Exception ex)
            {
                card1.SetValue("-");
                card2.SetValue("-");
                card3.SetValue("-");
                card4.SetValue("-");
                SetNoticeGrid(null);
                Ui.BindGrid(gridFeature, _featureTable,
                    new GridColumn("Feature", "功能", 110),
                    new GridColumn("Summary", "功能简介", 300));
                MessageBox.Show(this, DbHelper.FriendlyMessage(ex), "读取统计数据失败",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Ui.BindGrid(gridFeature, _featureTable,
                new GridColumn("Feature", "功能", 110),
                new GridColumn("Summary", "功能简介", 300));

            try
            {
                DataTable notices = DbHelper.Query(
                    "SELECT TOP 5 Title, Category, PublishTime FROM tb_Notice ORDER BY IsTop DESC, PublishTime DESC");
                SetNoticeGrid(notices);
            }
            catch
            {
                SetNoticeGrid(null);
            }
        }

        private void SetNoticeGrid(DataTable notices)
        {
            Ui.BindGrid(gridNotice,
                notices ?? new DataTable(),
                new GridColumn("Title", "公告标题", 260),
                new GridColumn("PublishTime", "发布时间", 100, GridAlign.Right, "yyyy-MM-dd"));
        }

        private DataTable BuildFeatureTable()
        {
            var table = new DataTable();
            table.Columns.Add("Feature", typeof(string));
            table.Columns.Add("Summary", typeof(string));

            string[][] rows = Session.IsAdmin
                ? new[]
                {
                    new[] { "小区管理", "维护小区基本信息和楼栋资料" },
                    new[] { "住户管理", "登记业主档案、房屋面积与入住信息" },
                    new[] { "公告管理", "发布停水停电、社区活动等通知" },
                    new[] { "报修管理", "受理报修工单，派单并登记完工情况" },
                    new[] { "收费管理", "登记物业费、水电费、停车费等费用并核销" },
                    new[] { "车位管理", "维护车位档案与使用情况" },
                    new[] { "用户管理", "管理管理员与业主的登录账号" },
                    new[] { "反馈管理", "查看业主投诉建议并回复" },
                    new[] { "系统管理", "数据库备份、操作日志与系统信息" }
                }
                : new[]
                {
                    new[] { "我的信息", "查看住户档案，修改联系电话和登录密码" },
                    new[] { "我的报修", "在线提交报修申请，跟踪处理进度" },
                    new[] { "我的费用", "查询物业费、水电费等费用的缴纳情况" },
                    new[] { "我的车位", "查看绑定的车位与车牌信息" },
                    new[] { "投诉建议", "向物业提交投诉或建议并查看回复" },
                    new[] { "小区公告", "查看物业发布的最新公告通知" }
                };

            foreach (string[] row in rows)
            {
                table.Rows.Add(row[0], row[1]);
            }
            return table;
        }
    }
}
