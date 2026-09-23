namespace XiaoxinPropertyManager.Pages
{
    partial class SystemPage
    {
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.Toolbar = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.TableLayoutPanel();
            this.cardInfo = new XiaoxinPropertyManager.Common.CardPanel();
            this.capLblServer = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.capLblDatabase = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.capLblConnection = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.capLblTables = new System.Windows.Forms.Label();
            this.lblTables = new System.Windows.Forms.Label();
            this.capLblVersion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.capLblUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.capLblRole = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.capLblBackup = new System.Windows.Forms.Label();
            this.lblBackup = new System.Windows.Forms.Label();
            this.lblBackupStatus = new System.Windows.Forms.Label();
            this.cardGrid = new XiaoxinPropertyManager.Common.CardPanel();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.LogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new XiaoxinPropertyManager.Common.FooterPanel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.FooterRight = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.Body.SuspendLayout();
            this.cardInfo.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.pnlRoot.ColumnCount = 1;
            this.pnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRoot.Controls.Add(this.pnlHeader, 0, 0);
            this.pnlRoot.Controls.Add(this.Toolbar, 0, 1);
            this.pnlRoot.Controls.Add(this.Body, 0, 2);
            this.pnlRoot.Controls.Add(this.pnlFooter, 0, 3);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.RowCount = 4;
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.pnlRoot.Size = new System.Drawing.Size(1030, 660);
            this.pnlRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblPageDescription);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1030, 64);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblPageTitle.Location = new System.Drawing.Point(24, 14);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(92, 27);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "系统管理";
            // 
            // lblPageDescription
            // 
            this.lblPageDescription.AutoSize = true;
            this.lblPageDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblPageDescription.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPageDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblPageDescription.Location = new System.Drawing.Point(25, 41);
            this.lblPageDescription.Name = "lblPageDescription";
            this.lblPageDescription.Size = new System.Drawing.Size(234, 20);
            this.lblPageDescription.TabIndex = 1;
            this.lblPageDescription.Text = "数据库备份、操作日志与系统信息";
            // 
            // Toolbar
            // 
            this.Toolbar.BackColor = System.Drawing.Color.White;
            this.Toolbar.Controls.Add(this.btnBackup);
            this.Toolbar.Controls.Add(this.btnRefresh);
            this.Toolbar.Controls.Add(this.btnClear);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar.Location = new System.Drawing.Point(0, 64);
            this.Toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(1030, 50);
            this.Toolbar.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(24, 12);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(110, 26);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "备份数据库";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btnRefresh.Location = new System.Drawing.Point(144, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(62)))), ((int)(((byte)(51)))));
            this.btnClear.Location = new System.Drawing.Point(228, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空日志";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Body.ColumnCount = 1;
            this.Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Body.Controls.Add(this.cardInfo, 0, 0);
            this.Body.Controls.Add(this.cardGrid, 0, 1);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 114);
            this.Body.Margin = new System.Windows.Forms.Padding(0);
            this.Body.Name = "Body";
            this.Body.Padding = new System.Windows.Forms.Padding(24, 14, 24, 0);
            this.Body.RowCount = 2;
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Body.Size = new System.Drawing.Size(1030, 508);
            this.Body.TabIndex = 0;
            // 
            // cardInfo
            // 
            this.cardInfo.BackColor = System.Drawing.Color.White;
            this.cardInfo.Caption = "系统信息";
            this.cardInfo.Controls.Add(this.capLblServer);
            this.cardInfo.Controls.Add(this.lblServer);
            this.cardInfo.Controls.Add(this.capLblDatabase);
            this.cardInfo.Controls.Add(this.lblDatabase);
            this.cardInfo.Controls.Add(this.capLblConnection);
            this.cardInfo.Controls.Add(this.lblConnection);
            this.cardInfo.Controls.Add(this.capLblTables);
            this.cardInfo.Controls.Add(this.lblTables);
            this.cardInfo.Controls.Add(this.capLblVersion);
            this.cardInfo.Controls.Add(this.lblVersion);
            this.cardInfo.Controls.Add(this.capLblUser);
            this.cardInfo.Controls.Add(this.lblUser);
            this.cardInfo.Controls.Add(this.capLblRole);
            this.cardInfo.Controls.Add(this.lblRole);
            this.cardInfo.Controls.Add(this.capLblBackup);
            this.cardInfo.Controls.Add(this.lblBackup);
            this.cardInfo.Controls.Add(this.lblBackupStatus);
            this.cardInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardInfo.Location = new System.Drawing.Point(24, 14);
            this.cardInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.cardInfo.Name = "cardInfo";
            this.cardInfo.Padding = new System.Windows.Forms.Padding(1);
            this.cardInfo.Size = new System.Drawing.Size(982, 210);
            this.cardInfo.TabIndex = 0;
            // 
            // capLblServer
            // 
            this.capLblServer.BackColor = System.Drawing.Color.Transparent;
            this.capLblServer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblServer.Location = new System.Drawing.Point(20, 46);
            this.capLblServer.Name = "capLblServer";
            this.capLblServer.Size = new System.Drawing.Size(88, 22);
            this.capLblServer.TabIndex = 0;
            this.capLblServer.Text = "服务器地址";
            this.capLblServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.Color.Transparent;
            this.lblServer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblServer.Location = new System.Drawing.Point(114, 49);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(25, 20);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "—";
            // 
            // capLblDatabase
            // 
            this.capLblDatabase.BackColor = System.Drawing.Color.Transparent;
            this.capLblDatabase.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblDatabase.Location = new System.Drawing.Point(20, 76);
            this.capLblDatabase.Name = "capLblDatabase";
            this.capLblDatabase.Size = new System.Drawing.Size(88, 22);
            this.capLblDatabase.TabIndex = 0;
            this.capLblDatabase.Text = "数据库名称";
            this.capLblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabase.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblDatabase.Location = new System.Drawing.Point(114, 79);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(25, 20);
            this.lblDatabase.TabIndex = 0;
            this.lblDatabase.Text = "—";
            // 
            // capLblConnection
            // 
            this.capLblConnection.BackColor = System.Drawing.Color.Transparent;
            this.capLblConnection.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblConnection.Location = new System.Drawing.Point(20, 106);
            this.capLblConnection.Name = "capLblConnection";
            this.capLblConnection.Size = new System.Drawing.Size(72, 22);
            this.capLblConnection.TabIndex = 0;
            this.capLblConnection.Text = "连接状态";
            this.capLblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.BackColor = System.Drawing.Color.Transparent;
            this.lblConnection.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblConnection.Location = new System.Drawing.Point(98, 109);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(25, 20);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "—";
            // 
            // capLblTables
            // 
            this.capLblTables.BackColor = System.Drawing.Color.Transparent;
            this.capLblTables.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblTables.Location = new System.Drawing.Point(20, 136);
            this.capLblTables.Name = "capLblTables";
            this.capLblTables.Size = new System.Drawing.Size(88, 22);
            this.capLblTables.TabIndex = 0;
            this.capLblTables.Text = "数据表数量";
            this.capLblTables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.BackColor = System.Drawing.Color.Transparent;
            this.lblTables.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblTables.Location = new System.Drawing.Point(114, 139);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(25, 20);
            this.lblTables.TabIndex = 0;
            this.lblTables.Text = "—";
            // 
            // capLblVersion
            // 
            this.capLblVersion.BackColor = System.Drawing.Color.Transparent;
            this.capLblVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblVersion.Location = new System.Drawing.Point(20, 166);
            this.capLblVersion.Name = "capLblVersion";
            this.capLblVersion.Size = new System.Drawing.Size(72, 22);
            this.capLblVersion.TabIndex = 0;
            this.capLblVersion.Text = "程序版本";
            this.capLblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblVersion.Location = new System.Drawing.Point(98, 169);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(25, 20);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "—";
            // 
            // capLblUser
            // 
            this.capLblUser.BackColor = System.Drawing.Color.Transparent;
            this.capLblUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblUser.Location = new System.Drawing.Point(350, 46);
            this.capLblUser.Name = "capLblUser";
            this.capLblUser.Size = new System.Drawing.Size(104, 22);
            this.capLblUser.TabIndex = 0;
            this.capLblUser.Text = "当前登录用户";
            this.capLblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblUser.Location = new System.Drawing.Point(460, 49);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(25, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "—";
            // 
            // capLblRole
            // 
            this.capLblRole.BackColor = System.Drawing.Color.Transparent;
            this.capLblRole.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblRole.Location = new System.Drawing.Point(350, 76);
            this.capLblRole.Name = "capLblRole";
            this.capLblRole.Size = new System.Drawing.Size(72, 22);
            this.capLblRole.TabIndex = 0;
            this.capLblRole.Text = "登录身份";
            this.capLblRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblRole.Location = new System.Drawing.Point(428, 79);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(25, 20);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "—";
            // 
            // capLblBackup
            // 
            this.capLblBackup.BackColor = System.Drawing.Color.Transparent;
            this.capLblBackup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblBackup.Location = new System.Drawing.Point(350, 106);
            this.capLblBackup.Name = "capLblBackup";
            this.capLblBackup.Size = new System.Drawing.Size(104, 22);
            this.capLblBackup.TabIndex = 0;
            this.capLblBackup.Text = "最近备份文件";
            this.capLblBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.BackColor = System.Drawing.Color.Transparent;
            this.lblBackup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblBackup.Location = new System.Drawing.Point(460, 109);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(25, 20);
            this.lblBackup.TabIndex = 0;
            this.lblBackup.Text = "—";
            // 
            // lblBackupStatus
            // 
            this.lblBackupStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblBackupStatus.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBackupStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblBackupStatus.Location = new System.Drawing.Point(350, 140);
            this.lblBackupStatus.Name = "lblBackupStatus";
            this.lblBackupStatus.Size = new System.Drawing.Size(420, 40);
            this.lblBackupStatus.TabIndex = 0;
            // 
            // cardGrid
            // 
            this.cardGrid.BackColor = System.Drawing.Color.White;
            this.cardGrid.Caption = "操作日志";
            this.cardGrid.Controls.Add(this.gridMain);
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Location = new System.Drawing.Point(24, 236);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(0);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(1, 44, 1, 1);
            this.cardGrid.Size = new System.Drawing.Size(982, 272);
            this.cardGrid.TabIndex = 1;
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            this.gridMain.AllowUserToDeleteRows = false;
            this.gridMain.AllowUserToResizeRows = false;
            this.gridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMain.BackgroundColor = System.Drawing.Color.White;
            this.gridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMain.ColumnHeadersHeight = 36;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogId,
            this.UserName,
            this.Action,
            this.Detail,
            this.LogTime});
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.gridMain.Location = new System.Drawing.Point(1, 44);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.ReadOnly = true;
            this.gridMain.RowHeadersVisible = false;
            this.gridMain.RowHeadersWidth = 51;
            this.gridMain.RowTemplate.Height = 30;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(980, 227);
            this.gridMain.TabIndex = 0;
            // 
            // LogId
            // 
            this.LogId.DataPropertyName = "LogId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LogId.DefaultCellStyle = dataGridViewCellStyle2;
            this.LogId.FillWeight = 45F;
            this.LogId.HeaderText = "序号";
            this.LogId.MinimumWidth = 60;
            this.LogId.Name = "LogId";
            this.LogId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.FillWeight = 110F;
            this.UserName.HeaderText = "操作账号";
            this.UserName.MinimumWidth = 60;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Action";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Action.DefaultCellStyle = dataGridViewCellStyle3;
            this.Action.FillWeight = 90F;
            this.Action.HeaderText = "操作类型";
            this.Action.MinimumWidth = 60;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            this.Detail.FillWeight = 380F;
            this.Detail.HeaderText = "操作内容";
            this.Detail.MinimumWidth = 60;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // LogTime
            // 
            this.LogTime.DataPropertyName = "LogTime";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.LogTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.LogTime.FillWeight = 130F;
            this.LogTime.HeaderText = "操作时间";
            this.LogTime.MinimumWidth = 60;
            this.LogTime.Name = "LogTime";
            this.LogTime.ReadOnly = true;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.StatusLabel);
            this.pnlFooter.Controls.Add(this.FooterRight);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(0, 622);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1030, 38);
            this.pnlFooter.TabIndex = 3;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.StatusLabel.Location = new System.Drawing.Point(24, 11);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 20);
            this.StatusLabel.TabIndex = 0;
            // 
            // FooterRight
            // 
            this.FooterRight.BackColor = System.Drawing.Color.Transparent;
            this.FooterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.FooterRight.Location = new System.Drawing.Point(1006, 0);
            this.FooterRight.Name = "FooterRight";
            this.FooterRight.Padding = new System.Windows.Forms.Padding(0, 11, 24, 0);
            this.FooterRight.Size = new System.Drawing.Size(24, 38);
            this.FooterRight.TabIndex = 1;
            this.FooterRight.WrapContents = false;
            // 
            // SystemPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "SystemPage";
            this.Size = new System.Drawing.Size(1030, 660);
            this.pnlRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.Toolbar.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.cardInfo.ResumeLayout(false);
            this.cardInfo.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            this.cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel pnlRoot;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageDescription;
        private System.Windows.Forms.Panel Toolbar;
        private System.Windows.Forms.TableLayoutPanel Body;
        private XiaoxinPropertyManager.Common.FooterPanel pnlFooter;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.FlowLayoutPanel FooterRight;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private XiaoxinPropertyManager.Common.CardPanel cardInfo;
        private System.Windows.Forms.Label capLblServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label capLblDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label capLblConnection;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label capLblTables;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.Label capLblVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label capLblUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label capLblRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label capLblBackup;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.Label lblBackupStatus;
        private XiaoxinPropertyManager.Common.CardPanel cardGrid;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogTime;
    }
}
