
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class ThongTinCaNhanForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinCaNhanForm));
            this.pnl = new DevExpress.Utils.Layout.TablePanel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNgayVao = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblNgayVao = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.picHinh = new DevExpress.XtraEditors.PictureEdit();
            this.lblTTND = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).BeginInit();
            this.pnl.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.pnl.Controls.Add(this.pnl2);
            this.pnl.Controls.Add(this.pnl1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 65F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.pnl.Size = new System.Drawing.Size(1920, 820);
            this.pnl.TabIndex = 0;
            // 
            // pnl2
            // 
            this.pnl.SetColumn(this.pnl2, 0);
            this.pnl2.Controls.Add(this.btnCapNhat);
            this.pnl2.Controls.Add(this.txtTen);
            this.pnl2.Controls.Add(this.txtChucVu);
            this.pnl2.Controls.Add(this.txtLuong);
            this.pnl2.Controls.Add(this.txtDiaChi);
            this.pnl2.Controls.Add(this.txtNgayVao);
            this.pnl2.Controls.Add(this.txtSDT);
            this.pnl2.Controls.Add(this.txtCMND);
            this.pnl2.Controls.Add(this.txtGioiTinh);
            this.pnl2.Controls.Add(this.txtNgaySinh);
            this.pnl2.Controls.Add(this.txtMaNV);
            this.pnl2.Controls.Add(this.lblChucVu);
            this.pnl2.Controls.Add(this.lblLuong);
            this.pnl2.Controls.Add(this.lblNgayVao);
            this.pnl2.Controls.Add(this.lblDiaChi);
            this.pnl2.Controls.Add(this.lblSDT);
            this.pnl2.Controls.Add(this.lblCMND);
            this.pnl2.Controls.Add(this.lblGioiTinh);
            this.pnl2.Controls.Add(this.lblNgaySinh);
            this.pnl2.Controls.Add(this.lblTen);
            this.pnl2.Controls.Add(this.lblMaNV);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(3, 68);
            this.pnl2.Name = "pnl2";
            this.pnl.SetRow(this.pnl2, 1);
            this.pnl2.Size = new System.Drawing.Size(1914, 749);
            this.pnl2.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Appearance.Options.UseForeColor = true;
            this.btnCapNhat.Location = new System.Drawing.Point(1067, 346);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(661, 40);
            this.btnCapNhat.TabIndex = 32;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(66, 99);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(658, 29);
            this.txtTen.TabIndex = 22;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(1067, 227);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(661, 29);
            this.txtChucVu.TabIndex = 28;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(1067, 164);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(661, 29);
            this.txtLuong.TabIndex = 27;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(1068, 35);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(661, 29);
            this.txtDiaChi.TabIndex = 26;
            // 
            // txtNgayVao
            // 
            this.txtNgayVao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayVao.Location = new System.Drawing.Point(1067, 99);
            this.txtNgayVao.Name = "txtNgayVao";
            this.txtNgayVao.Size = new System.Drawing.Size(661, 29);
            this.txtNgayVao.TabIndex = 26;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(66, 357);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(658, 29);
            this.txtSDT.TabIndex = 25;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(66, 294);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(658, 29);
            this.txtCMND.TabIndex = 24;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(66, 231);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(658, 29);
            this.txtGioiTinh.TabIndex = 23;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(66, 166);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(658, 29);
            this.txtNgaySinh.TabIndex = 30;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(66, 35);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(658, 29);
            this.txtMaNV.TabIndex = 29;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblChucVu.Location = new System.Drawing.Point(1064, 203);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(74, 21);
            this.lblChucVu.TabIndex = 21;
            this.lblChucVu.Text = "Chức Vụ";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLuong.Location = new System.Drawing.Point(1064, 140);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(126, 21);
            this.lblLuong.TabIndex = 13;
            this.lblLuong.Text = "Lương Hiện Tại";
            // 
            // lblNgayVao
            // 
            this.lblNgayVao.AutoSize = true;
            this.lblNgayVao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayVao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNgayVao.Location = new System.Drawing.Point(1064, 75);
            this.lblNgayVao.Name = "lblNgayVao";
            this.lblNgayVao.Size = new System.Drawing.Size(84, 21);
            this.lblNgayVao.TabIndex = 20;
            this.lblNgayVao.Text = "Ngày Vào";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDiaChi.Location = new System.Drawing.Point(1065, 11);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(65, 21);
            this.lblDiaChi.TabIndex = 19;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSDT.Location = new System.Drawing.Point(63, 333);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(40, 21);
            this.lblSDT.TabIndex = 18;
            this.lblSDT.Text = "SĐT";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCMND.Location = new System.Drawing.Point(63, 270);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(60, 21);
            this.lblCMND.TabIndex = 17;
            this.lblCMND.Text = "CMND";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGioiTinh.Location = new System.Drawing.Point(63, 207);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(79, 21);
            this.lblGioiTinh.TabIndex = 16;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNgaySinh.Location = new System.Drawing.Point(63, 142);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(89, 21);
            this.lblNgaySinh.TabIndex = 15;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTen.Location = new System.Drawing.Point(63, 75);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(97, 21);
            this.lblTen.TabIndex = 14;
            this.lblTen.Text = "Tên Đầy Đủ";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMaNV.Location = new System.Drawing.Point(63, 11);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(119, 21);
            this.lblMaNV.TabIndex = 11;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl.SetColumn(this.pnl1, 0);
            this.pnl1.Controls.Add(this.picHinh);
            this.pnl1.Controls.Add(this.lblTTND);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(3, 3);
            this.pnl1.Name = "pnl1";
            this.pnl.SetRow(this.pnl1, 0);
            this.pnl1.Size = new System.Drawing.Size(1914, 59);
            this.pnl1.TabIndex = 0;
            // 
            // picHinh
            // 
            this.picHinh.EditValue = ((object)(resources.GetObject("picHinh.EditValue")));
            this.picHinh.Location = new System.Drawing.Point(23, 4);
            this.picHinh.Name = "picHinh";
            this.picHinh.Properties.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picHinh.Properties.Appearance.Options.UseBackColor = true;
            this.picHinh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picHinh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picHinh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picHinh.Size = new System.Drawing.Size(54, 53);
            this.picHinh.TabIndex = 12;
            // 
            // lblTTND
            // 
            this.lblTTND.AutoSize = true;
            this.lblTTND.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTND.ForeColor = System.Drawing.Color.White;
            this.lblTTND.Location = new System.Drawing.Point(93, 17);
            this.lblTTND.Name = "lblTTND";
            this.lblTTND.Size = new System.Drawing.Size(220, 25);
            this.lblTTND.TabIndex = 9;
            this.lblTTND.Text = "Thông Tin Người Dùng";
            // 
            // ThongTinCaNhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl);
            this.Name = "ThongTinCaNhanForm";
            this.Size = new System.Drawing.Size(1920, 820);
            this.Load += new System.EventHandler(this.ThongTinCaNhanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnl)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel pnl;
        private System.Windows.Forms.Panel pnl2;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtNgayVao;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblNgayVao;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Panel pnl1;
        private DevExpress.XtraEditors.PictureEdit picHinh;
        private System.Windows.Forms.Label lblTTND;
        private System.Windows.Forms.TextBox txtDiaChi;
    }
}
