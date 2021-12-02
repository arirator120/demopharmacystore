
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class KiemTraTKvaMKcuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemTraTKvaMKcuForm));
            this.picEditOhNo = new DevExpress.XtraEditors.PictureEdit();
            this.lblSaiTaiKhoanMatKhau = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlSaiTaiKhoanMatKhau = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picEditOhNo.Properties)).BeginInit();
            this.pnlSaiTaiKhoanMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // picEditOhNo
            // 
            this.picEditOhNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picEditOhNo.EditValue = ((object)(resources.GetObject("picEditOhNo.EditValue")));
            this.picEditOhNo.Location = new System.Drawing.Point(0, 0);
            this.picEditOhNo.Name = "picEditOhNo";
            this.picEditOhNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picEditOhNo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picEditOhNo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picEditOhNo.Size = new System.Drawing.Size(410, 70);
            this.picEditOhNo.TabIndex = 0;
            // 
            // lblSaiTaiKhoanMatKhau
            // 
            this.lblSaiTaiKhoanMatKhau.AutoSize = true;
            this.lblSaiTaiKhoanMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaiTaiKhoanMatKhau.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSaiTaiKhoanMatKhau.Location = new System.Drawing.Point(83, 73);
            this.lblSaiTaiKhoanMatKhau.Name = "lblSaiTaiKhoanMatKhau";
            this.lblSaiTaiKhoanMatKhau.Size = new System.Drawing.Size(248, 23);
            this.lblSaiTaiKhoanMatKhau.TabIndex = 1;
            this.lblSaiTaiKhoanMatKhau.Text = "Sai tài khoản hoặc mật khẩu !";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.LightCyan;
            this.btnOK.Location = new System.Drawing.Point(172, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 34);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlSaiTaiKhoanMatKhau
            // 
            this.pnlSaiTaiKhoanMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSaiTaiKhoanMatKhau.Controls.Add(this.picEditOhNo);
            this.pnlSaiTaiKhoanMatKhau.Location = new System.Drawing.Point(5, 6);
            this.pnlSaiTaiKhoanMatKhau.Name = "pnlSaiTaiKhoanMatKhau";
            this.pnlSaiTaiKhoanMatKhau.Size = new System.Drawing.Size(412, 143);
            this.pnlSaiTaiKhoanMatKhau.TabIndex = 2;
            // 
            // CheckAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(422, 154);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSaiTaiKhoanMatKhau);
            this.Controls.Add(this.pnlSaiTaiKhoanMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picEditOhNo.Properties)).EndInit();
            this.pnlSaiTaiKhoanMatKhau.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picEditOhNo;
        private System.Windows.Forms.Label lblSaiTaiKhoanMatKhau;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlSaiTaiKhoanMatKhau;
    }
}