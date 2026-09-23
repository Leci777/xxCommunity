namespace XiaoxinPropertyManager.Pages
{
    partial class FeePage
    {
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.Toolbar = new System.Windows.Forms.Panel();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.Toolbar2 = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnBatch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new XiaoxinPropertyManager.Common.CardPanel();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.FeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblPageTitle.Text = "收费管理";
            // 
            // lblPageDescription
            // 
            this.lblPageDescription.AutoSize = true;
            this.lblPageDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblPageDescription.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPageDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblPageDescription.Location = new System.Drawing.Point(25, 41);
            this.lblPageDescription.Name = "lblPageDescription";
            this.lblPageDescription.Size = new System.Drawing.Size(279, 20);
            this.lblPageDescription.TabIndex = 1;
            this.lblPageDescription.Text = "登记各项费用并核销，随时掌握收缴情况";
            // 
            // Toolbar
            // 
            this.Toolbar.BackColor = System.Drawing.Color.White;
            this.Toolbar.Controls.Add(this.lblKeyword);
            this.Toolbar.Controls.Add(this.txtKeyword);
            this.Toolbar.Controls.Add(this.lblMonth);
            this.Toolbar.Controls.Add(this.txtMonth);
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
            this.lblKeyword.Visible = false;
            // 
            // txtKeyword
            // 
            this.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKeyword.Location = new System.Drawing.Point(86, 12);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(150, 27);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.Visible = false;
            // 
            // lblMonth
            // 
            this.lblMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblMonth.Location = new System.Drawing.Point(252, 12);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(72, 25);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "费用月份";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMonth.Visible = false;
            // 
            // txtMonth
            // 
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonth.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMonth.Location = new System.Drawing.Point(330, 12);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(90, 27);
            this.txtMonth.TabIndex = 1;
            this.txtMonth.Visible = false;
            // 
            // Toolbar2
            // 
            this.Toolbar2.BackColor = System.Drawing.Color.White;
            this.Toolbar2.Controls.Add(this.lblType);
            this.Toolbar2.Controls.Add(this.cboType);
            this.Toolbar2.Controls.Add(this.lblStatus);
            this.Toolbar2.Controls.Add(this.cboStatus);
            this.Toolbar2.Controls.Add(this.btnSearch);
            this.Toolbar2.Controls.Add(this.btnReset);
            this.Toolbar2.Controls.Add(this.btnAdd);
            this.Toolbar2.Controls.Add(this.btnPay);
            this.Toolbar2.Controls.Add(this.btnBatch);
            this.Toolbar2.Controls.Add(this.btnDelete);
            this.Toolbar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar2.Location = new System.Drawing.Point(0, 114);
            this.Toolbar2.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar2.Name = "Toolbar2";
            this.Toolbar2.Size = new System.Drawing.Size(1030, 44);
            this.Toolbar2.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblType.Location = new System.Drawing.Point(24, 7);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(72, 25);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "费用类型";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.White;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "全部",
            "物业费",
            "水费",
            "电费",
            "停车费"});
            this.cboType.Location = new System.Drawing.Point(102, 5);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 28);
            this.cboType.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblStatus.Location = new System.Drawing.Point(218, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "缴费状态";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.White;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "全部",
            "未缴",
            "已缴"});
            this.cboStatus.Location = new System.Drawing.Point(296, 5);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(90, 28);
            this.cboStatus.TabIndex = 1;
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
            this.btnSearch.Location = new System.Drawing.Point(402, 6);
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
            this.btnReset.Location = new System.Drawing.Point(482, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 33);
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
            this.btnAdd.Location = new System.Drawing.Point(582, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增收费";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.White;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btnPay.Location = new System.Drawing.Point(682, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(98, 33);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "核销缴费";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Visible = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBatch
            // 
            this.btnBatch.BackColor = System.Drawing.Color.White;
            this.btnBatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnBatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnBatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btnBatch.Location = new System.Drawing.Point(786, 3);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(114, 33);
            this.btnBatch.TabIndex = 1;
            this.btnBatch.Text = "生成物业费";
            this.btnBatch.UseVisualStyleBackColor = false;
            this.btnBatch.Visible = false;
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(906, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gridMain.ColumnHeadersHeight = 36;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeeId,
            this.OwnerName,
            this.RoomNo,
            this.FeeType,
            this.FeeMonth,
            this.Amount,
            this.PayStatus,
            this.PayDate,
            this.Operator,
            this.Remark});
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
            // FeeId
            // 
            this.FeeId.DataPropertyName = "FeeId";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FeeId.DefaultCellStyle = dataGridViewCellStyle18;
            this.FeeId.FillWeight = 45F;
            this.FeeId.HeaderText = "编号";
            this.FeeId.MinimumWidth = 60;
            this.FeeId.Name = "FeeId";
            this.FeeId.ReadOnly = true;
            // 
            // OwnerName
            // 
            this.OwnerName.DataPropertyName = "OwnerName";
            this.OwnerName.FillWeight = 75F;
            this.OwnerName.HeaderText = "住户";
            this.OwnerName.MinimumWidth = 60;
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "门牌号";
            this.RoomNo.MinimumWidth = 60;
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // FeeType
            // 
            this.FeeType.DataPropertyName = "FeeType";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FeeType.DefaultCellStyle = dataGridViewCellStyle19;
            this.FeeType.FillWeight = 70F;
            this.FeeType.HeaderText = "费用类型";
            this.FeeType.MinimumWidth = 60;
            this.FeeType.Name = "FeeType";
            this.FeeType.ReadOnly = true;
            // 
            // FeeMonth
            // 
            this.FeeMonth.DataPropertyName = "FeeMonth";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FeeMonth.DefaultCellStyle = dataGridViewCellStyle20;
            this.FeeMonth.FillWeight = 80F;
            this.FeeMonth.HeaderText = "费用月份";
            this.FeeMonth.MinimumWidth = 60;
            this.FeeMonth.Name = "FeeMonth";
            this.FeeMonth.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle21;
            this.Amount.FillWeight = 80F;
            this.Amount.HeaderText = "金额(元)";
            this.Amount.MinimumWidth = 60;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // PayStatus
            // 
            this.PayStatus.DataPropertyName = "PayStatus";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PayStatus.DefaultCellStyle = dataGridViewCellStyle22;
            this.PayStatus.FillWeight = 70F;
            this.PayStatus.HeaderText = "缴费状态";
            this.PayStatus.MinimumWidth = 60;
            this.PayStatus.Name = "PayStatus";
            this.PayStatus.ReadOnly = true;
            // 
            // PayDate
            // 
            this.PayDate.DataPropertyName = "PayDate";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PayDate.DefaultCellStyle = dataGridViewCellStyle23;
            this.PayDate.FillWeight = 115F;
            this.PayDate.HeaderText = "缴费时间";
            this.PayDate.MinimumWidth = 60;
            this.PayDate.Name = "PayDate";
            this.PayDate.ReadOnly = true;
            // 
            // Operator
            // 
            this.Operator.DataPropertyName = "Operator";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Operator.DefaultCellStyle = dataGridViewCellStyle24;
            this.Operator.FillWeight = 75F;
            this.Operator.HeaderText = "经办人";
            this.Operator.MinimumWidth = 60;
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.FillWeight = 140F;
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
            // FeePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FeePage";
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
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBatch;
        private System.Windows.Forms.Button btnDelete;
        private XiaoxinPropertyManager.Common.CardPanel cardGrid;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}
