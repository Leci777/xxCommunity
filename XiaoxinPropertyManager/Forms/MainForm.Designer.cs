namespace XiaoxinPropertyManager.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRoleBadge = new System.Windows.Forms.Label();
            this.pnlHeaderRight = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lnkExit = new System.Windows.Forms.LinkLabel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lblNavTitle = new System.Windows.Forms.Label();
            this.navFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.navHome = new XiaoxinPropertyManager.Common.NavItem("首页");
            this.navCommunity = new XiaoxinPropertyManager.Common.NavItem("小区管理");
            this.navHousehold = new XiaoxinPropertyManager.Common.NavItem("住户管理");
            this.navNotice = new XiaoxinPropertyManager.Common.NavItem("公告管理");
            this.navRepair = new XiaoxinPropertyManager.Common.NavItem("报修管理");
            this.navFee = new XiaoxinPropertyManager.Common.NavItem("收费管理");
            this.navParking = new XiaoxinPropertyManager.Common.NavItem("车位管理");
            this.navUser = new XiaoxinPropertyManager.Common.NavItem("用户管理");
            this.navFeedback = new XiaoxinPropertyManager.Common.NavItem("反馈管理");
            this.navSystem = new XiaoxinPropertyManager.Common.NavItem("系统管理");
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatusLeft = new System.Windows.Forms.Label();
            this.lblStatusRight = new System.Windows.Forms.Label();
            this.root.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderRight.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 2;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.pnlHeader, 0, 0);
            this.root.Controls.Add(this.pnlContent, 1, 1);
            this.root.Controls.Add(this.pnlNav, 0, 1);
            this.root.Controls.Add(this.pnlStatus, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Margin = new System.Windows.Forms.Padding(0);
            this.root.Name = "root";
            this.root.RowCount = 3;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.root.Size = new System.Drawing.Size(1220, 750);
            this.root.TabIndex = 0;
            this.root.SetColumnSpan(this.pnlHeader, 2);
            this.root.SetColumnSpan(this.pnlStatus, 2);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblRoleBadge);
            this.pnlHeader.Controls.Add(this.pnlHeaderRight);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1220, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(22, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "小鑫小区物业管理系统";
            // 
            // lblRoleBadge
            // 
            this.lblRoleBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.lblRoleBadge.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoleBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lblRoleBadge.Location = new System.Drawing.Point(260, 22);
            this.lblRoleBadge.Name = "lblRoleBadge";
            this.lblRoleBadge.Size = new System.Drawing.Size(52, 20);
            this.lblRoleBadge.TabIndex = 1;
            this.lblRoleBadge.Text = "管理员端";
            this.lblRoleBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeaderRight
            // 
            this.pnlHeaderRight.AutoSize = true;
            this.pnlHeaderRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeaderRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderRight.Controls.Add(this.lblWelcome);
            this.pnlHeaderRight.Controls.Add(this.lnkLogout);
            this.pnlHeaderRight.Controls.Add(this.lnkExit);
            this.pnlHeaderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHeaderRight.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.pnlHeaderRight.Location = new System.Drawing.Point(948, 0);
            this.pnlHeaderRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeaderRight.Name = "pnlHeaderRight";
            this.pnlHeaderRight.Padding = new System.Windows.Forms.Padding(0, 18, 22, 0);
            this.pnlHeaderRight.Size = new System.Drawing.Size(272, 60);
            this.pnlHeaderRight.TabIndex = 2;
            this.pnlHeaderRight.WrapContents = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblWelcome.Location = new System.Drawing.Point(0, 23);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(0, 5, 12, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(120, 17);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "欢迎您，管理员（管理员）";
            // 
            // lnkLogout
            // 
            this.lnkLogout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.BackColor = System.Drawing.Color.Transparent;
            this.lnkLogout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lnkLogout.Location = new System.Drawing.Point(132, 23);
            this.lnkLogout.Margin = new System.Windows.Forms.Padding(0, 5, 14, 0);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(38, 17);
            this.lnkLogout.TabIndex = 1;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "注销";
            this.lnkLogout.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lnkLogout.Click += new System.EventHandler(this.LnkLogoutClick);
            // 
            // lnkExit
            // 
            this.lnkExit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.lnkExit.AutoSize = true;
            this.lnkExit.BackColor = System.Drawing.Color.Transparent;
            this.lnkExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkExit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkExit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lnkExit.Location = new System.Drawing.Point(184, 23);
            this.lnkExit.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lnkExit.Name = "lnkExit";
            this.lnkExit.Size = new System.Drawing.Size(38, 17);
            this.lnkExit.TabIndex = 2;
            this.lnkExit.TabStop = true;
            this.lnkExit.Text = "退出";
            this.lnkExit.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lnkExit.Click += new System.EventHandler(this.LnkExitClick);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.White;
            this.pnlNav.Controls.Add(this.lblNavTitle);
            this.pnlNav.Controls.Add(this.navFlow);
            this.pnlNav.Controls.Add(this.lblVersion);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNav.Location = new System.Drawing.Point(0, 60);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(190, 660);
            this.pnlNav.TabIndex = 1;            // 
            // lblNavTitle
            // 
            this.lblNavTitle.AutoSize = true;
            this.lblNavTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNavTitle.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblNavTitle.Location = new System.Drawing.Point(22, 18);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(60, 16);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "功能菜单";
            // 
            // navFlow
            // 
            this.navFlow.BackColor = System.Drawing.Color.Transparent;
            this.navFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.navFlow.Location = new System.Drawing.Point(0, 46);
            this.navFlow.Name = "navFlow";
            this.navFlow.Size = new System.Drawing.Size(190, 572);
            this.navFlow.TabIndex = 1;
            this.navFlow.WrapContents = false;
            this.navFlow.Controls.Add(this.navHome);
            this.navFlow.Controls.Add(this.navCommunity);
            this.navFlow.Controls.Add(this.navHousehold);
            this.navFlow.Controls.Add(this.navNotice);
            this.navFlow.Controls.Add(this.navRepair);
            this.navFlow.Controls.Add(this.navFee);
            this.navFlow.Controls.Add(this.navParking);
            this.navFlow.Controls.Add(this.navUser);
            this.navFlow.Controls.Add(this.navFeedback);
            this.navFlow.Controls.Add(this.navSystem);
            // 
            // navHome
            // 
            this.navHome.Location = new System.Drawing.Point(0, 0);
            this.navHome.Margin = new System.Windows.Forms.Padding(0);
            this.navHome.Name = "navHome";
            this.navHome.Size = new System.Drawing.Size(188, 42);
            this.navHome.TabIndex = 10;
            this.navHome.Text = "首页";
            this.navHome.UseVisualStyleBackColor = false;
            // 
            // navCommunity
            // 
            this.navCommunity.Location = new System.Drawing.Point(0, 42);
            this.navCommunity.Margin = new System.Windows.Forms.Padding(0);
            this.navCommunity.Name = "navCommunity";
            this.navCommunity.Size = new System.Drawing.Size(188, 42);
            this.navCommunity.TabIndex = 11;
            this.navCommunity.Text = "小区管理";
            this.navCommunity.UseVisualStyleBackColor = false;
            // 
            // navHousehold
            // 
            this.navHousehold.Location = new System.Drawing.Point(0, 84);
            this.navHousehold.Margin = new System.Windows.Forms.Padding(0);
            this.navHousehold.Name = "navHousehold";
            this.navHousehold.Size = new System.Drawing.Size(188, 42);
            this.navHousehold.TabIndex = 12;
            this.navHousehold.Text = "住户管理";
            this.navHousehold.UseVisualStyleBackColor = false;
            // 
            // navNotice
            // 
            this.navNotice.Location = new System.Drawing.Point(0, 126);
            this.navNotice.Margin = new System.Windows.Forms.Padding(0);
            this.navNotice.Name = "navNotice";
            this.navNotice.Size = new System.Drawing.Size(188, 42);
            this.navNotice.TabIndex = 13;
            this.navNotice.Text = "公告管理";
            this.navNotice.UseVisualStyleBackColor = false;
            // 
            // navRepair
            // 
            this.navRepair.Location = new System.Drawing.Point(0, 168);
            this.navRepair.Margin = new System.Windows.Forms.Padding(0);
            this.navRepair.Name = "navRepair";
            this.navRepair.Size = new System.Drawing.Size(188, 42);
            this.navRepair.TabIndex = 14;
            this.navRepair.Text = "报修管理";
            this.navRepair.UseVisualStyleBackColor = false;
            // 
            // navFee
            // 
            this.navFee.Location = new System.Drawing.Point(0, 210);
            this.navFee.Margin = new System.Windows.Forms.Padding(0);
            this.navFee.Name = "navFee";
            this.navFee.Size = new System.Drawing.Size(188, 42);
            this.navFee.TabIndex = 15;
            this.navFee.Text = "收费管理";
            this.navFee.UseVisualStyleBackColor = false;
            // 
            // navParking
            // 
            this.navParking.Location = new System.Drawing.Point(0, 252);
            this.navParking.Margin = new System.Windows.Forms.Padding(0);
            this.navParking.Name = "navParking";
            this.navParking.Size = new System.Drawing.Size(188, 42);
            this.navParking.TabIndex = 16;
            this.navParking.Text = "车位管理";
            this.navParking.UseVisualStyleBackColor = false;
            // 
            // navUser
            // 
            this.navUser.Location = new System.Drawing.Point(0, 294);
            this.navUser.Margin = new System.Windows.Forms.Padding(0);
            this.navUser.Name = "navUser";
            this.navUser.Size = new System.Drawing.Size(188, 42);
            this.navUser.TabIndex = 17;
            this.navUser.Text = "用户管理";
            this.navUser.UseVisualStyleBackColor = false;
            // 
            // navFeedback
            // 
            this.navFeedback.Location = new System.Drawing.Point(0, 336);
            this.navFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.navFeedback.Name = "navFeedback";
            this.navFeedback.Size = new System.Drawing.Size(188, 42);
            this.navFeedback.TabIndex = 18;
            this.navFeedback.Text = "反馈管理";
            this.navFeedback.UseVisualStyleBackColor = false;
            // 
            // navSystem
            // 
            this.navSystem.Location = new System.Drawing.Point(0, 378);
            this.navSystem.Margin = new System.Windows.Forms.Padding(0);
            this.navSystem.Name = "navSystem";
            this.navSystem.Size = new System.Drawing.Size(188, 42);
            this.navSystem.TabIndex = 19;
            this.navSystem.Text = "系统管理";
            this.navSystem.UseVisualStyleBackColor = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(167)))), ((int)(((byte)(176)))));
            this.lblVersion.Location = new System.Drawing.Point(22, 632);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(53, 16);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "版本 1.0.0";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(190, 60);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1030, 660);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.White;
            this.pnlStatus.Controls.Add(this.lblStatusLeft);
            this.pnlStatus.Controls.Add(this.lblStatusRight);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.Location = new System.Drawing.Point(0, 720);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1220, 30);
            this.pnlStatus.TabIndex = 3;
            // 
            // lblStatusLeft
            // 
            this.lblStatusLeft.AutoSize = true;
            this.lblStatusLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusLeft.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatusLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblStatusLeft.Location = new System.Drawing.Point(16, 8);
            this.lblStatusLeft.Name = "lblStatusLeft";
            this.lblStatusLeft.Size = new System.Drawing.Size(172, 16);
            this.lblStatusLeft.TabIndex = 0;
            this.lblStatusLeft.Text = "登录账号：admin　　身份：管理员";
            // 
            // lblStatusRight
            // 
            this.lblStatusRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusRight.AutoSize = true;
            this.lblStatusRight.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusRight.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatusRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblStatusRight.Location = new System.Drawing.Point(920, 8);
            this.lblStatusRight.Name = "lblStatusRight";
            this.lblStatusRight.Size = new System.Drawing.Size(284, 16);
            this.lblStatusRight.TabIndex = 1;
            this.lblStatusRight.Text = "服务器：.　　数据库：XiaoxinCommunityDB";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1220, 750);
            this.Controls.Add(this.root);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小鑫小区物业管理系统";
            this.root.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHeaderRight.ResumeLayout(false);
            this.pnlHeaderRight.PerformLayout();
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRoleBadge;
        private System.Windows.Forms.FlowLayoutPanel pnlHeaderRight;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.LinkLabel lnkExit;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.FlowLayoutPanel navFlow;
        private XiaoxinPropertyManager.Common.NavItem navHome;
        private XiaoxinPropertyManager.Common.NavItem navCommunity;
        private XiaoxinPropertyManager.Common.NavItem navHousehold;
        private XiaoxinPropertyManager.Common.NavItem navNotice;
        private XiaoxinPropertyManager.Common.NavItem navRepair;
        private XiaoxinPropertyManager.Common.NavItem navFee;
        private XiaoxinPropertyManager.Common.NavItem navParking;
        private XiaoxinPropertyManager.Common.NavItem navUser;
        private XiaoxinPropertyManager.Common.NavItem navFeedback;
        private XiaoxinPropertyManager.Common.NavItem navSystem;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatusLeft;
        private System.Windows.Forms.Label lblStatusRight;
    }
}
