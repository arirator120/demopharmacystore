
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class DangNhapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapForm));
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkForgotPass = new System.Windows.Forms.LinkLabel();
            this.picPass = new DevExpress.XtraEditors.PictureEdit();
            this.picUser = new DevExpress.XtraEditors.PictureEdit();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.picEditLogin = new DevExpress.XtraEditors.PictureEdit();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditLogin.Properties)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl1.Location = new System.Drawing.Point(43, 245);
            this.pnl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(225, 1);
            this.pnl1.TabIndex = 2;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl2.Location = new System.Drawing.Point(43, 309);
            this.pnl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(225, 1);
            this.pnl2.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUserName.Location = new System.Drawing.Point(85, 217);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(183, 19);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Tên đăng nhập";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassWord.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPassWord.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPassWord.Location = new System.Drawing.Point(85, 281);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(183, 19);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.Text = "Mật khẩu";
            this.txtPassWord.Enter += new System.EventHandler(this.txtPassWord_Enter);
            this.txtPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassWord_KeyDown);
            this.txtPassWord.Leave += new System.EventHandler(this.txtPassWord_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.LightCyan;
            this.btnLogin.Location = new System.Drawing.Point(43, 392);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkForgotPass
            // 
            this.linkForgotPass.AutoSize = true;
            this.linkForgotPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPass.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.linkForgotPass.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkForgotPass.Location = new System.Drawing.Point(194, 326);
            this.linkForgotPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkForgotPass.Name = "linkForgotPass";
            this.linkForgotPass.Size = new System.Drawing.Size(78, 15);
            this.linkForgotPass.TabIndex = 3;
            this.linkForgotPass.TabStop = true;
            this.linkForgotPass.Text = "Đổi mật khẩu";
            this.linkForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPass_LinkClicked);
            // 
            // picPass
            // 
            this.picPass.EditValue = ((object)(resources.GetObject("picPass.EditValue")));
            this.picPass.Location = new System.Drawing.Point(43, 274);
            this.picPass.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.picPass.MaximumSize = new System.Drawing.Size(28, 31);
            this.picPass.MinimumSize = new System.Drawing.Size(28, 31);
            this.picPass.Name = "picPass";
            this.picPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picPass.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picPass.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picPass.Size = new System.Drawing.Size(28, 31);
            this.picPass.TabIndex = 4;
            // 
            // picUser
            // 
            this.picUser.EditValue = ((object)(resources.GetObject("picUser.EditValue")));
            this.picUser.Location = new System.Drawing.Point(43, 210);
            this.picUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picUser.MaximumSize = new System.Drawing.Size(28, 31);
            this.picUser.MinimumSize = new System.Drawing.Size(28, 31);
            this.picUser.Name = "picUser";
            this.picUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picUser.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picUser.Properties.ZoomPercent = 50D;
            this.picUser.Size = new System.Drawing.Size(28, 31);
            this.picUser.TabIndex = 4;
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.BackColor = System.Drawing.Color.White;
            this.chkShowPass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkShowPass.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chkShowPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPass.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.chkShowPass.Location = new System.Drawing.Point(43, 325);
            this.chkShowPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(104, 19);
            this.chkShowPass.TabIndex = 2;
            this.chkShowPass.Text = "Hiện mật khẩu";
            this.chkShowPass.UseVisualStyleBackColor = false;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // picEditLogin
            // 
            this.picEditLogin.EditValue = ((object)(resources.GetObject("picEditLogin.EditValue")));
            this.picEditLogin.Location = new System.Drawing.Point(42, 54);
            this.picEditLogin.Name = "picEditLogin";
            this.picEditLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picEditLogin.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picEditLogin.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picEditLogin.Size = new System.Drawing.Size(225, 122);
            this.picEditLogin.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LightCyan;
            this.btnExit.Location = new System.Drawing.Point(160, 391);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.btnExit);
            this.pnlLogin.Controls.Add(this.picEditLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(315, 505);
            this.pnlLogin.TabIndex = 15;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 505);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.linkForgotPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnlLogin);
            this.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.picPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditLogin.Properties)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkForgotPass;
        private DevExpress.XtraEditors.PictureEdit picPass;
        private DevExpress.XtraEditors.PictureEdit picUser;
        private System.Windows.Forms.CheckBox chkShowPass;
        private DevExpress.XtraEditors.PictureEdit picEditLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlLogin;
    }
}