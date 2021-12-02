
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class KiemTraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemTraForm));
            this.picEditOhNo = new DevExpress.XtraEditors.PictureEdit();
            this.lblNhapDayDuTT = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlNhapDayDuTT = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picEditOhNo.Properties)).BeginInit();
            this.pnlNhapDayDuTT.SuspendLayout();
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
            // lblNhapDayDuTT
            // 
            this.lblNhapDayDuTT.AutoSize = true;
            this.lblNhapDayDuTT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapDayDuTT.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNhapDayDuTT.Location = new System.Drawing.Point(68, 66);
            this.lblNhapDayDuTT.Name = "lblNhapDayDuTT";
            this.lblNhapDayDuTT.Size = new System.Drawing.Size(273, 23);
            this.lblNhapDayDuTT.TabIndex = 11;
            this.lblNhapDayDuTT.Text = "Vui lòng nhập đầy đủ thông tin !";
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
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlNhapDayDuTT
            // 
            this.pnlNhapDayDuTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNhapDayDuTT.Controls.Add(this.lblNhapDayDuTT);
            this.pnlNhapDayDuTT.Controls.Add(this.picEditOhNo);
            this.pnlNhapDayDuTT.Location = new System.Drawing.Point(5, 6);
            this.pnlNhapDayDuTT.Name = "pnlNhapDayDuTT";
            this.pnlNhapDayDuTT.Size = new System.Drawing.Size(412, 143);
            this.pnlNhapDayDuTT.TabIndex = 12;
            // 
            // KiemTraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 154);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlNhapDayDuTT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KiemTraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiemTraForm";
            ((System.ComponentModel.ISupportInitialize)(this.picEditOhNo.Properties)).EndInit();
            this.pnlNhapDayDuTT.ResumeLayout(false);
            this.pnlNhapDayDuTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picEditOhNo;
        private System.Windows.Forms.Label lblNhapDayDuTT;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlNhapDayDuTT;
    }
}