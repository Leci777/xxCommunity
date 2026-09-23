namespace XiaoxinPropertyManager.Forms
{
    partial class LoginForm
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
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.lblBrandEn = new System.Windows.Forms.Label();
            this.pnlBrandLine = new System.Windows.Forms.Panel();
            this.lblFeature1 = new System.Windows.Forms.Label();
            this.lblFeature2 = new System.Windows.Forms.Label();
            this.lblFeature3 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblAccountLogin = new System.Windows.Forms.Label();
            this.lblAccountTip = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoOwner = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lnkDb = new System.Windows.Forms.LinkLabel();
            this.lblDbStatus = new System.Windows.Forms.Label();
            this.lblDemo = new System.Windows.Forms.Label();
            this.root.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 2;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.pnlBrand, 0, 0);
            this.root.Controls.Add(this.pnlForm, 1, 0);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Margin = new System.Windows.Forms.Padding(0);
            this.root.Name = "root";
            this.root.RowCount = 1;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(880, 520);
            this.root.TabIndex = 0;
            // 
            // pnlBrand
            // 
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlBrand.Controls.Add(this.lblBrandName);
            this.pnlBrand.Controls.Add(this.lblBrandTitle);
            this.pnlBrand.Controls.Add(this.lblBrandEn);
            this.pnlBrand.Controls.Add(this.pnlBrandLine);
            this.pnlBrand.Controls.Add(this.lblFeature1);
            this.pnlBrand.Controls.Add(this.lblFeature2);
            this.pnlBrand.Controls.Add(this.lblFeature3);
            this.pnlBrand.Controls.Add(this.lblVersion);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(360, 520);
            this.pnlBrand.TabIndex = 0;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandName.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBrandName.ForeColor = System.Drawing.Color.White;
            this.lblBrandName.Location = new System.Drawing.Point(40, 158);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(156, 45);
            this.lblBrandName.TabIndex = 0;
            this.lblBrandName.Text = "小鑫小区";
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.AutoSize = true;
            this.lblBrandTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandTitle.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBrandTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(228)))));
            this.lblBrandTitle.Location = new System.Drawing.Point(43, 206);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(145, 30);
            this.lblBrandTitle.TabIndex = 1;
            this.lblBrandTitle.Text = "物业管理系统";
            // 
            // lblBrandEn
            // 
            this.lblBrandEn.AutoSize = true;
            this.lblBrandEn.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandEn.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBrandEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.lblBrandEn.Location = new System.Drawing.Point(45, 240);
            this.lblBrandEn.Name = "lblBrandEn";
            this.lblBrandEn.Size = new System.Drawing.Size(230, 19);
            this.lblBrandEn.TabIndex = 2;
            this.lblBrandEn.Text = "PROPERTY MANAGEMENT SYSTEM";
            // 
            // pnlBrandLine
            // 
            this.pnlBrandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.pnlBrandLine.Location = new System.Drawing.Point(40, 274);
            this.pnlBrandLine.Name = "pnlBrandLine";
            this.pnlBrandLine.Size = new System.Drawing.Size(56, 2);
            this.pnlBrandLine.TabIndex = 3;
            // 
            // lblFeature1
            // 
            this.lblFeature1.AutoSize = true;
            this.lblFeature1.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFeature1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            this.lblFeature1.Location = new System.Drawing.Point(43, 300);
            this.lblFeature1.Name = "lblFeature1";
            this.lblFeature1.Size = new System.Drawing.Size(141, 20);
            this.lblFeature1.TabIndex = 4;
            this.lblFeature1.Text = "住户档案 · 报修工单";
            // 
            // lblFeature2
            // 
            this.lblFeature2.AutoSize = true;
            this.lblFeature2.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFeature2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            this.lblFeature2.Location = new System.Drawing.Point(43, 328);
            this.lblFeature2.Name = "lblFeature2";
            this.lblFeature2.Size = new System.Drawing.Size(141, 20);
            this.lblFeature2.TabIndex = 5;
            this.lblFeature2.Text = "收费管理 · 车位分配";
            // 
            // lblFeature3
            // 
            this.lblFeature3.AutoSize = true;
            this.lblFeature3.BackColor = System.Drawing.Color.Transparent;
            this.lblFeature3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFeature3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(181)))), ((int)(((byte)(197)))));
            this.lblFeature3.Location = new System.Drawing.Point(43, 356);
            this.lblFeature3.Name = "lblFeature3";
            this.lblFeature3.Size = new System.Drawing.Size(141, 20);
            this.lblFeature3.TabIndex = 6;
            this.lblFeature3.Text = "公告通知 · 投诉建议";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.lblVersion.Location = new System.Drawing.Point(43, 440);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(178, 40);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "版本 1.0.0\r\n服务热线 888-88888888";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.lblAccountLogin);
            this.pnlForm.Controls.Add(this.lblAccountTip);
            this.pnlForm.Controls.Add(this.lblUser);
            this.pnlForm.Controls.Add(this.txtUser);
            this.pnlForm.Controls.Add(this.lblPwd);
            this.pnlForm.Controls.Add(this.txtPwd);
            this.pnlForm.Controls.Add(this.lblRole);
            this.pnlForm.Controls.Add(this.rdoAdmin);
            this.pnlForm.Controls.Add(this.rdoOwner);
            this.pnlForm.Controls.Add(this.btnLogin);
            this.pnlForm.Controls.Add(this.lnkRegister);
            this.pnlForm.Controls.Add(this.lnkDb);
            this.pnlForm.Controls.Add(this.lblDbStatus);
            this.pnlForm.Controls.Add(this.lblDemo);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(360, 0);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(520, 520);
            this.pnlForm.TabIndex = 1;
            // 
            // lblAccountLogin
            // 
            this.lblAccountLogin.AutoSize = true;
            this.lblAccountLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountLogin.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAccountLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblAccountLogin.Location = new System.Drawing.Point(68, 92);
            this.lblAccountLogin.Name = "lblAccountLogin";
            this.lblAccountLogin.Size = new System.Drawing.Size(92, 27);
            this.lblAccountLogin.TabIndex = 0;
            this.lblAccountLogin.Text = "账号登录";
            // 
            // lblAccountTip
            // 
            this.lblAccountTip.AutoSize = true;
            this.lblAccountTip.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountTip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAccountTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblAccountTip.Location = new System.Drawing.Point(70, 126);
            this.lblAccountTip.Name = "lblAccountTip";
            this.lblAccountTip.Size = new System.Drawing.Size(159, 20);
            this.lblAccountTip.TabIndex = 1;
            this.lblAccountTip.Text = "请输入登录账号和密码";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblUser.Location = new System.Drawing.Point(70, 168);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "登录账号";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtUser.Location = new System.Drawing.Point(70, 190);
            this.txtUser.MaxLength = 50;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(380, 27);
            this.txtUser.TabIndex = 0;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblPwd.Location = new System.Drawing.Point(70, 232);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(69, 20);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "登录密码";
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtPwd.Location = new System.Drawing.Point(70, 254);
            this.txtPwd.MaxLength = 30;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(380, 27);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblRole.Location = new System.Drawing.Point(70, 296);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(69, 20);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "登录身份";
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rdoAdmin.Checked = true;
            this.rdoAdmin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.rdoAdmin.Location = new System.Drawing.Point(70, 320);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(75, 24);
            this.rdoAdmin.TabIndex = 2;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "管理员";
            this.rdoAdmin.UseVisualStyleBackColor = false;
            // 
            // rdoOwner
            // 
            this.rdoOwner.AutoSize = true;
            this.rdoOwner.BackColor = System.Drawing.Color.Transparent;
            this.rdoOwner.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.rdoOwner.Location = new System.Drawing.Point(170, 320);
            this.rdoOwner.Name = "rdoOwner";
            this.rdoOwner.Size = new System.Drawing.Size(60, 24);
            this.rdoOwner.TabIndex = 3;
            this.rdoOwner.Text = "业主";
            this.rdoOwner.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(70, 364);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(380, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登 录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
            // 
            // lnkRegister
            // 
            this.lnkRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.BackColor = System.Drawing.Color.Transparent;
            this.lnkRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lnkRegister.Location = new System.Drawing.Point(70, 416);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(99, 20);
            this.lnkRegister.TabIndex = 5;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "注册业主账号";
            this.lnkRegister.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lnkRegister.Click += new System.EventHandler(this.LnkRegisterClick);
            // 
            // lnkDb
            // 
            this.lnkDb.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.lnkDb.AutoSize = true;
            this.lnkDb.BackColor = System.Drawing.Color.Transparent;
            this.lnkDb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkDb.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkDb.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lnkDb.Location = new System.Drawing.Point(186, 416);
            this.lnkDb.Name = "lnkDb";
            this.lnkDb.Size = new System.Drawing.Size(84, 20);
            this.lnkDb.TabIndex = 6;
            this.lnkDb.TabStop = true;
            this.lnkDb.Text = "数据库设置";
            this.lnkDb.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lnkDb.Click += new System.EventHandler(this.LnkDbClick);
            // 
            // lblDbStatus
            // 
            this.lblDbStatus.AutoSize = true;
            this.lblDbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblDbStatus.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblDbStatus.Location = new System.Drawing.Point(70, 452);
            this.lblDbStatus.Name = "lblDbStatus";
            this.lblDbStatus.Size = new System.Drawing.Size(156, 20);
            this.lblDbStatus.TabIndex = 7;
            this.lblDbStatus.Text = "正在检查数据库连接…";
            // 
            // lblDemo
            // 
            this.lblDemo.AutoSize = true;
            this.lblDemo.BackColor = System.Drawing.Color.Transparent;
            this.lblDemo.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblDemo.Location = new System.Drawing.Point(16, 476);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(420, 20);
            this.lblDemo.TabIndex = 8;
            this.lblDemo.Text = "管理员 admin / admin123　　业主 13800000001 / 123456";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 520);
            this.Controls.Add(this.root);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小鑫小区物业管理系统 - 登录";
            this.root.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandEn;
        private System.Windows.Forms.Panel pnlBrandLine;
        private System.Windows.Forms.Label lblFeature1;
        private System.Windows.Forms.Label lblFeature2;
        private System.Windows.Forms.Label lblFeature3;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblAccountLogin;
        private System.Windows.Forms.Label lblAccountTip;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.RadioButton rdoOwner;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.LinkLabel lnkDb;
        private System.Windows.Forms.Label lblDbStatus;
        private System.Windows.Forms.Label lblDemo;
    }
}
