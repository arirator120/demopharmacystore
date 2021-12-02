
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class KhoThuocForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoThuocForm));
            this.pnlKhoThuoc = new System.Windows.Forms.Panel();
            this.llbKhoThuoc = new System.Windows.Forms.Label();
            this.tblpnlKhoHang = new DevExpress.Utils.Layout.TablePanel();
            this.grdKhoHang = new DevExpress.XtraGrid.GridControl();
            this.grwKhoHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.picEditChange = new DevExpress.XtraEditors.PictureEdit();
            this.button13 = new System.Windows.Forms.Button();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.clnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGiaTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pnlKhoThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblpnlKhoHang)).BeginInit();
            this.tblpnlKhoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grwKhoHang)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditChange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKhoThuoc
            // 
            this.pnlKhoThuoc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tblpnlKhoHang.SetColumn(this.pnlKhoThuoc, 0);
            this.tblpnlKhoHang.SetColumnSpan(this.pnlKhoThuoc, 2);
            this.pnlKhoThuoc.Controls.Add(this.llbKhoThuoc);
            this.pnlKhoThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKhoThuoc.Location = new System.Drawing.Point(3, 2);
            this.pnlKhoThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlKhoThuoc.Name = "pnlKhoThuoc";
            this.tblpnlKhoHang.SetRow(this.pnlKhoThuoc, 0);
            this.pnlKhoThuoc.Size = new System.Drawing.Size(1525, 83);
            this.pnlKhoThuoc.TabIndex = 5;
            // 
            // llbKhoThuoc
            // 
            this.llbKhoThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llbKhoThuoc.AutoSize = true;
            this.llbKhoThuoc.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbKhoThuoc.ForeColor = System.Drawing.Color.White;
            this.llbKhoThuoc.Location = new System.Drawing.Point(690, 2);
            this.llbKhoThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.llbKhoThuoc.Name = "llbKhoThuoc";
            this.llbKhoThuoc.Size = new System.Drawing.Size(199, 51);
            this.llbKhoThuoc.TabIndex = 0;
            this.llbKhoThuoc.Text = "Kho Hàng";
            // 
            // tblpnlKhoHang
            // 
            this.tblpnlKhoHang.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tblpnlKhoHang.Appearance.Options.UseBackColor = true;
            this.tblpnlKhoHang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.tblpnlKhoHang.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15.21F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 44.79F)});
            this.tblpnlKhoHang.Controls.Add(this.grdKhoHang);
            this.tblpnlKhoHang.Controls.Add(this.pnlButton);
            this.tblpnlKhoHang.Controls.Add(this.pnlKhoThuoc);
            this.tblpnlKhoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlKhoHang.Location = new System.Drawing.Point(0, 0);
            this.tblpnlKhoHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblpnlKhoHang.Name = "tblpnlKhoHang";
            this.tblpnlKhoHang.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 86.80009F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tblpnlKhoHang.Size = new System.Drawing.Size(1531, 568);
            this.tblpnlKhoHang.TabIndex = 1;
            // 
            // grdKhoHang
            // 
            this.tblpnlKhoHang.SetColumn(this.grdKhoHang, 1);
            this.grdKhoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKhoHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdKhoHang.Location = new System.Drawing.Point(391, 89);
            this.grdKhoHang.MainView = this.grwKhoHang;
            this.grdKhoHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdKhoHang.Name = "grdKhoHang";
            this.tblpnlKhoHang.SetRow(this.grdKhoHang, 1);
            this.grdKhoHang.Size = new System.Drawing.Size(1137, 477);
            this.grdKhoHang.TabIndex = 14;
            this.grdKhoHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grwKhoHang});
            this.grdKhoHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdKhoHang_KeyDown);
            // 
            // grwKhoHang
            // 
            this.grwKhoHang.DetailHeight = 268;
            this.grwKhoHang.GridControl = this.grdKhoHang;
            this.grwKhoHang.Name = "grwKhoHang";
            this.grwKhoHang.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grwKhoHang_RowUpdated);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tblpnlKhoHang.SetColumn(this.pnlButton, 0);
            this.pnlButton.Controls.Add(this.btnLamMoi);
            this.pnlButton.Controls.Add(this.picEditChange);
            this.pnlButton.Controls.Add(this.button13);
            this.pnlButton.Controls.Add(this.btnXoaSanPham);
            this.pnlButton.Controls.Add(this.button10);
            this.pnlButton.Controls.Add(this.button12);
            this.pnlButton.Controls.Add(this.btnThemSanPham);
            this.pnlButton.Controls.Add(this.button9);
            this.pnlButton.Controls.Add(this.button4);
            this.pnlButton.Controls.Add(this.button7);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButton.Location = new System.Drawing.Point(3, 89);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButton.Name = "pnlButton";
            this.tblpnlKhoHang.SetRow(this.pnlButton, 1);
            this.pnlButton.Size = new System.Drawing.Size(382, 477);
            this.pnlButton.TabIndex = 13;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLamMoi.Location = new System.Drawing.Point(108, 383);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(165, 53);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // picEditChange
            // 
            this.picEditChange.EditValue = ((object)(resources.GetObject("picEditChange.EditValue")));
            this.picEditChange.Location = new System.Drawing.Point(153, 96);
            this.picEditChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEditChange.Name = "picEditChange";
            this.picEditChange.Properties.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picEditChange.Properties.Appearance.Options.UseBackColor = true;
            this.picEditChange.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picEditChange.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picEditChange.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picEditChange.Size = new System.Drawing.Size(101, 106);
            this.picEditChange.TabIndex = 3;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button13.Location = new System.Drawing.Point(-524, 172);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 39);
            this.button13.TabIndex = 6;
            this.button13.Text = "Tìm";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.White;
            this.btnXoaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanPham.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaSanPham.Location = new System.Drawing.Point(108, 307);
            this.btnXoaSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(165, 53);
            this.btnXoaSanPham.TabIndex = 1;
            this.btnXoaSanPham.Text = "Xóa sản phẩm";
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button10.Location = new System.Drawing.Point(-524, 105);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 39);
            this.button10.TabIndex = 6;
            this.button10.Text = "Tìm";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button12.Location = new System.Drawing.Point(-524, 218);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 39);
            this.button12.TabIndex = 6;
            this.button12.Text = "Làm mới";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.White;
            this.btnThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSanPham.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemSanPham.Location = new System.Drawing.Point(108, 229);
            this.btnThemSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(165, 53);
            this.btnThemSanPham.TabIndex = 0;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button9.Location = new System.Drawing.Point(-524, 151);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 39);
            this.button9.TabIndex = 6;
            this.button9.Text = "Làm mới";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(-513, 31);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "Tìm";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button7.Location = new System.Drawing.Point(-513, 76);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 39);
            this.button7.TabIndex = 6;
            this.button7.Text = "Làm mới";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // clnID
            // 
            this.clnID.DisplayIndex = 0;
            this.clnID.Text = "ID";
            this.clnID.Width = 127;
            // 
            // clnTen
            // 
            this.clnTen.DisplayIndex = 1;
            this.clnTen.Text = "Tên";
            this.clnTen.Width = 132;
            // 
            // clnSoLuong
            // 
            this.clnSoLuong.DisplayIndex = 2;
            this.clnSoLuong.Text = "Số lượng";
            this.clnSoLuong.Width = 87;
            // 
            // clnGiaTien
            // 
            this.clnGiaTien.DisplayIndex = 3;
            this.clnGiaTien.Text = "Giá tiền";
            this.clnGiaTien.Width = 121;
            // 
            // KhoThuocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblpnlKhoHang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhoThuocForm";
            this.Size = new System.Drawing.Size(1531, 568);
            this.Load += new System.EventHandler(this.KhoThuocForm_Load);
            this.pnlKhoThuoc.ResumeLayout(false);
            this.pnlKhoThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblpnlKhoHang)).EndInit();
            this.tblpnlKhoHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grwKhoHang)).EndInit();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEditChange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKhoThuoc;
        private DevExpress.Utils.Layout.TablePanel tblpnlKhoHang;
        private System.Windows.Forms.Label llbKhoThuoc;
        private System.Windows.Forms.ColumnHeader clnID;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.ColumnHeader clnSoLuong;
        private System.Windows.Forms.ColumnHeader clnGiaTien;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnLamMoi;
        private DevExpress.XtraEditors.PictureEdit picEditChange;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private DevExpress.XtraGrid.GridControl grdKhoHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grwKhoHang;
    }
}
