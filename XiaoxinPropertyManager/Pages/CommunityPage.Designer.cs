namespace XiaoxinPropertyManager.Pages
{
    partial class CommunityPage
    {
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.Toolbar = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.TableLayoutPanel();
            this.cardInfo = new XiaoxinPropertyManager.Common.CardPanel();
            this.capLblName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.capLblAddress = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.capLblArea = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.capLblBuildings = new System.Windows.Forms.Label();
            this.lblBuildings = new System.Windows.Forms.Label();
            this.capLblHouseholds = new System.Windows.Forms.Label();
            this.lblHouseholds = new System.Windows.Forms.Label();
            this.capLblCompany = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.capLblFee = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.capLblPhone = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.capLblGreen = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.capLblParking = new System.Windows.Forms.Label();
            this.lblParking = new System.Windows.Forms.Label();
            this.btnEditCommunity = new System.Windows.Forms.Button();
            this.cardGrid = new XiaoxinPropertyManager.Common.CardPanel();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.BuildingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseholdCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblPageTitle.Text = "小区管理";
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
            this.lblPageDescription.Text = "维护小区基本信息和楼栋资料";
            // 
            // Toolbar
            // 
            this.Toolbar.BackColor = System.Drawing.Color.White;
            this.Toolbar.Controls.Add(this.lblHint);
            this.Toolbar.Controls.Add(this.btnAdd);
            this.Toolbar.Controls.Add(this.btnEdit);
            this.Toolbar.Controls.Add(this.btnDelete);
            this.Toolbar.Controls.Add(this.btnRefresh);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar.Location = new System.Drawing.Point(0, 64);
            this.Toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(1030, 50);
            this.Toolbar.TabIndex = 1;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblHint.Location = new System.Drawing.Point(24, 12);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(84, 20);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "楼栋列表：";
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
            this.btnAdd.Location = new System.Drawing.Point(116, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增楼栋";
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
            this.btnEdit.Location = new System.Drawing.Point(220, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(304, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(388, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Body.Size = new System.Drawing.Size(1030, 508);
            this.Body.TabIndex = 0;
            // 
            // cardInfo
            // 
            this.cardInfo.BackColor = System.Drawing.Color.White;
            this.cardInfo.Caption = "小区基本信息";
            this.cardInfo.Controls.Add(this.capLblName);
            this.cardInfo.Controls.Add(this.lblName);
            this.cardInfo.Controls.Add(this.capLblAddress);
            this.cardInfo.Controls.Add(this.lblAddress);
            this.cardInfo.Controls.Add(this.capLblArea);
            this.cardInfo.Controls.Add(this.lblArea);
            this.cardInfo.Controls.Add(this.capLblBuildings);
            this.cardInfo.Controls.Add(this.lblBuildings);
            this.cardInfo.Controls.Add(this.capLblHouseholds);
            this.cardInfo.Controls.Add(this.lblHouseholds);
            this.cardInfo.Controls.Add(this.capLblCompany);
            this.cardInfo.Controls.Add(this.lblCompany);
            this.cardInfo.Controls.Add(this.capLblFee);
            this.cardInfo.Controls.Add(this.lblFee);
            this.cardInfo.Controls.Add(this.capLblPhone);
            this.cardInfo.Controls.Add(this.lblPhone);
            this.cardInfo.Controls.Add(this.capLblGreen);
            this.cardInfo.Controls.Add(this.lblGreen);
            this.cardInfo.Controls.Add(this.capLblParking);
            this.cardInfo.Controls.Add(this.lblParking);
            this.cardInfo.Controls.Add(this.btnEditCommunity);
            this.cardInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardInfo.Location = new System.Drawing.Point(24, 14);
            this.cardInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.cardInfo.Name = "cardInfo";
            this.cardInfo.Padding = new System.Windows.Forms.Padding(1);
            this.cardInfo.Size = new System.Drawing.Size(982, 192);
            this.cardInfo.TabIndex = 0;
            // 
            // capLblName
            // 
            this.capLblName.BackColor = System.Drawing.Color.Transparent;
            this.capLblName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblName.Location = new System.Drawing.Point(20, 46);
            this.capLblName.Name = "capLblName";
            this.capLblName.Size = new System.Drawing.Size(72, 22);
            this.capLblName.TabIndex = 0;
            this.capLblName.Text = "小区名称";
            this.capLblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblName.Location = new System.Drawing.Point(98, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "—";
            // 
            // capLblAddress
            // 
            this.capLblAddress.BackColor = System.Drawing.Color.Transparent;
            this.capLblAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblAddress.Location = new System.Drawing.Point(20, 76);
            this.capLblAddress.Name = "capLblAddress";
            this.capLblAddress.Size = new System.Drawing.Size(72, 22);
            this.capLblAddress.TabIndex = 0;
            this.capLblAddress.Text = "小区地址";
            this.capLblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblAddress.Location = new System.Drawing.Point(98, 79);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(25, 20);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "—";
            // 
            // capLblArea
            // 
            this.capLblArea.BackColor = System.Drawing.Color.Transparent;
            this.capLblArea.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblArea.Location = new System.Drawing.Point(20, 106);
            this.capLblArea.Name = "capLblArea";
            this.capLblArea.Size = new System.Drawing.Size(72, 22);
            this.capLblArea.TabIndex = 0;
            this.capLblArea.Text = "占地面积";
            this.capLblArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblArea.Location = new System.Drawing.Point(98, 109);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(25, 20);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "—";
            // 
            // capLblBuildings
            // 
            this.capLblBuildings.BackColor = System.Drawing.Color.Transparent;
            this.capLblBuildings.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblBuildings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblBuildings.Location = new System.Drawing.Point(20, 136);
            this.capLblBuildings.Name = "capLblBuildings";
            this.capLblBuildings.Size = new System.Drawing.Size(72, 22);
            this.capLblBuildings.TabIndex = 0;
            this.capLblBuildings.Text = "楼栋数量";
            this.capLblBuildings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuildings
            // 
            this.lblBuildings.AutoSize = true;
            this.lblBuildings.BackColor = System.Drawing.Color.Transparent;
            this.lblBuildings.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuildings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblBuildings.Location = new System.Drawing.Point(98, 139);
            this.lblBuildings.Name = "lblBuildings";
            this.lblBuildings.Size = new System.Drawing.Size(25, 20);
            this.lblBuildings.TabIndex = 0;
            this.lblBuildings.Text = "—";
            // 
            // capLblHouseholds
            // 
            this.capLblHouseholds.BackColor = System.Drawing.Color.Transparent;
            this.capLblHouseholds.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblHouseholds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblHouseholds.Location = new System.Drawing.Point(20, 166);
            this.capLblHouseholds.Name = "capLblHouseholds";
            this.capLblHouseholds.Size = new System.Drawing.Size(72, 22);
            this.capLblHouseholds.TabIndex = 0;
            this.capLblHouseholds.Text = "住户数量";
            this.capLblHouseholds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHouseholds
            // 
            this.lblHouseholds.AutoSize = true;
            this.lblHouseholds.BackColor = System.Drawing.Color.Transparent;
            this.lblHouseholds.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHouseholds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblHouseholds.Location = new System.Drawing.Point(98, 169);
            this.lblHouseholds.Name = "lblHouseholds";
            this.lblHouseholds.Size = new System.Drawing.Size(25, 20);
            this.lblHouseholds.TabIndex = 0;
            this.lblHouseholds.Text = "—";
            // 
            // capLblCompany
            // 
            this.capLblCompany.BackColor = System.Drawing.Color.Transparent;
            this.capLblCompany.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblCompany.Location = new System.Drawing.Point(330, 46);
            this.capLblCompany.Name = "capLblCompany";
            this.capLblCompany.Size = new System.Drawing.Size(72, 22);
            this.capLblCompany.TabIndex = 0;
            this.capLblCompany.Text = "物业公司";
            this.capLblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblCompany.Location = new System.Drawing.Point(408, 49);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(25, 20);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "—";
            // 
            // capLblFee
            // 
            this.capLblFee.BackColor = System.Drawing.Color.Transparent;
            this.capLblFee.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblFee.Location = new System.Drawing.Point(330, 76);
            this.capLblFee.Name = "capLblFee";
            this.capLblFee.Size = new System.Drawing.Size(88, 22);
            this.capLblFee.TabIndex = 0;
            this.capLblFee.Text = "物业费标准";
            this.capLblFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.BackColor = System.Drawing.Color.Transparent;
            this.lblFee.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblFee.Location = new System.Drawing.Point(424, 79);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(25, 20);
            this.lblFee.TabIndex = 0;
            this.lblFee.Text = "—";
            // 
            // capLblPhone
            // 
            this.capLblPhone.BackColor = System.Drawing.Color.Transparent;
            this.capLblPhone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblPhone.Location = new System.Drawing.Point(330, 106);
            this.capLblPhone.Name = "capLblPhone";
            this.capLblPhone.Size = new System.Drawing.Size(72, 22);
            this.capLblPhone.TabIndex = 0;
            this.capLblPhone.Text = "联系电话";
            this.capLblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblPhone.Location = new System.Drawing.Point(408, 109);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(25, 20);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "—";
            // 
            // capLblGreen
            // 
            this.capLblGreen.BackColor = System.Drawing.Color.Transparent;
            this.capLblGreen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblGreen.Location = new System.Drawing.Point(330, 136);
            this.capLblGreen.Name = "capLblGreen";
            this.capLblGreen.Size = new System.Drawing.Size(56, 22);
            this.capLblGreen.TabIndex = 0;
            this.capLblGreen.Text = "绿化率";
            this.capLblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.BackColor = System.Drawing.Color.Transparent;
            this.lblGreen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblGreen.Location = new System.Drawing.Point(392, 139);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(25, 20);
            this.lblGreen.TabIndex = 0;
            this.lblGreen.Text = "—";
            // 
            // capLblParking
            // 
            this.capLblParking.BackColor = System.Drawing.Color.Transparent;
            this.capLblParking.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblParking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblParking.Location = new System.Drawing.Point(330, 166);
            this.capLblParking.Name = "capLblParking";
            this.capLblParking.Size = new System.Drawing.Size(72, 22);
            this.capLblParking.TabIndex = 0;
            this.capLblParking.Text = "车位数量";
            this.capLblParking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblParking
            // 
            this.lblParking.AutoSize = true;
            this.lblParking.BackColor = System.Drawing.Color.Transparent;
            this.lblParking.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblParking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblParking.Location = new System.Drawing.Point(408, 169);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(25, 20);
            this.lblParking.TabIndex = 0;
            this.lblParking.Text = "—";
            // 
            // btnEditCommunity
            // 
            this.btnEditCommunity.BackColor = System.Drawing.Color.White;
            this.btnEditCommunity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCommunity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnEditCommunity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnEditCommunity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnEditCommunity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCommunity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditCommunity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btnEditCommunity.Location = new System.Drawing.Point(560, 13);
            this.btnEditCommunity.Name = "btnEditCommunity";
            this.btnEditCommunity.Size = new System.Drawing.Size(126, 31);
            this.btnEditCommunity.TabIndex = 1;
            this.btnEditCommunity.Text = "修改小区信息";
            this.btnEditCommunity.UseVisualStyleBackColor = false;
            this.btnEditCommunity.Click += new System.EventHandler(this.btnEditCommunity_Click);
            // 
            // cardGrid
            // 
            this.cardGrid.BackColor = System.Drawing.Color.White;
            this.cardGrid.Caption = "楼栋列表";
            this.cardGrid.Controls.Add(this.gridMain);
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Location = new System.Drawing.Point(24, 218);
            this.cardGrid.Margin = new System.Windows.Forms.Padding(0);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Padding = new System.Windows.Forms.Padding(1, 44, 1, 1);
            this.cardGrid.Size = new System.Drawing.Size(982, 290);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridMain.ColumnHeadersHeight = 36;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuildingId,
            this.BuildingName,
            this.UnitCount,
            this.FloorCount,
            this.HouseholdCount,
            this.Remark});
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
            this.gridMain.Size = new System.Drawing.Size(980, 245);
            this.gridMain.TabIndex = 0;
            // 
            // BuildingId
            // 
            this.BuildingId.DataPropertyName = "BuildingId";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BuildingId.DefaultCellStyle = dataGridViewCellStyle12;
            this.BuildingId.FillWeight = 45F;
            this.BuildingId.HeaderText = "编号";
            this.BuildingId.MinimumWidth = 60;
            this.BuildingId.Name = "BuildingId";
            this.BuildingId.ReadOnly = true;
            // 
            // BuildingName
            // 
            this.BuildingName.DataPropertyName = "BuildingName";
            this.BuildingName.FillWeight = 90F;
            this.BuildingName.HeaderText = "楼栋名称";
            this.BuildingName.MinimumWidth = 60;
            this.BuildingName.Name = "BuildingName";
            this.BuildingName.ReadOnly = true;
            // 
            // UnitCount
            // 
            this.UnitCount.DataPropertyName = "UnitCount";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UnitCount.DefaultCellStyle = dataGridViewCellStyle13;
            this.UnitCount.FillWeight = 70F;
            this.UnitCount.HeaderText = "单元数";
            this.UnitCount.MinimumWidth = 60;
            this.UnitCount.Name = "UnitCount";
            this.UnitCount.ReadOnly = true;
            // 
            // FloorCount
            // 
            this.FloorCount.DataPropertyName = "FloorCount";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FloorCount.DefaultCellStyle = dataGridViewCellStyle14;
            this.FloorCount.FillWeight = 70F;
            this.FloorCount.HeaderText = "层数";
            this.FloorCount.MinimumWidth = 60;
            this.FloorCount.Name = "FloorCount";
            this.FloorCount.ReadOnly = true;
            // 
            // HouseholdCount
            // 
            this.HouseholdCount.DataPropertyName = "HouseholdCount";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HouseholdCount.DefaultCellStyle = dataGridViewCellStyle15;
            this.HouseholdCount.FillWeight = 90F;
            this.HouseholdCount.HeaderText = "已登记住户";
            this.HouseholdCount.MinimumWidth = 60;
            this.HouseholdCount.Name = "HouseholdCount";
            this.HouseholdCount.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.FillWeight = 260F;
            this.Remark.HeaderText = "备注";
            this.Remark.MinimumWidth = 60;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
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
            // CommunityPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "CommunityPage";
            this.Size = new System.Drawing.Size(1030, 660);
            this.pnlRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
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
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private XiaoxinPropertyManager.Common.CardPanel cardInfo;
        private System.Windows.Forms.Label capLblName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label capLblAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label capLblArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label capLblBuildings;
        private System.Windows.Forms.Label lblBuildings;
        private System.Windows.Forms.Label capLblHouseholds;
        private System.Windows.Forms.Label lblHouseholds;
        private System.Windows.Forms.Label capLblCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label capLblFee;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label capLblPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label capLblGreen;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label capLblParking;
        private System.Windows.Forms.Label lblParking;
        private System.Windows.Forms.Button btnEditCommunity;
        private XiaoxinPropertyManager.Common.CardPanel cardGrid;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseholdCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}
