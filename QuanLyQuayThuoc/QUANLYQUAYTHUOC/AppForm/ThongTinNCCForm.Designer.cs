
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class ThongTinNCCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinNCCForm));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.grdctlThongTinNCC = new DevExpress.XtraGrid.GridControl();
            this.grdwThongTinNCC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlTask = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pblThemThongTinNCC = new System.Windows.Forms.Panel();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenNhaCungCap = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblThemThongTinNCC = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.picEditNhaCungCap = new DevExpress.XtraEditors.PictureEdit();
            this.pnlThongTinNCC = new System.Windows.Forms.Panel();
            this.lblThongTinNCC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdctlThongTinNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwThongTinNCC)).BeginInit();
            this.pnlTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditNhaCungCap.Properties)).BeginInit();
            this.pnlThongTinNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15.2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 44.8F)});
            this.tablePanel1.Controls.Add(this.grdctlThongTinNCC);
            this.tablePanel1.Controls.Add(this.pnlTask);
            this.tablePanel1.Controls.Add(this.pnlThongTinNCC);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 78.79975F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1531, 622);
            this.tablePanel1.TabIndex = 0;
            // 
            // grdctlThongTinNCC
            // 
            this.tablePanel1.SetColumn(this.grdctlThongTinNCC, 1);
            this.grdctlThongTinNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdctlThongTinNCC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdctlThongTinNCC.Location = new System.Drawing.Point(391, 81);
            this.grdctlThongTinNCC.MainView = this.grdwThongTinNCC;
            this.grdctlThongTinNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdctlThongTinNCC.Name = "grdctlThongTinNCC";
            this.tablePanel1.SetRow(this.grdctlThongTinNCC, 1);
            this.grdctlThongTinNCC.Size = new System.Drawing.Size(1137, 539);
            this.grdctlThongTinNCC.TabIndex = 3;
            this.grdctlThongTinNCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdwThongTinNCC});
            this.grdctlThongTinNCC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdctlThongTinNCC_KeyDown);
            // 
            // grdwThongTinNCC
            // 
            this.grdwThongTinNCC.DetailHeight = 268;
            this.grdwThongTinNCC.GridControl = this.grdctlThongTinNCC;
            this.grdwThongTinNCC.Name = "grdwThongTinNCC";
            // 
            // pnlTask
            // 
            this.pnlTask.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tablePanel1.SetColumn(this.pnlTask, 0);
            this.pnlTask.Controls.Add(this.btnXoa);
            this.pnlTask.Controls.Add(this.btnLamMoi);
            this.pnlTask.Controls.Add(this.btnThem);
            this.pnlTask.Controls.Add(this.pblThemThongTinNCC);
            this.pnlTask.Controls.Add(this.txtTenNhaCungCap);
            this.pnlTask.Controls.Add(this.txtDiaChi);
            this.pnlTask.Controls.Add(this.txtSoDienThoai);
            this.pnlTask.Controls.Add(this.txtMaNhaCungCap);
            this.pnlTask.Controls.Add(this.lblDiaChi);
            this.pnlTask.Controls.Add(this.lblTenNhaCungCap);
            this.pnlTask.Controls.Add(this.lblSoDienThoai);
            this.pnlTask.Controls.Add(this.lblThemThongTinNCC);
            this.pnlTask.Controls.Add(this.lblMaNCC);
            this.pnlTask.Controls.Add(this.picEditNhaCungCap);
            this.pnlTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTask.Location = new System.Drawing.Point(3, 81);
            this.pnlTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTask.Name = "pnlTask";
            this.tablePanel1.SetRow(this.pnlTask, 1);
            this.tablePanel1.SetRowSpan(this.pnlTask, 2);
            this.pnlTask.Size = new System.Drawing.Size(382, 539);
            this.pnlTask.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Location = new System.Drawing.Point(109, 464);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 38);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLamMoi.Location = new System.Drawing.Point(198, 406);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(160, 38);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Location = new System.Drawing.Point(24, 406);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 38);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pblThemThongTinNCC
            // 
            this.pblThemThongTinNCC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pblThemThongTinNCC.Location = new System.Drawing.Point(24, 183);
            this.pblThemThongTinNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pblThemThongTinNCC.Name = "pblThemThongTinNCC";
            this.pblThemThongTinNCC.Size = new System.Drawing.Size(334, 1);
            this.pblThemThongTinNCC.TabIndex = 5;
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(198, 225);
            this.txtTenNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(161, 27);
            this.txtTenNhaCungCap.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(24, 349);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(335, 27);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(24, 286);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(335, 27);
            this.txtSoDienThoai.TabIndex = 2;
            // 
            // txtMaNhaCungCap
            // 
            this.txtMaNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(24, 225);
            this.txtMaNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(161, 27);
            this.txtMaNhaCungCap.TabIndex = 0;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.White;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 323);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(63, 21);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblTenNhaCungCap
            // 
            this.lblTenNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenNhaCungCap.AutoSize = true;
            this.lblTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhaCungCap.ForeColor = System.Drawing.Color.White;
            this.lblTenNhaCungCap.Location = new System.Drawing.Point(194, 199);
            this.lblTenNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTenNhaCungCap.Name = "lblTenNhaCungCap";
            this.lblTenNhaCungCap.Size = new System.Drawing.Size(143, 21);
            this.lblTenNhaCungCap.TabIndex = 4;
            this.lblTenNhaCungCap.Text = "Tên nhà cung cấp";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.White;
            this.lblSoDienThoai.Location = new System.Drawing.Point(20, 260);
            this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(111, 21);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại";
            // 
            // lblThemThongTinNCC
            // 
            this.lblThemThongTinNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThemThongTinNCC.AutoSize = true;
            this.lblThemThongTinNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemThongTinNCC.ForeColor = System.Drawing.Color.White;
            this.lblThemThongTinNCC.Location = new System.Drawing.Point(20, 157);
            this.lblThemThongTinNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblThemThongTinNCC.Name = "lblThemThongTinNCC";
            this.lblThemThongTinNCC.Size = new System.Drawing.Size(234, 21);
            this.lblThemThongTinNCC.TabIndex = 4;
            this.lblThemThongTinNCC.Text = "Thêm thông tin nhà cung cấp";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.ForeColor = System.Drawing.Color.White;
            this.lblMaNCC.Location = new System.Drawing.Point(20, 199);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(140, 21);
            this.lblMaNCC.TabIndex = 4;
            this.lblMaNCC.Text = "Mã nhà cung cấp";
            // 
            // picEditNhaCungCap
            // 
            this.picEditNhaCungCap.EditValue = ((object)(resources.GetObject("picEditNhaCungCap.EditValue")));
            this.picEditNhaCungCap.Location = new System.Drawing.Point(141, 40);
            this.picEditNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEditNhaCungCap.Name = "picEditNhaCungCap";
            this.picEditNhaCungCap.Properties.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picEditNhaCungCap.Properties.Appearance.Options.UseBackColor = true;
            this.picEditNhaCungCap.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picEditNhaCungCap.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picEditNhaCungCap.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picEditNhaCungCap.Size = new System.Drawing.Size(101, 106);
            this.picEditNhaCungCap.TabIndex = 0;
            // 
            // pnlThongTinNCC
            // 
            this.pnlThongTinNCC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tablePanel1.SetColumn(this.pnlThongTinNCC, 0);
            this.tablePanel1.SetColumnSpan(this.pnlThongTinNCC, 2);
            this.pnlThongTinNCC.Controls.Add(this.lblThongTinNCC);
            this.pnlThongTinNCC.Location = new System.Drawing.Point(3, 11);
            this.pnlThongTinNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlThongTinNCC.Name = "pnlThongTinNCC";
            this.tablePanel1.SetRow(this.pnlThongTinNCC, 0);
            this.pnlThongTinNCC.Size = new System.Drawing.Size(1525, 56);
            this.pnlThongTinNCC.TabIndex = 0;
            // 
            // lblThongTinNCC
            // 
            this.lblThongTinNCC.AutoSize = true;
            this.lblThongTinNCC.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinNCC.ForeColor = System.Drawing.Color.White;
            this.lblThongTinNCC.Location = new System.Drawing.Point(609, 9);
            this.lblThongTinNCC.Name = "lblThongTinNCC";
            this.lblThongTinNCC.Size = new System.Drawing.Size(316, 37);
            this.lblThongTinNCC.TabIndex = 0;
            this.lblThongTinNCC.Text = "Thông tin nhà cung cấp";
            // 
            // ThongTinNCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThongTinNCCForm";
            this.Size = new System.Drawing.Size(1531, 622);
            this.Load += new System.EventHandler(this.ThongTinNCCForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdctlThongTinNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwThongTinNCC)).EndInit();
            this.pnlTask.ResumeLayout(false);
            this.pnlTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditNhaCungCap.Properties)).EndInit();
            this.pnlThongTinNCC.ResumeLayout(false);
            this.pnlThongTinNCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel pnlThongTinNCC;
        private System.Windows.Forms.Panel pnlTask;
        private System.Windows.Forms.Label lblThongTinNCC;
        private DevExpress.XtraEditors.PictureEdit picEditNhaCungCap;
        private System.Windows.Forms.Panel pblThemThongTinNCC;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtMaNhaCungCap;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenNhaCungCap;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblThemThongTinNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private DevExpress.XtraGrid.GridControl grdctlThongTinNCC;
        private DevExpress.XtraGrid.Views.Grid.GridView grdwThongTinNCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
    }
}
