namespace XiaoxinPropertyManager.Pages
{
    partial class RepairPage
    {
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.Toolbar = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Toolbar2 = new System.Windows.Forms.Panel();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHandle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Toolbar3 = new System.Windows.Forms.Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new XiaoxinPropertyManager.Common.CardPanel();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.RepairId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SolveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new XiaoxinPropertyManager.Common.FooterPanel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.FooterRight = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.Toolbar2.SuspendLayout();
            this.Toolbar3.SuspendLayout();
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
            this.pnlRoot.Controls.Add(this.Toolbar3, 0, 3);
            this.pnlRoot.Controls.Add(this.Body, 0, 4);
            this.pnlRoot.Controls.Add(this.pnlFooter, 0, 5);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.RowCount = 6;
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
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
            this.lblPageTitle.Text = "报修管理";
            // 
            // lblPageDescription
            // 
            this.lblPageDescription.AutoSize = true;
            this.lblPageDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblPageDescription.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPageDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblPageDescription.Location = new System.Drawing.Point(25, 41);
            this.lblPageDescription.Name = "lblPageDescription";
            this.lblPageDescription.Size = new System.Drawing.Size(249, 20);
            this.lblPageDescription.TabIndex = 1;
            this.lblPageDescription.Text = "受理报修工单，派单并登记完工情况";
            // 
            // Toolbar
            // 
            this.Toolbar.BackColor = System.Drawing.Color.White;
            this.Toolbar.Controls.Add(this.lblStatus);
            this.Toolbar.Controls.Add(this.cboStatus);
            this.Toolbar.Controls.Add(this.btnSearch);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar.Location = new System.Drawing.Point(0, 64);
            this.Toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(1030, 50);
            this.Toolbar.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblStatus.Location = new System.Drawing.Point(24, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "状态";
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
            "待处理",
            "处理中",
            "已完成"});
            this.cboStatus.Location = new System.Drawing.Point(70, 12);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(100, 28);
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
            this.btnSearch.Location = new System.Drawing.Point(186, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Toolbar2
            // 
            this.Toolbar2.BackColor = System.Drawing.Color.White;
            this.Toolbar2.Controls.Add(this.lblKeyword);
            this.Toolbar2.Controls.Add(this.txtKeyword);
            this.Toolbar2.Controls.Add(this.btnReset);
            this.Toolbar2.Controls.Add(this.btnAdd);
            this.Toolbar2.Controls.Add(this.btnHandle);
            this.Toolbar2.Controls.Add(this.btnDelete);
            this.Toolbar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar2.Location = new System.Drawing.Point(0, 114);
            this.Toolbar2.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar2.Name = "Toolbar2";
            this.Toolbar2.Size = new System.Drawing.Size(1030, 44);
            this.Toolbar2.TabIndex = 2;
            // 
            // lblKeyword
            // 
            this.lblKeyword.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblKeyword.Location = new System.Drawing.Point(24, 10);
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
            this.txtKeyword.Location = new System.Drawing.Point(86, 10);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(150, 27);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.Visible = false;
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
            this.btnReset.Location = new System.Drawing.Point(252, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 27);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
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
            this.btnAdd.Location = new System.Drawing.Point(348, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增工单";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHandle
            // 
            this.btnHandle.BackColor = System.Drawing.Color.White;
            this.btnHandle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHandle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnHandle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnHandle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.btnHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHandle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btnHandle.Location = new System.Drawing.Point(452, 10);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(98, 27);
            this.btnHandle.TabIndex = 1;
            this.btnHandle.Text = "处理报修";
            this.btnHandle.UseVisualStyleBackColor = false;
            this.btnHandle.Visible = false;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(556, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Toolbar3
            // 
            this.Toolbar3.BackColor = System.Drawing.Color.White;
            this.Toolbar3.Controls.Add(this.lblContent);
            this.Toolbar3.Controls.Add(this.txtContent);
            this.Toolbar3.Controls.Add(this.btnSubmit);
            this.Toolbar3.Controls.Add(this.btnCancel);
            this.Toolbar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar3.Location = new System.Drawing.Point(0, 158);
            this.Toolbar3.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar3.Name = "Toolbar3";
            this.Toolbar3.Size = new System.Drawing.Size(1030, 44);
            this.Toolbar3.TabIndex = 3;
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.Color.Transparent;
            this.lblContent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblContent.Location = new System.Drawing.Point(24, 10);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(72, 25);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "报修内容";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(102, 10);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(300, 27);
            this.txtContent.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(418, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 26);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "提交报修";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(62)))), ((int)(((byte)(51)))));
            this.btnCancel.Location = new System.Drawing.Point(534, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "撤销报修";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Body.ColumnCount = 1;
            this.Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Body.Controls.Add(this.cardGrid, 0, 0);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 202);
            this.Body.Margin = new System.Windows.Forms.Padding(0);
            this.Body.Name = "Body";
            this.Body.Padding = new System.Windows.Forms.Padding(24, 14, 24, 0);
            this.Body.RowCount = 1;
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Body.Size = new System.Drawing.Size(1030, 420);
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
            this.cardGrid.Size = new System.Drawing.Size(982, 406);
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
            this.RepairId,
            this.OwnerName,
            this.RoomNo,
            this.Content,
            this.ReportDate,
            this.SolveDate,
            this.RepairText,
            this.RepairMan,
            this.Fee,
            this.Status});
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
            this.gridMain.Size = new System.Drawing.Size(980, 404);
            this.gridMain.TabIndex = 0;
            // 
            // RepairId
            // 
            this.RepairId.DataPropertyName = "RepairId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RepairId.DefaultCellStyle = dataGridViewCellStyle2;
            this.RepairId.FillWeight = 55F;
            this.RepairId.HeaderText = "工单号";
            this.RepairId.MinimumWidth = 60;
            this.RepairId.Name = "RepairId";
            this.RepairId.ReadOnly = true;
            // 
            // OwnerName
            // 
            this.OwnerName.DataPropertyName = "OwnerName";
            this.OwnerName.FillWeight = 80F;
            this.OwnerName.HeaderText = "报修住户";
            this.OwnerName.MinimumWidth = 60;
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.FillWeight = 105F;
            this.RoomNo.HeaderText = "门牌号";
            this.RoomNo.MinimumWidth = 60;
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.FillWeight = 220F;
            this.Content.HeaderText = "报修内容";
            this.Content.MinimumWidth = 60;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // ReportDate
            // 
            this.ReportDate.DataPropertyName = "ReportDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ReportDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReportDate.FillWeight = 115F;
            this.ReportDate.HeaderText = "上报时间";
            this.ReportDate.MinimumWidth = 60;
            this.ReportDate.Name = "ReportDate";
            this.ReportDate.ReadOnly = true;
            // 
            // SolveDate
            // 
            this.SolveDate.DataPropertyName = "SolveDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SolveDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.SolveDate.FillWeight = 115F;
            this.SolveDate.HeaderText = "维修时间";
            this.SolveDate.MinimumWidth = 60;
            this.SolveDate.Name = "SolveDate";
            this.SolveDate.ReadOnly = true;
            // 
            // RepairText
            // 
            this.RepairText.DataPropertyName = "RepairText";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RepairText.DefaultCellStyle = dataGridViewCellStyle5;
            this.RepairText.FillWeight = 55F;
            this.RepairText.HeaderText = "已维修";
            this.RepairText.MinimumWidth = 60;
            this.RepairText.Name = "RepairText";
            this.RepairText.ReadOnly = true;
            // 
            // RepairMan
            // 
            this.RepairMan.DataPropertyName = "RepairMan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RepairMan.DefaultCellStyle = dataGridViewCellStyle6;
            this.RepairMan.FillWeight = 70F;
            this.RepairMan.HeaderText = "维修人";
            this.RepairMan.MinimumWidth = 60;
            this.RepairMan.Name = "RepairMan";
            this.RepairMan.ReadOnly = true;
            // 
            // Fee
            // 
            this.Fee.DataPropertyName = "Fee";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Fee.DefaultCellStyle = dataGridViewCellStyle7;
            this.Fee.FillWeight = 65F;
            this.Fee.HeaderText = "费用";
            this.Fee.MinimumWidth = 60;
            this.Fee.Name = "Fee";
            this.Fee.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Status.DefaultCellStyle = dataGridViewCellStyle8;
            this.Status.FillWeight = 65F;
            this.Status.HeaderText = "状态";
            this.Status.MinimumWidth = 60;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
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
            // RepairPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "RepairPage";
            this.Size = new System.Drawing.Size(1030, 660);
            this.pnlRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.Toolbar.ResumeLayout(false);
            this.Toolbar2.ResumeLayout(false);
            this.Toolbar2.PerformLayout();
            this.Toolbar3.ResumeLayout(false);
            this.Toolbar3.PerformLayout();
            this.Body.ResumeLayout(false);
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
        private System.Windows.Forms.Panel Toolbar2;
        private System.Windows.Forms.Panel Toolbar3;
        private System.Windows.Forms.TableLayoutPanel Body;
        private XiaoxinPropertyManager.Common.FooterPanel pnlFooter;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.FlowLayoutPanel FooterRight;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHandle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private XiaoxinPropertyManager.Common.CardPanel cardGrid;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SolveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairText;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
