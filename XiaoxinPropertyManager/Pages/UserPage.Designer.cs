namespace XiaoxinPropertyManager.Pages
{
    partial class UserPage
    {
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.Toolbar = new System.Windows.Forms.Panel();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.Toolbar2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnResetPwd = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new XiaoxinPropertyManager.Common.CardPanel();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseholdText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new XiaoxinPropertyManager.Common.FooterPanel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.FooterRight = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.Toolbar2.SuspendLayout();
            this.Body.SuspendLayout();
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
            this.pnlRoot.Controls.Add(this.Toolbar2, 0, 2);
            this.pnlRoot.Controls.Add(this.Body, 0, 3);
            this.pnlRoot.Controls.Add(this.pnlFooter, 0, 4);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.RowCount = 5;
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
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
            this.lblPageTitle.Text = "用户管理";
            // 
            // lblPageDescription
            // 
            this.lblPageDescription.AutoSize = true;
            this.lblPageDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblPageDescription.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPageDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblPageDescription.Location = new System.Drawing.Point(25, 41);
            this.lblPageDescription.Name = "lblPageDescription";
            this.lblPageDescription.Size = new System.Drawing.Size(204, 20);
            this.lblPageDescription.TabIndex = 1;
            this.lblPageDescription.Text = "管理管理员与业主的登录账号";
            // 
            // Toolbar
            // 
            this.Toolbar.BackColor = System.Drawing.Color.White;
            this.Toolbar.Controls.Add(this.lblKeyword);
            this.Toolbar.Controls.Add(this.txtKeyword);
            this.Toolbar.Controls.Add(this.lblRole);
            this.Toolbar.Controls.Add(this.cboRole);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar.Location = new System.Drawing.Point(0, 64);
            this.Toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(1030, 50);
            this.Toolbar.TabIndex = 1;
            // 
            // lblKeyword
            // 
            this.lblKeyword.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblKeyword.Location = new System.Drawing.Point(24, 12);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(56, 25);
            this.lblKeyword.TabIndex = 1;
            this.lblKeyword.Text = "搜索";
            this.lblKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKeyword
            // 
            this.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKeyword.Location = new System.Drawing.Point(86, 12);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(150, 27);
            this.txtKeyword.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblRole.Location = new System.Drawing.Point(252, 12);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(40, 25);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "身份";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRole
            // 
            this.cboRole.BackColor = System.Drawing.Color.White;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRole.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "全部",
            "管理员",
            "业主"});
            this.cboRole.Location = new System.Drawing.Point(298, 12);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(100, 28);
            this.cboRole.TabIndex = 1;
            // 
            // Toolbar2
            // 
            this.Toolbar2.BackColor = System.Drawing.Color.White;
            this.Toolbar2.Controls.Add(this.btnSearch);
            this.Toolbar2.Controls.Add(this.btnReset);
            this.Toolbar2.Controls.Add(this.btnAdd);
            this.Toolbar2.Controls.Add(this.btnEdit);
            this.Toolbar2.Controls.Add(this.btnResetPwd);
            this.Toolbar2.Controls.Add(this.btnToggle);
            this.Toolbar2.Controls.Add(this.btnDelete);
            this.Toolbar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar2.Location = new System.Drawing.Point(0, 114);
            this.Toolbar2.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar2.Name = "Toolbar2";
            this.Toolbar2.Size = new System.Drawing.Size(1030, 44);
            this.Toolbar2.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(24, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btnReset.Location = new System.Drawing.Point(108, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 31);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(204, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增账号";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btnEdit.Location = new System.Drawing.Point(308, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 31);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.BackColor = System.Drawing.Color.White;
            this.btnResetPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPwd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnResetPwd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnResetPwd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnResetPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResetPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btnResetPwd.Location = new System.Drawing.Point(392, 8);
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.Size = new System.Drawing.Size(98, 31);
            this.btnResetPwd.TabIndex = 1;
            this.btnResetPwd.Text = "重置密码";
            this.btnResetPwd.UseVisualStyleBackColor = false;
            this.btnResetPwd.Click += new System.EventHandler(this.btnResetPwd_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.White;
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btnToggle.Location = new System.Drawing.Point(496, 8);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(106, 31);
            this.btnToggle.TabIndex = 1;
            this.btnToggle.Text = "启用/停用";
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(62)))), ((int)(((byte)(51)))));
            this.btnDelete.Location = new System.Drawing.Point(608, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Body.ColumnCount = 1;
            this.Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Body.Controls.Add(this.cardGrid, 0, 0);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 158);
            this.Body.Margin = new System.Windows.Forms.Padding(0);
            this.Body.Name = "Body";
            this.Body.Padding = new System.Windows.Forms.Padding(24, 14, 24, 0);
            this.Body.RowCount = 1;
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Body.Size = new System.Drawing.Size(1030, 464);
            this.Body.TabIndex = 0;
            // 
            // cardGrid
            // 
            this.cardGrid.BackColor = System.Drawing.Color.White;
            this.cardGrid.Caption = "";
            this.cardGrid.Controls.Add(this.gridMain);
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Location = new System.Drawing.Point(24, 14);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(0);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(1);
            this.cardGrid.Size = new System.Drawing.Size(982, 450);
            this.cardGrid.TabIndex = 0;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridMain.ColumnHeadersHeight = 36;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.LoginName,
            this.RealName,
            this.Phone,
            this.Email,
            this.Role,
            this.HouseholdText,
            this.StateText,
            this.CreateTime});
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.EnableHeadersVisualStyles = false;
            this.gridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.gridMain.Location = new System.Drawing.Point(1, 1);
            this.gridMain.MultiSelect = false;
            this.gridMain.Name = "gridMain";
            this.gridMain.ReadOnly = true;
            this.gridMain.RowHeadersVisible = false;
            this.gridMain.RowHeadersWidth = 51;
            this.gridMain.RowTemplate.Height = 30;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(980, 448);
            this.gridMain.TabIndex = 0;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UserId.DefaultCellStyle = dataGridViewCellStyle7;
            this.UserId.FillWeight = 45F;
            this.UserId.HeaderText = "编号";
            this.UserId.MinimumWidth = 60;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.FillWeight = 105F;
            this.LoginName.HeaderText = "登录账号";
            this.LoginName.MinimumWidth = 60;
            this.LoginName.Name = "LoginName";
            this.LoginName.ReadOnly = true;
            // 
            // RealName
            // 
            this.RealName.DataPropertyName = "RealName";
            this.RealName.FillWeight = 70F;
            this.RealName.HeaderText = "姓名";
            this.RealName.MinimumWidth = 60;
            this.RealName.Name = "RealName";
            this.RealName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 90F;
            this.Phone.HeaderText = "手机号";
            this.Phone.MinimumWidth = 60;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 150F;
            this.Email.HeaderText = "邮箱";
            this.Email.MinimumWidth = 60;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Role.DefaultCellStyle = dataGridViewCellStyle8;
            this.Role.FillWeight = 60F;
            this.Role.HeaderText = "身份";
            this.Role.MinimumWidth = 60;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // HouseholdText
            // 
            this.HouseholdText.DataPropertyName = "HouseholdText";
            this.HouseholdText.FillWeight = 150F;
            this.HouseholdText.HeaderText = "关联住户";
            this.HouseholdText.MinimumWidth = 60;
            this.HouseholdText.Name = "HouseholdText";
            this.HouseholdText.ReadOnly = true;
            // 
            // StateText
            // 
            this.StateText.DataPropertyName = "StateText";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StateText.DefaultCellStyle = dataGridViewCellStyle9;
            this.StateText.FillWeight = 55F;
            this.StateText.HeaderText = "状态";
            this.StateText.MinimumWidth = 60;
            this.StateText.Name = "StateText";
            this.StateText.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CreateTime.DefaultCellStyle = dataGridViewCellStyle10;
            this.CreateTime.FillWeight = 95F;
            this.CreateTime.HeaderText = "注册时间";
            this.CreateTime.MinimumWidth = 60;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
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
            // UserPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UserPage";
            this.Size = new System.Drawing.Size(1030, 660);
            this.pnlRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.Toolbar2.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.cardGrid.ResumeLayout(false);
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
        private System.Windows.Forms.Panel Toolbar2;
        private System.Windows.Forms.TableLayoutPanel Body;
        private XiaoxinPropertyManager.Common.FooterPanel pnlFooter;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.FlowLayoutPanel FooterRight;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnResetPwd;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnDelete;
        private XiaoxinPropertyManager.Common.CardPanel cardGrid;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseholdText;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateText;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
    }
}
