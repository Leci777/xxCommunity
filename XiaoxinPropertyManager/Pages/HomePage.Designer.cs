namespace XiaoxinPropertyManager.Pages
{
    partial class HomePage
    {
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGreeting = new System.Windows.Forms.Panel();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.cardRow = new System.Windows.Forms.TableLayoutPanel();
            this.card1 = new XiaoxinPropertyManager.Common.StatCard();
            this.card2 = new XiaoxinPropertyManager.Common.StatCard();
            this.card3 = new XiaoxinPropertyManager.Common.StatCard();
            this.card4 = new XiaoxinPropertyManager.Common.StatCard();
            this.split = new System.Windows.Forms.TableLayoutPanel();
            this.featureCard = new XiaoxinPropertyManager.Common.CardPanel();
            this.gridFeature = new System.Windows.Forms.DataGridView();
            this.Feature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticeCard = new XiaoxinPropertyManager.Common.CardPanel();
            this.gridNotice = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.root.SuspendLayout();
            this.pnlGreeting.SuspendLayout();
            this.cardRow.SuspendLayout();
            this.split.SuspendLayout();
            this.featureCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFeature)).BeginInit();
            this.noticeCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.pnlGreeting, 0, 0);
            this.root.Controls.Add(this.cardRow, 0, 1);
            this.root.Controls.Add(this.split, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Margin = new System.Windows.Forms.Padding(0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(24, 20, 24, 14);
            this.root.RowCount = 3;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1030, 660);
            this.root.TabIndex = 0;
            // 
            // pnlGreeting
            // 
            this.pnlGreeting.BackColor = System.Drawing.Color.Transparent;
            this.pnlGreeting.Controls.Add(this.lblGreeting);
            this.pnlGreeting.Controls.Add(this.lblSubtitle);
            this.pnlGreeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGreeting.Location = new System.Drawing.Point(24, 20);
            this.pnlGreeting.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGreeting.Name = "pnlGreeting";
            this.pnlGreeting.Size = new System.Drawing.Size(982, 62);
            this.pnlGreeting.TabIndex = 0;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblGreeting.Location = new System.Drawing.Point(0, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(62, 31);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "您好";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblSubtitle.Location = new System.Drawing.Point(1, 32);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(0, 20);
            this.lblSubtitle.TabIndex = 1;
            // 
            // cardRow
            // 
            this.cardRow.ColumnCount = 4;
            this.cardRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardRow.Controls.Add(this.card1, 0, 0);
            this.cardRow.Controls.Add(this.card2, 1, 0);
            this.cardRow.Controls.Add(this.card3, 2, 0);
            this.cardRow.Controls.Add(this.card4, 3, 0);
            this.cardRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRow.Location = new System.Drawing.Point(24, 82);
            this.cardRow.Margin = new System.Windows.Forms.Padding(0);
            this.cardRow.Name = "cardRow";
            this.cardRow.RowCount = 1;
            this.cardRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardRow.Size = new System.Drawing.Size(982, 116);
            this.cardRow.TabIndex = 1;
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.White;
            this.card1.Caption = "住户总数";
            this.card1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card1.Location = new System.Drawing.Point(0, 0);
            this.card1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 14);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(233, 102);
            this.card1.TabIndex = 0;
            this.card1.Unit = "户";
            this.card1.Value = "—";
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.White;
            this.card2.Caption = "待处理报修";
            this.card2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card2.Location = new System.Drawing.Point(245, 0);
            this.card2.Margin = new System.Windows.Forms.Padding(0, 0, 12, 14);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(233, 102);
            this.card2.TabIndex = 0;
            this.card2.Unit = "单";
            this.card2.Value = "—";
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.White;
            this.card3.Caption = "未缴费用";
            this.card3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card3.Location = new System.Drawing.Point(490, 0);
            this.card3.Margin = new System.Windows.Forms.Padding(0, 0, 12, 14);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(233, 102);
            this.card3.TabIndex = 0;
            this.card3.Unit = "笔";
            this.card3.Value = "—";
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.White;
            this.card4.Caption = "空闲车位";
            this.card4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card4.Location = new System.Drawing.Point(735, 0);
            this.card4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(247, 102);
            this.card4.TabIndex = 0;
            this.card4.Unit = "个";
            this.card4.Value = "—";
            // 
            // split
            // 
            this.split.ColumnCount = 2;
            this.split.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.split.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.split.Controls.Add(this.featureCard, 0, 0);
            this.split.Controls.Add(this.noticeCard, 1, 0);
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(24, 198);
            this.split.Margin = new System.Windows.Forms.Padding(0);
            this.split.Name = "split";
            this.split.RowCount = 1;
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.split.Size = new System.Drawing.Size(982, 448);
            this.split.TabIndex = 2;
            // 
            // featureCard
            // 
            this.featureCard.BackColor = System.Drawing.Color.White;
            this.featureCard.Caption = "功能介绍";
            this.featureCard.Controls.Add(this.gridFeature);
            this.featureCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featureCard.Location = new System.Drawing.Point(0, 0);
            this.featureCard.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.featureCard.Name = "featureCard";
            this.featureCard.Padding = new System.Windows.Forms.Padding(1, 44, 1, 1);
            this.featureCard.Size = new System.Drawing.Size(557, 448);
            this.featureCard.TabIndex = 0;
            // 
            // gridFeature
            // 
            this.gridFeature.AllowUserToAddRows = false;
            this.gridFeature.AllowUserToDeleteRows = false;
            this.gridFeature.AllowUserToResizeRows = false;
            this.gridFeature.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFeature.BackgroundColor = System.Drawing.Color.White;
            this.gridFeature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFeature.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridFeature.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.gridFeature.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridFeature.ColumnHeadersHeight = 36;
            this.gridFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridFeature.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Feature,
            this.Summary});
            this.gridFeature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFeature.EnableHeadersVisualStyles = false;
            this.gridFeature.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.gridFeature.Location = new System.Drawing.Point(1, 44);
            this.gridFeature.MultiSelect = false;
            this.gridFeature.Name = "gridFeature";
            this.gridFeature.ReadOnly = true;
            this.gridFeature.RowHeadersVisible = false;
            this.gridFeature.RowHeadersWidth = 51;
            this.gridFeature.RowTemplate.Height = 30;
            this.gridFeature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridFeature.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFeature.Size = new System.Drawing.Size(555, 403);
            this.gridFeature.TabIndex = 0;
            // 
            // Feature
            // 
            this.Feature.DataPropertyName = "Feature";
            this.Feature.FillWeight = 110F;
            this.Feature.HeaderText = "功能";
            this.Feature.MinimumWidth = 60;
            this.Feature.Name = "Feature";
            this.Feature.ReadOnly = true;
            // 
            // Summary
            // 
            this.Summary.DataPropertyName = "Summary";
            this.Summary.FillWeight = 300F;
            this.Summary.HeaderText = "功能简介";
            this.Summary.MinimumWidth = 60;
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            // 
            // noticeCard
            // 
            this.noticeCard.BackColor = System.Drawing.Color.White;
            this.noticeCard.Caption = "最新公告";
            this.noticeCard.Controls.Add(this.gridNotice);
            this.noticeCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noticeCard.Location = new System.Drawing.Point(569, 0);
            this.noticeCard.Margin = new System.Windows.Forms.Padding(0);
            this.noticeCard.Name = "noticeCard";
            this.noticeCard.Padding = new System.Windows.Forms.Padding(1, 44, 1, 1);
            this.noticeCard.Size = new System.Drawing.Size(413, 448);
            this.noticeCard.TabIndex = 1;
            // 
            // gridNotice
            // 
            this.gridNotice.AllowUserToAddRows = false;
            this.gridNotice.AllowUserToDeleteRows = false;
            this.gridNotice.AllowUserToResizeRows = false;
            this.gridNotice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNotice.BackgroundColor = System.Drawing.Color.White;
            this.gridNotice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNotice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridNotice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.gridNotice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridNotice.ColumnHeadersHeight = 36;
            this.gridNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridNotice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.PublishTime});
            this.gridNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNotice.EnableHeadersVisualStyles = false;
            this.gridNotice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.gridNotice.Location = new System.Drawing.Point(1, 44);
            this.gridNotice.MultiSelect = false;
            this.gridNotice.Name = "gridNotice";
            this.gridNotice.ReadOnly = true;
            this.gridNotice.RowHeadersVisible = false;
            this.gridNotice.RowHeadersWidth = 51;
            this.gridNotice.RowTemplate.Height = 30;
            this.gridNotice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridNotice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNotice.Size = new System.Drawing.Size(411, 403);
            this.gridNotice.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 260F;
            this.Title.HeaderText = "公告标题";
            this.Title.MinimumWidth = 60;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // PublishTime
            // 
            this.PublishTime.DataPropertyName = "PublishTime";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PublishTime.DefaultCellStyle = dataGridViewCellStyle9;
            this.PublishTime.HeaderText = "发布时间";
            this.PublishTime.MinimumWidth = 60;
            this.PublishTime.Name = "PublishTime";
            this.PublishTime.ReadOnly = true;
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.root);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1030, 660);
            this.root.ResumeLayout(false);
            this.pnlGreeting.ResumeLayout(false);
            this.pnlGreeting.PerformLayout();
            this.cardRow.ResumeLayout(false);
            this.split.ResumeLayout(false);
            this.featureCard.ResumeLayout(false);
            this.featureCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFeature)).EndInit();
            this.noticeCard.ResumeLayout(false);
            this.noticeCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotice)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.Panel pnlGreeting;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TableLayoutPanel cardRow;
        private System.Windows.Forms.TableLayoutPanel split;
        private XiaoxinPropertyManager.Common.CardPanel featureCard;
        private XiaoxinPropertyManager.Common.CardPanel noticeCard;
        private XiaoxinPropertyManager.Common.StatCard card1;
        private XiaoxinPropertyManager.Common.StatCard card2;
        private XiaoxinPropertyManager.Common.StatCard card3;
        private XiaoxinPropertyManager.Common.StatCard card4;
        private System.Windows.Forms.DataGridView gridFeature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summary;
        private System.Windows.Forms.DataGridView gridNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishTime;
    }
}
