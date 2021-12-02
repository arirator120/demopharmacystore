
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class KiemTraXacNhanMKMoiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemTraXacNhanMKMoiForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTrungMatKhau = new System.Windows.Forms.Label();
            this.pnlXacNhanSai = new System.Windows.Forms.Panel();
            this.picEditOhNo = new DevExpress.XtraEditors.PictureEdit();
            this.pnlXacNhanSai.SuspendLayout();
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
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTrungMatKhau
            // 
            this.lblTrungMatKhau.AutoSize = true;
            this.lblTrungMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrungMatKhau.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTrungMatKhau.Location = new System.Drawing.Point(28, 73);
            this.lblTrungMatKhau.Name = "lblTrungMatKhau";
            this.lblTrungMatKhau.Size = new System.Drawing.Size(364, 23);
            this.lblTrungMatKhau.TabIndex = 7;
            this.lblTrungMatKhau.Text = "Xác nhận mật khẩu mới không trùng khớp !";
            // 
            // pnlXacNhanSai
            // 
            this.pnlXacNhanSai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlXacNhanSai.Controls.Add(this.picEditOhNo);
            this.pnlXacNhanSai.Location = new System.Drawing.Point(5, 6);
            this.pnlXacNhanSai.Name = "pnlXacNhanSai";
            this.pnlXacNhanSai.Size = new System.Drawing.Size(412, 143);
            this.pnlXacNhanSai.TabIndex = 9;
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
            // CheckMatchNewPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 154);
            this.Controls.Add(this.lblTrungMatKhau);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlXacNhanSai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckMatchNewPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckMatchNewPForm";
            this.pnlXacNhanSai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEditOhNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTrungMatKhau;
        private System.Windows.Forms.Panel pnlXacNhanSai;
        private DevExpress.XtraEditors.PictureEdit picEditOhNo;
    }
}