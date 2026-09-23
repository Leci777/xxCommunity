namespace XiaoxinPropertyManager.Pages
{
    partial class FeedbackPage
    {
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.Toolbar = new System.Windows.Forms.Panel();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Toolbar2 = new System.Windows.Forms.Panel();
            this.btnReply = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.TableLayoutPanel();
            this.cardGrid = new XiaoxinPropertyManager.Common.CardPanel();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.FeedbackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplyContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplyUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblPageTitle.Text = "反馈管理";
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
            this.lblPageDescription.Text = "查看业主的投诉与建议并回复";
            // 
            // Toolbar
            // 
            this.Toolbar.BackColor = System.Drawing.Color.White;
            this.Toolbar.Controls.Add(this.lblKeyword);
            this.Toolbar.Controls.Add(this.txtKeyword);
            this.Toolbar.Controls.Add(this.lblType);
            this.Toolbar.Controls.Add(this.cboType);
            this.Toolbar.Controls.Add(this.lblStatus);
            this.Toolbar.Controls.Add(this.cboStatus);
            this.Toolbar.Controls.Add(this.btnSearch);
            this.Toolbar.Controls.Add(this.btnReset);
            this.Toolbar.Controls.Add(this.btnAdd);
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
            this.txtKeyword.Location = new System.Drawing.Point(86, 11);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(150, 27);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.Visible = false;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblType.Location = new System.Drawing.Point(252, 12);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 25);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "类型";
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
            "投诉",
            "建议"});
            this.cboType.Location = new System.Drawing.Point(298, 10);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 28);
            this.cboType.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblStatus.Location = new System.Drawing.Point(414, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "处理状态";
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
            "已回复"});
            this.cboStatus.Location = new System.Drawing.Point(492, 10);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(110, 28);
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
            this.btnSearch.Location = new System.Drawing.Point(720, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 35);
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
            this.btnReset.Location = new System.Drawing.Point(815, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 35);
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
            this.btnAdd.Location = new System.Drawing.Point(612, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "提交反馈";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Toolbar2
            // 
            this.Toolbar2.BackColor = System.Drawing.Color.White;
            this.Toolbar2.Controls.Add(this.btnReply);
            this.Toolbar2.Controls.Add(this.btnDelete);
            this.Toolbar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar2.Location = new System.Drawing.Point(0, 114);
            this.Toolbar2.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar2.Name = "Toolbar2";
            this.Toolbar2.Size = new System.Drawing.Size(1030, 44);
            this.Toolbar2.TabIndex = 2;
            // 
            // btnReply
            // 
            this.btnReply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.btnReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnReply.FlatAppearance.BorderSize = 0;
            this.btnReply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnReply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReply.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReply.ForeColor = System.Drawing.Color.White;
            this.btnReply.Location = new System.Drawing.Point(24, 12);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(94, 26);
            this.btnReply.TabIndex = 1;
            this.btnReply.Text = "回复反馈";
            this.btnReply.UseVisualStyleBackColor = false;
            this.btnReply.Visible = false;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(128, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 31);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridMain.ColumnHeadersHeight = 36;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeedbackId,
            this.OwnerName,
            this.RoomNo,
            this.FType,
            this.Title,
            this.Content,
            this.CreateTime,
            this.Status,
            this.ReplyContent,
            this.ReplyUser});
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
            // FeedbackId
            // 
            this.FeedbackId.DataPropertyName = "FeedbackId";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FeedbackId.DefaultCellStyle = dataGridViewCellStyle14;
            this.FeedbackId.FillWeight = 45F;
            this.FeedbackId.HeaderText = "编号";
            this.FeedbackId.MinimumWidth = 60;
            this.FeedbackId.Name = "FeedbackId";
            this.FeedbackId.ReadOnly = true;
            // 
            // OwnerName
            // 
            this.OwnerName.DataPropertyName = "OwnerName";
            this.OwnerName.FillWeight = 70F;
            this.OwnerName.HeaderText = "提交人";
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
            // FType
            // 
            this.FType.DataPropertyName = "FType";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FType.DefaultCellStyle = dataGridViewCellStyle15;
            this.FType.FillWeight = 50F;
            this.FType.HeaderText = "类型";
            this.FType.MinimumWidth = 60;
            this.FType.Name = "FType";
            this.FType.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 140F;
            this.Title.HeaderText = "标题";
            this.Title.MinimumWidth = 60;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.FillWeight = 220F;
            this.Content.HeaderText = "内容";
            this.Content.MinimumWidth = 60;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CreateTime.DefaultCellStyle = dataGridViewCellStyle16;
            this.CreateTime.FillWeight = 110F;
            this.CreateTime.HeaderText = "提交时间";
            this.CreateTime.MinimumWidth = 60;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Status.DefaultCellStyle = dataGridViewCellStyle17;
            this.Status.FillWeight = 60F;
            this.Status.HeaderText = "状态";
            this.Status.MinimumWidth = 60;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ReplyContent
            // 
            this.ReplyContent.DataPropertyName = "ReplyContent";
            this.ReplyContent.FillWeight = 220F;
            this.ReplyContent.HeaderText = "物业回复";
            this.ReplyContent.MinimumWidth = 60;
            this.ReplyContent.Name = "ReplyContent";
            this.ReplyContent.ReadOnly = true;
            // 
            // ReplyUser
            // 
            this.ReplyUser.DataPropertyName = "ReplyUser";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ReplyUser.DefaultCellStyle = dataGridViewCellStyle18;
            this.ReplyUser.FillWeight = 65F;
            this.ReplyUser.HeaderText = "回复人";
            this.ReplyUser.MinimumWidth = 60;
            this.ReplyUser.Name = "ReplyUser";
            this.ReplyUser.ReadOnly = true;
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
            // FeedbackPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FeedbackPage";
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
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private XiaoxinPropertyManager.Common.CardPanel cardGrid;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeedbackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplyContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplyUser;
    }
}
