namespace XiaoxinPropertyManager.Forms
{
    partial class RegisterForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.cboBuilding = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd2 = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.lblCaptchaText = new System.Windows.Forms.Label();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.lnkRefresh = new System.Windows.Forms.LinkLabel();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(38, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "注册业主账号";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.Transparent;
            this.lblTip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblTip.Location = new System.Drawing.Point(40, 52);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(384, 20);
            this.lblTip.TabIndex = 1;
            this.lblTip.Text = "账号与物业登记的住户档案绑定，注册后可用手机号登录";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblName.Location = new System.Drawing.Point(40, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtName.Location = new System.Drawing.Point(126, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 27);
            this.txtName.TabIndex = 0;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblPhone.Location = new System.Drawing.Point(40, 128);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 25);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "手机号：";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtPhone.Location = new System.Drawing.Point(126, 128);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 27);
            this.txtPhone.TabIndex = 1;
            // 
            // lblBuilding
            // 
            this.lblBuilding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBuilding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblBuilding.Location = new System.Drawing.Point(40, 164);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(80, 25);
            this.lblBuilding.TabIndex = 4;
            this.lblBuilding.Text = "楼栋：";
            this.lblBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboBuilding
            // 
            this.cboBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuilding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboBuilding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.cboBuilding.FormattingEnabled = true;
            this.cboBuilding.Location = new System.Drawing.Point(126, 164);
            this.cboBuilding.Name = "cboBuilding";
            this.cboBuilding.Size = new System.Drawing.Size(240, 28);
            this.cboBuilding.TabIndex = 2;
            // 
            // lblRoom
            // 
            this.lblRoom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblRoom.Location = new System.Drawing.Point(40, 200);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(80, 25);
            this.lblRoom.TabIndex = 5;
            this.lblRoom.Text = "门牌号：";
            this.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoom
            // 
            this.txtRoom.BackColor = System.Drawing.Color.White;
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtRoom.Location = new System.Drawing.Point(126, 200);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(240, 27);
            this.txtRoom.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblEmail.Location = new System.Drawing.Point(40, 236);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 25);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "邮箱：";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtEmail.Location = new System.Drawing.Point(126, 236);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 27);
            this.txtEmail.TabIndex = 4;
            // 
            // lblPwd
            // 
            this.lblPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblPwd.Location = new System.Drawing.Point(40, 272);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(80, 25);
            this.lblPwd.TabIndex = 7;
            this.lblPwd.Text = "设置密码：";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtPwd.Location = new System.Drawing.Point(126, 272);
            this.txtPwd.MaxLength = 20;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(240, 27);
            this.txtPwd.TabIndex = 5;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPwd2
            // 
            this.lblPwd2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblPwd2.Location = new System.Drawing.Point(40, 308);
            this.lblPwd2.Name = "lblPwd2";
            this.lblPwd2.Size = new System.Drawing.Size(80, 25);
            this.lblPwd2.TabIndex = 8;
            this.lblPwd2.Text = "确认密码：";
            this.lblPwd2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPwd2
            // 
            this.txtPwd2.BackColor = System.Drawing.Color.White;
            this.txtPwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtPwd2.Location = new System.Drawing.Point(126, 308);
            this.txtPwd2.MaxLength = 20;
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Size = new System.Drawing.Size(240, 27);
            this.txtPwd2.TabIndex = 6;
            this.txtPwd2.UseSystemPasswordChar = true;
            // 
            // lblCaptchaText
            // 
            this.lblCaptchaText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaptchaText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblCaptchaText.Location = new System.Drawing.Point(40, 344);
            this.lblCaptchaText.Name = "lblCaptchaText";
            this.lblCaptchaText.Size = new System.Drawing.Size(80, 25);
            this.lblCaptchaText.TabIndex = 9;
            this.lblCaptchaText.Text = "验证码：";
            this.lblCaptchaText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.BackColor = System.Drawing.Color.White;
            this.txtCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaptcha.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.txtCaptcha.Location = new System.Drawing.Point(126, 344);
            this.txtCaptcha.MaxLength = 6;
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(110, 27);
            this.txtCaptcha.TabIndex = 7;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.lblCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptcha.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lblCaptcha.Location = new System.Drawing.Point(244, 344);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(76, 25);
            this.lblCaptcha.TabIndex = 10;
            this.lblCaptcha.Text = "----";
            this.lblCaptcha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.lnkRefresh.AutoSize = true;
            this.lnkRefresh.BackColor = System.Drawing.Color.Transparent;
            this.lnkRefresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkRefresh.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRefresh.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lnkRefresh.Location = new System.Drawing.Point(328, 348);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(54, 20);
            this.lnkRefresh.TabIndex = 8;
            this.lnkRefresh.TabStop = true;
            this.lnkRefresh.Text = "换一张";
            this.lnkRefresh.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.lnkRefresh.Click += new System.EventHandler(this.LnkRefreshClick);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.lblNote.Location = new System.Drawing.Point(40, 376);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(354, 20);
            this.lblNote.TabIndex = 11;
            this.lblNote.Text = "门牌号请按物业登记格式填写，例如：1栋1单元101";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btnCancel.Location = new System.Drawing.Point(213, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(302, 412);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(92, 32);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "立即注册";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegisterClick);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(430, 456);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.cboBuilding);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd2);
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.lblCaptchaText);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.lblCaptcha);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注册业主账号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.ComboBox cboBuilding;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd2;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Label lblCaptchaText;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.LinkLabel lnkRefresh;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
    }
}
