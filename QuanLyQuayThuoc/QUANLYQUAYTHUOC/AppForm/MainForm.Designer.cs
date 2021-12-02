
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTinCaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
     
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bhiUsername = new DevExpress.XtraBars.BarHeaderItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarHeaderItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTinNhaCungCap = new DevExpress.XtraBars.BarButtonItem();
            
            this.rbpQuanLyBangHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnBanThuoc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnQuanLyNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnTaiNguyen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabControlMain = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 818);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1314, 22);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnBanHang,
            this.btnKhoThuoc,
            this.btnThongTinCaNhan,
            this.btnDoiMatKhau,

            this.barButtonItem1,
            this.barButtonItem2,
            this.bhiUsername,
            this.btnDangXuat,
            this.barButtonItem5,
            this.btnDanhSachNhanVien,
            this.btnThongTinNhaCungCap,
            });
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ribbon.MaxItemId = 33;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.btnDangXuat);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpQuanLyBangHang,
            this.rbpQuanTri});
            this.ribbon.QuickToolbarItemLinks.Add(this.bhiUsername);
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbon.Size = new System.Drawing.Size(1314, 160);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnBanHang
            // 
            this.btnBanHang.Caption = "Bán Hàng";
            this.btnBanHang.Id = 1;
            this.btnBanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.ImageOptions.Image")));
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanHang_ItemClick);
            // 
            // btnKhoThuoc
            // 
            this.btnKhoThuoc.Caption = "Kho thuốc";
            this.btnKhoThuoc.Id = 4;
            this.btnKhoThuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoThuoc.ImageOptions.Image")));
            this.btnKhoThuoc.Name = "btnKhoThuoc";
            this.btnKhoThuoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhoThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoThuoc_ItemClick);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Caption = "Thông tin cá nhân";
            this.btnThongTinCaNhan.Id = 5;
            this.btnThongTinCaNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinCaNhan.ImageOptions.Image")));
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThongTinCaNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTinCaNhan_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 6;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 

            // barButtonItem1
            // 
            this.barButtonItem1.Id = 24;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 25;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bhiUsername
            // 
            this.bhiUsername.Caption = "Username";
            this.bhiUsername.Id = 26;
            this.bhiUsername.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bhiUsername.ImageOptions.Image")));
            this.bhiUsername.Name = "bhiUsername";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 27;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = 30;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnDanhSachNhanVien
            // 
            this.btnDanhSachNhanVien.Caption = "Danh sách nhân viên";
            this.btnDanhSachNhanVien.Id = 21;
            this.btnDanhSachNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachNhanVien.ImageOptions.Image")));
            this.btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            this.btnDanhSachNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhSachNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachNhanVien_ItemClick);
            // 
            // btnThongTinNhaCungCap
            // 
            this.btnThongTinNhaCungCap.Caption = "Thông tin nhà cung cấp";
            this.btnThongTinNhaCungCap.Id = 23;
            this.btnThongTinNhaCungCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinNhaCungCap.ImageOptions.Image")));
            this.btnThongTinNhaCungCap.Name = "btnThongTinNhaCungCap";
            this.btnThongTinNhaCungCap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThongTinNhaCungCap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTinNhaCungCap_ItemClick);
            // 
            
            // 
            // rbpQuanLyBanHang
            // 
            this.rbpQuanLyBangHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnBanThuoc,
            this.rbnTaiKhoan,
            });
            this.rbpQuanLyBangHang.Name = "rbpQuanLyBangHang";
            this.rbpQuanLyBangHang.Text = "Quản lý bán hàng";
            // 
            // rbnBanThuoc
            // 
            this.rbnBanThuoc.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rbnBanThuoc.ItemLinks.Add(this.btnBanHang);
            this.rbnBanThuoc.ItemLinks.Add(this.btnKhoThuoc);
            this.rbnBanThuoc.Name = "rbnBanThuoc";
            this.rbnBanThuoc.Text = "Bán thuốc";
            // 
            // rbnTaiKhoan
            // 
            this.rbnTaiKhoan.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.rbnTaiKhoan.ItemLinks.Add(this.btnThongTinCaNhan);
            this.rbnTaiKhoan.ItemLinks.Add(this.btnDoiMatKhau);
            this.rbnTaiKhoan.Name = "rbnTaiKhoan";
            this.rbnTaiKhoan.Text = "Tài khoản";
            // 
            // rbpQuanTri
            // 
            this.rbpQuanTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnQuanLyNhanVien,
            this.rbnTaiNguyen});
            this.rbpQuanTri.Name = "rbpQuanTri";
            this.rbpQuanTri.Text = "Quản trị";
            // 
            // rbnQuanLyNhanVien
            // 
            this.rbnQuanLyNhanVien.ItemLinks.Add(this.btnDanhSachNhanVien);
            this.rbnQuanLyNhanVien.Name = "rbnQuanLyNhanVien";
            this.rbnQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // rbnTaiNguyen
            // 
            this.rbnTaiNguyen.ItemLinks.Add(this.btnThongTinNhaCungCap);
            this.rbnTaiNguyen.Name = "rbnTaiNguyen";
            this.rbnTaiNguyen.Text = "Tài nguyên";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Xử lý yêu cầu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý nhân viên";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản trị";
            // 
            // tabControlMain
            // 
            this.tabControlMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 160);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.tabControlMain.Size = new System.Drawing.Size(1314, 658);
            this.tabControlMain.TabIndex = 2;
            this.tabControlMain.CloseButtonClick += new System.EventHandler(this.tabControlMain_CloseButtonClick);
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1314, 840);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnBanHang;
        /*private DevExpress.XtraBars.BarButtonItem btnNhapHang;*/
        private DevExpress.XtraBars.BarButtonItem btnKhoThuoc;
        private DevExpress.XtraBars.BarButtonItem btnThongTinCaNhan;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        /*private DevExpress.XtraBars.BarButtonItem btnXemLichSuBanHang;
        private DevExpress.XtraBars.BarButtonItem btnXemLichSuNhapHang;*/
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarHeaderItem bhiUsername;
        private DevExpress.XtraBars.BarHeaderItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpQuanLyBangHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnBanThuoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpQuanTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnQuanLyNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnThongTinNhaCungCap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnTaiNguyen;
        private DevExpress.XtraTab.XtraTabControl tabControlMain;
        //private DevExpress.XtraBars.BarButtonItem btnInTemMaVach;
    }
}