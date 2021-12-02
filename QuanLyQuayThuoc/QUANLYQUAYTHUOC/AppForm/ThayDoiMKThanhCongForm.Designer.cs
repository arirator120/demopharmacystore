
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class ThayDoiMKThanhCongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThayDoiMKThanhCongForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.lblLoiTrungMatKhau = new System.Windows.Forms.Label();
            this.pnlLoiTrungMatKhau = new System.Windows.Forms.Panel();
            this.picEditOhNo = new DevExpress.XtraEditors.PictureEdit();
            this.pnlLoiTrungMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditOhNo.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblLoiTrungMatKhau
            // 
            this.lblLoiTrungMatKhau.AutoSize = true;
            this.lblLoiTrungMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiTrungMatKhau.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLoiTrungMatKhau.Location = new System.Drawing.Point(78, 73);
            this.lblLoiTrungMatKhau.Name = "lblLoiTrungMatKhau";
            this.lblLoiTrungMatKhau.Size = new System.Drawing.Size(266, 23);
            this.lblLoiTrungMatKhau.TabIndex = 12;
            this.lblLoiTrungMatKhau.Text = "Thay đổi mật khẩu thành công !";
            // 
            // pnlLoiTrungMatKhau
            // 
            this.pnlLoiTrungMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoiTrungMatKhau.Controls.Add(this.picEditOhNo);
            this.pnlLoiTrungMatKhau.Location = new System.Drawing.Point(5, 6);
            this.pnlLoiTrungMatKhau.Name = "pnlLoiTrungMatKhau";
            this.pnlLoiTrungMatKhau.Size = new System.Drawing.Size(412, 143);
            this.pnlLoiTrungMatKhau.TabIndex = 13;
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
            // ThayDoiMKThanhCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 154);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblLoiTrungMatKhau);
            this.Controls.Add(this.pnlLoiTrungMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThayDoiMKThanhCongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThayDoiMKThanhCongForm";
            this.pnlLoiTrungMatKhau.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEditOhNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblLoiTrungMatKhau;
        private System.Windows.Forms.Panel pnlLoiTrungMatKhau;
        private DevExpress.XtraEditors.PictureEdit picEditOhNo;
    }
}