using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;
using XiaoxinPropertyManager.Pages;

namespace XiaoxinPropertyManager.Forms
{
    // 主窗口：上面信息栏，左边菜单，中间内容，底下状态栏
    public partial class MainForm : Form
    {
        private readonly List<NavEntry> _entries = new List<NavEntry>();
        private UserControl _currentPage;

        // 点了注销就是 true，Program 里会重新弹登录窗口
        public bool LogoutRequested { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            BindHeaderText();
            WireEvents();
            BuildNavItems();

            if (_entries.Count > 0)
            {
                SelectEntry(_entries[0]);
            }
        }

        private void BindHeaderText()
        {
            lblRoleBadge.Text = Session.IsAdmin ? "管理员端" : "业主端";
            lblWelcome.Text = "欢迎您，" + Session.DisplayName + "（" + Session.Role + "）";
            lblStatusLeft.Text = "登录账号：" + Session.LoginName + "　　身份：" + Session.Role;
            lblStatusRight.Text = "服务器：" + DbHelper.ServerName + "　　数据库：" + DbHelper.DatabaseName;
        }

        private void WireEvents()
        {
            pnlHeader.Paint += HeaderPaint;
            pnlNav.Paint += NavPaint;
            pnlStatus.Paint += StatusPaint;

            // 菜单区高度随窗口变，在 Resize 里重算一次
            pnlNav.Resize += delegate
            {
                navFlow.Size = new Size(pnlNav.Width, pnlNav.Height - 46 - 42);
                lblVersion.Top = pnlNav.Height - 28;
                foreach (var entry in _entries)
                {
                    entry.Item.Width = navFlow.Width - 2;
                }
            };

            pnlStatus.Resize += delegate
            {
                lblStatusRight.Left = pnlStatus.Width - lblStatusRight.Width - 16;
            };
        }

        private void HeaderPaint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(UiTheme.Border))
            {
                e.Graphics.DrawLine(pen, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1);
            }
        }

        private void NavPaint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(UiTheme.Border))
            {
                e.Graphics.DrawLine(pen, pnlNav.Width - 1, 0, pnlNav.Width - 1, pnlNav.Height);
            }
        }

        private void StatusPaint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(UiTheme.Border))
            {
                e.Graphics.DrawLine(pen, 0, 0, pnlStatus.Width, 0);
            }
        }

        private void BuildNavItems()
        {
            // 设计器里铺的是管理员菜单的占位，运行时按登录身份重建一遍
            navFlow.Controls.Clear();

            if (Session.IsAdmin)
            {
                AddNav("首页", delegate { return new HomePage(); });
                AddNav("小区管理", delegate { return new CommunityPage(); });
                AddNav("住户管理", delegate { return new HouseholdPage(); });
                AddNav("公告管理", delegate { return new NoticePage(); });
                AddNav("报修管理", delegate { return new RepairPage(); });
                AddNav("收费管理", delegate { return new FeePage(); });
                AddNav("车位管理", delegate { return new ParkingPage(); });
                AddNav("用户管理", delegate { return new UserPage(); });
                AddNav("反馈管理", delegate { return new FeedbackPage(); });
                AddNav("系统管理", delegate { return new SystemPage(); });
            }
            else
            {
                AddNav("首页", delegate { return new HomePage(); });
                AddNav("我的信息", delegate { return new OwnerInfoPage(); });
                AddNav("我的报修", delegate { return new RepairPage(); });
                AddNav("我的费用", delegate { return new FeePage(); });
                AddNav("我的车位", delegate { return new ParkingPage(); });
                AddNav("投诉建议", delegate { return new FeedbackPage(); });
                AddNav("小区公告", delegate { return new NoticePage(); });
            }
        }

        private void AddNav(string text, Func<UserControl> factory)
        {
            var item = new NavItem(text);
            item.Width = navFlow.Width - 2;
            int index = _entries.Count;
            item.Click += delegate { SelectEntry(_entries[index]); };

            var entry = new NavEntry { Item = item, Factory = factory };
            _entries.Add(entry);
            navFlow.Controls.Add(item);
        }

        private void SelectEntry(NavEntry entry)
        {
            foreach (var e in _entries)
            {
                e.Item.Selected = e == entry;
            }

            try
            {
                var page = entry.Factory();
                if (_currentPage != null)
                {
                    pnlContent.Controls.Remove(_currentPage);
                    _currentPage.Dispose();
                }
                _currentPage = page;
                page.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(page);

                var module = page as ModulePage;
                if (module != null) module.Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, DbHelper.FriendlyMessage(ex), "打开功能页面失败",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkLogoutClick(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定要注销当前账号吗？", "注销",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            LogoutRequested = true;
            Close();
        }

        private void LnkExitClick(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定要退出系统吗？", "退出",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            LogoutRequested = false;
            Close();
        }

        private class NavEntry
        {
            public NavItem Item;
            public Func<UserControl> Factory;
        }
    }
}
