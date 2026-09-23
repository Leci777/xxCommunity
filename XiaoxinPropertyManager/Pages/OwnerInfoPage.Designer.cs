namespace XiaoxinPropertyManager.Pages
{
    partial class OwnerInfoPage
    {
        private void InitializeComponent()
        {
            this.pnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.Toolbar = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.TableLayoutPanel();
            this.tipCard = new XiaoxinPropertyManager.Common.CardPanel();
            this.lblTip = new System.Windows.Forms.Label();
            this.cardProfile = new XiaoxinPropertyManager.Common.CardPanel();
            this.capLblOwnerName = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.capLblGender = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.capLblIdCard = new System.Windows.Forms.Label();
            this.lblIdCard = new System.Windows.Forms.Label();
            this.capLblMoveIn = new System.Windows.Forms.Label();
            this.lblMoveIn = new System.Windows.Forms.Label();
            this.capLblBuilding = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.capLblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.capLblArea = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.capLblLoginName = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.cardEditable = new XiaoxinPropertyManager.Common.CardPanel();
            this.capTxtPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.capTxtFamily = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.capTxtEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.capTxtRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.capTxtNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.capTxtNewPassword2 = new System.Windows.Forms.Label();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.pnlFooter = new XiaoxinPropertyManager.Common.FooterPanel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.FooterRight = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.Body.SuspendLayout();
            this.tipCard.SuspendLayout();
            this.cardProfile.SuspendLayout();
            this.cardEditable.SuspendLayout();
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
            this.lblPageTitle.Text = "我的信息";
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
            this.lblPageDescription.Text = "查看住户档案，维护联系信息和登录密码";
            // 
            // Toolbar
            // 
            this.Toolbar.BackColor = System.Drawing.Color.White;
            this.Toolbar.Controls.Add(this.btnSave);
            this.Toolbar.Controls.Add(this.btnRefresh);
            this.Toolbar.Controls.Add(this.lblHint);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Toolbar.Location = new System.Drawing.Point(0, 64);
            this.Toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(1030, 50);
            this.Toolbar.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(24, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(128, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblHint.Location = new System.Drawing.Point(252, 15);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(369, 20);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "姓名、房号等关键信息如需变更，请联系物业服务中心";
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Body.ColumnCount = 1;
            this.Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Body.Controls.Add(this.tipCard, 0, 0);
            this.Body.Controls.Add(this.cardProfile, 0, 1);
            this.Body.Controls.Add(this.cardEditable, 0, 2);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 114);
            this.Body.Margin = new System.Windows.Forms.Padding(0);
            this.Body.Name = "Body";
            this.Body.Padding = new System.Windows.Forms.Padding(24, 14, 24, 0);
            this.Body.RowCount = 3;
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.Body.Size = new System.Drawing.Size(1030, 508);
            this.Body.TabIndex = 0;
            // 
            // tipCard
            // 
            this.tipCard.BackColor = System.Drawing.Color.White;
            this.tipCard.Caption = "提示";
            this.tipCard.Controls.Add(this.lblTip);
            this.tipCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipCard.Location = new System.Drawing.Point(24, 14);
            this.tipCard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.tipCard.Name = "tipCard";
            this.tipCard.Padding = new System.Windows.Forms.Padding(1);
            this.tipCard.Size = new System.Drawing.Size(982, 90);
            this.tipCard.TabIndex = 0;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.Transparent;
            this.lblTip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblTip.Location = new System.Drawing.Point(20, 44);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(654, 20);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "当前账号还没有关联住户档案。请联系电话服务中心把登录账号与住户档案绑定后再使用本功能。";
            // 
            // cardProfile
            // 
            this.cardProfile.BackColor = System.Drawing.Color.White;
            this.cardProfile.Caption = "我的住户档案";
            this.cardProfile.Controls.Add(this.capLblOwnerName);
            this.cardProfile.Controls.Add(this.lblOwnerName);
            this.cardProfile.Controls.Add(this.capLblGender);
            this.cardProfile.Controls.Add(this.lblGender);
            this.cardProfile.Controls.Add(this.capLblIdCard);
            this.cardProfile.Controls.Add(this.lblIdCard);
            this.cardProfile.Controls.Add(this.capLblMoveIn);
            this.cardProfile.Controls.Add(this.lblMoveIn);
            this.cardProfile.Controls.Add(this.capLblBuilding);
            this.cardProfile.Controls.Add(this.lblBuilding);
            this.cardProfile.Controls.Add(this.capLblRoomNo);
            this.cardProfile.Controls.Add(this.lblRoomNo);
            this.cardProfile.Controls.Add(this.capLblArea);
            this.cardProfile.Controls.Add(this.lblArea);
            this.cardProfile.Controls.Add(this.capLblLoginName);
            this.cardProfile.Controls.Add(this.lblLoginName);
            this.cardProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardProfile.Location = new System.Drawing.Point(24, 116);
            this.cardProfile.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.cardProfile.Name = "cardProfile";
            this.cardProfile.Padding = new System.Windows.Forms.Padding(1);
            this.cardProfile.Size = new System.Drawing.Size(982, 185);
            this.cardProfile.TabIndex = 1;
            // 
            // capLblOwnerName
            // 
            this.capLblOwnerName.BackColor = System.Drawing.Color.Transparent;
            this.capLblOwnerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblOwnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblOwnerName.Location = new System.Drawing.Point(20, 46);
            this.capLblOwnerName.Name = "capLblOwnerName";
            this.capLblOwnerName.Size = new System.Drawing.Size(72, 22);
            this.capLblOwnerName.TabIndex = 0;
            this.capLblOwnerName.Text = "业主姓名";
            this.capLblOwnerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnerName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOwnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblOwnerName.Location = new System.Drawing.Point(98, 49);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(25, 20);
            this.lblOwnerName.TabIndex = 0;
            this.lblOwnerName.Text = "—";
            // 
            // capLblGender
            // 
            this.capLblGender.BackColor = System.Drawing.Color.Transparent;
            this.capLblGender.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblGender.Location = new System.Drawing.Point(20, 76);
            this.capLblGender.Name = "capLblGender";
            this.capLblGender.Size = new System.Drawing.Size(40, 22);
            this.capLblGender.TabIndex = 0;
            this.capLblGender.Text = "性别";
            this.capLblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblGender.Location = new System.Drawing.Point(66, 79);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(25, 20);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "—";
            // 
            // capLblIdCard
            // 
            this.capLblIdCard.BackColor = System.Drawing.Color.Transparent;
            this.capLblIdCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblIdCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblIdCard.Location = new System.Drawing.Point(20, 106);
            this.capLblIdCard.Name = "capLblIdCard";
            this.capLblIdCard.Size = new System.Drawing.Size(72, 22);
            this.capLblIdCard.TabIndex = 0;
            this.capLblIdCard.Text = "身份证号";
            this.capLblIdCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIdCard
            // 
            this.lblIdCard.AutoSize = true;
            this.lblIdCard.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIdCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblIdCard.Location = new System.Drawing.Point(98, 109);
            this.lblIdCard.Name = "lblIdCard";
            this.lblIdCard.Size = new System.Drawing.Size(25, 20);
            this.lblIdCard.TabIndex = 0;
            this.lblIdCard.Text = "—";
            // 
            // capLblMoveIn
            // 
            this.capLblMoveIn.BackColor = System.Drawing.Color.Transparent;
            this.capLblMoveIn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblMoveIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblMoveIn.Location = new System.Drawing.Point(20, 136);
            this.capLblMoveIn.Name = "capLblMoveIn";
            this.capLblMoveIn.Size = new System.Drawing.Size(72, 22);
            this.capLblMoveIn.TabIndex = 0;
            this.capLblMoveIn.Text = "入住日期";
            this.capLblMoveIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMoveIn
            // 
            this.lblMoveIn.AutoSize = true;
            this.lblMoveIn.BackColor = System.Drawing.Color.Transparent;
            this.lblMoveIn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMoveIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblMoveIn.Location = new System.Drawing.Point(98, 139);
            this.lblMoveIn.Name = "lblMoveIn";
            this.lblMoveIn.Size = new System.Drawing.Size(25, 20);
            this.lblMoveIn.TabIndex = 0;
            this.lblMoveIn.Text = "—";
            // 
            // capLblBuilding
            // 
            this.capLblBuilding.BackColor = System.Drawing.Color.Transparent;
            this.capLblBuilding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblBuilding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblBuilding.Location = new System.Drawing.Point(350, 46);
            this.capLblBuilding.Name = "capLblBuilding";
            this.capLblBuilding.Size = new System.Drawing.Size(72, 22);
            this.capLblBuilding.TabIndex = 0;
            this.capLblBuilding.Text = "所在楼栋";
            this.capLblBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.BackColor = System.Drawing.Color.Transparent;
            this.lblBuilding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuilding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblBuilding.Location = new System.Drawing.Point(428, 49);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(25, 20);
            this.lblBuilding.TabIndex = 0;
            this.lblBuilding.Text = "—";
            // 
            // capLblRoomNo
            // 
            this.capLblRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.capLblRoomNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblRoomNo.Location = new System.Drawing.Point(350, 76);
            this.capLblRoomNo.Name = "capLblRoomNo";
            this.capLblRoomNo.Size = new System.Drawing.Size(56, 22);
            this.capLblRoomNo.TabIndex = 0;
            this.capLblRoomNo.Text = "门牌号";
            this.capLblRoomNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblRoomNo.Location = new System.Drawing.Point(412, 79);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(25, 20);
            this.lblRoomNo.TabIndex = 0;
            this.lblRoomNo.Text = "—";
            // 
            // capLblArea
            // 
            this.capLblArea.BackColor = System.Drawing.Color.Transparent;
            this.capLblArea.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblArea.Location = new System.Drawing.Point(350, 106);
            this.capLblArea.Name = "capLblArea";
            this.capLblArea.Size = new System.Drawing.Size(72, 22);
            this.capLblArea.TabIndex = 0;
            this.capLblArea.Text = "建筑面积";
            this.capLblArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblArea.Location = new System.Drawing.Point(428, 109);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(25, 20);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "—";
            // 
            // capLblLoginName
            // 
            this.capLblLoginName.BackColor = System.Drawing.Color.Transparent;
            this.capLblLoginName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capLblLoginName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capLblLoginName.Location = new System.Drawing.Point(350, 136);
            this.capLblLoginName.Name = "capLblLoginName";
            this.capLblLoginName.Size = new System.Drawing.Size(72, 22);
            this.capLblLoginName.TabIndex = 0;
            this.capLblLoginName.Text = "登录账号";
            this.capLblLoginName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblLoginName.Location = new System.Drawing.Point(428, 139);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(25, 20);
            this.lblLoginName.TabIndex = 0;
            this.lblLoginName.Text = "—";
            // 
            // cardEditable
            // 
            this.cardEditable.BackColor = System.Drawing.Color.White;
            this.cardEditable.Caption = "联系信息与密码";
            this.cardEditable.Controls.Add(this.capTxtPhone);
            this.cardEditable.Controls.Add(this.txtPhone);
            this.cardEditable.Controls.Add(this.capTxtFamily);
            this.cardEditable.Controls.Add(this.txtFamily);
            this.cardEditable.Controls.Add(this.capTxtEmail);
            this.cardEditable.Controls.Add(this.txtEmail);
            this.cardEditable.Controls.Add(this.capTxtRemark);
            this.cardEditable.Controls.Add(this.txtRemark);
            this.cardEditable.Controls.Add(this.capTxtNewPassword);
            this.cardEditable.Controls.Add(this.txtNewPassword);
            this.cardEditable.Controls.Add(this.capTxtNewPassword2);
            this.cardEditable.Controls.Add(this.txtNewPassword2);
            this.cardEditable.Controls.Add(this.lblNote);
            this.cardEditable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardEditable.Location = new System.Drawing.Point(24, 313);
            this.cardEditable.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.cardEditable.Name = "cardEditable";
            this.cardEditable.Padding = new System.Windows.Forms.Padding(1);
            this.cardEditable.Size = new System.Drawing.Size(982, 183);
            this.cardEditable.TabIndex = 2;
            // 
            // capTxtPhone
            // 
            this.capTxtPhone.BackColor = System.Drawing.Color.Transparent;
            this.capTxtPhone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capTxtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capTxtPhone.Location = new System.Drawing.Point(20, 44);
            this.capTxtPhone.Name = "capTxtPhone";
            this.capTxtPhone.Size = new System.Drawing.Size(88, 22);
            this.capTxtPhone.TabIndex = 0;
            this.capTxtPhone.Text = "联系电话：";
            this.capTxtPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.Location = new System.Drawing.Point(114, 44);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 27);
            this.txtPhone.TabIndex = 1;
            // 
            // capTxtFamily
            // 
            this.capTxtFamily.BackColor = System.Drawing.Color.Transparent;
            this.capTxtFamily.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capTxtFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capTxtFamily.Location = new System.Drawing.Point(350, 44);
            this.capTxtFamily.Name = "capTxtFamily";
            this.capTxtFamily.Size = new System.Drawing.Size(88, 22);
            this.capTxtFamily.TabIndex = 0;
            this.capTxtFamily.Text = "家庭人数：";
            this.capTxtFamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFamily
            // 
            this.txtFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFamily.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFamily.Location = new System.Drawing.Point(444, 44);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(200, 27);
            this.txtFamily.TabIndex = 1;
            // 
            // capTxtEmail
            // 
            this.capTxtEmail.BackColor = System.Drawing.Color.Transparent;
            this.capTxtEmail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capTxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capTxtEmail.Location = new System.Drawing.Point(20, 80);
            this.capTxtEmail.Name = "capTxtEmail";
            this.capTxtEmail.Size = new System.Drawing.Size(88, 22);
            this.capTxtEmail.TabIndex = 0;
            this.capTxtEmail.Text = "电子邮箱：";
            this.capTxtEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.Location = new System.Drawing.Point(114, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // capTxtRemark
            // 
            this.capTxtRemark.BackColor = System.Drawing.Color.Transparent;
            this.capTxtRemark.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capTxtRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capTxtRemark.Location = new System.Drawing.Point(350, 80);
            this.capTxtRemark.Name = "capTxtRemark";
            this.capTxtRemark.Size = new System.Drawing.Size(88, 22);
            this.capTxtRemark.TabIndex = 0;
            this.capTxtRemark.Text = "备注留言：";
            this.capTxtRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemark.Location = new System.Drawing.Point(444, 80);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(200, 27);
            this.txtRemark.TabIndex = 1;
            // 
            // capTxtNewPassword
            // 
            this.capTxtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.capTxtNewPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capTxtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capTxtNewPassword.Location = new System.Drawing.Point(20, 116);
            this.capTxtNewPassword.Name = "capTxtNewPassword";
            this.capTxtNewPassword.Size = new System.Drawing.Size(72, 22);
            this.capTxtNewPassword.TabIndex = 0;
            this.capTxtNewPassword.Text = "新密码：";
            this.capTxtNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPassword.Location = new System.Drawing.Point(98, 116);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 27);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // capTxtNewPassword2
            // 
            this.capTxtNewPassword2.BackColor = System.Drawing.Color.Transparent;
            this.capTxtNewPassword2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.capTxtNewPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.capTxtNewPassword2.Location = new System.Drawing.Point(350, 116);
            this.capTxtNewPassword2.Name = "capTxtNewPassword2";
            this.capTxtNewPassword2.Size = new System.Drawing.Size(104, 22);
            this.capTxtNewPassword2.TabIndex = 0;
            this.capTxtNewPassword2.Text = "确认新密码：";
            this.capTxtNewPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPassword2.Location = new System.Drawing.Point(460, 116);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.Size = new System.Drawing.Size(200, 27);
            this.txtNewPassword2.TabIndex = 1;
            this.txtNewPassword2.UseSystemPasswordChar = true;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblNote.Location = new System.Drawing.Point(20, 154);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(691, 20);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "姓名、房号等关键信息由物业管理，如需变更请联系物业服务中心。密码留空表示不修改（6-20 位）。";
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
            // OwnerInfoPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "OwnerInfoPage";
            this.Size = new System.Drawing.Size(1030, 660);
            this.pnlRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.Body.ResumeLayout(false);
            this.tipCard.ResumeLayout(false);
            this.tipCard.PerformLayout();
            this.cardProfile.ResumeLayout(false);
            this.cardProfile.PerformLayout();
            this.cardEditable.ResumeLayout(false);
            this.cardEditable.PerformLayout();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblHint;
        private XiaoxinPropertyManager.Common.CardPanel tipCard;
        private System.Windows.Forms.Label lblTip;
        private XiaoxinPropertyManager.Common.CardPanel cardProfile;
        private System.Windows.Forms.Label capLblOwnerName;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label capLblGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label capLblIdCard;
        private System.Windows.Forms.Label lblIdCard;
        private System.Windows.Forms.Label capLblMoveIn;
        private System.Windows.Forms.Label lblMoveIn;
        private System.Windows.Forms.Label capLblBuilding;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label capLblRoomNo;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label capLblArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label capLblLoginName;
        private System.Windows.Forms.Label lblLoginName;
        private XiaoxinPropertyManager.Common.CardPanel cardEditable;
        private System.Windows.Forms.Label capTxtPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label capTxtFamily;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label capTxtEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label capTxtRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label capTxtNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label capTxtNewPassword2;
        private System.Windows.Forms.TextBox txtNewPassword2;
        private System.Windows.Forms.Label lblNote;
    }
}
