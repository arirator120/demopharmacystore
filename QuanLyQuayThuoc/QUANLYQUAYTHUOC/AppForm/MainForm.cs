using BUS;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CommandBase commandBase;
        NhanVienBUS currentUser = new NhanVienBUS();

        public string GetMaNhanVien()
        {
            return currentUser.GetUserInformation().MaNhanVien;
        }

        public MainForm()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 White");

            bhiUsername.Caption = currentUser.GetUserInformation().TenNhanVien;
            if (currentUser.GetUserInformation().PhanQuyen != 0)
            {
                rbpQuanTri.Visible = false;
            }

        }

        private void tabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            tabControlMain.TabPages.Remove(arg.Page as XtraTabPage);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            commandBase = new TabControlCommand(tabControlMain, new BanHangForm(), "Bán hàng");
            commandBase.Execute();
            
        }

        private void btnDanhSachNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            commandBase = new TabControlCommand(tabControlMain, new DanhSachNhanVienForm(), "Danh sách nhân viên");
            commandBase.Execute();
        }

        private void btnKhoThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            commandBase = new TabControlCommand(tabControlMain, new KhoThuocForm(), "Kho thuốc");
            commandBase.Execute();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát ứng dụng này ?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThongTinCaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            commandBase = new TabControlCommand(tabControlMain, new ThongTinCaNhanForm(), "Thông tin cá nhân");
            commandBase.Execute();
        }

        private void btnThongTinNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            commandBase = new TabControlCommand(tabControlMain, new ThongTinNCCForm(), "Thông tin nhà cung cấp");
            commandBase.Execute();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            new DoiMatKhauForm().Show();
        }
    }
}