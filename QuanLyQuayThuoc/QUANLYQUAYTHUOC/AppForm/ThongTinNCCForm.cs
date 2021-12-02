using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class ThongTinNCCForm : DevExpress.XtraEditors.XtraUserControl
    {
        public ThongTinNCCForm()
        {
            InitializeComponent();
        }
        private void ThongTinNCCForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = NhaCungCapBUS.GetDsNhaCungCap();
            grdctlThongTinNCC.DataSource = bindingSource;

            grdwThongTinNCC.Columns["MANCC"].Caption = "Mã nhà cung cấp";
            grdwThongTinNCC.Columns["TENNCC"].Caption = "Tên nhà cung cấp";
            grdwThongTinNCC.Columns["SDT"].Caption = "Số điện thoại";
            grdwThongTinNCC.Columns["DIACHI"].Caption = "Địa chỉ";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhaCungCap.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(txtTenNhaCungCap.Text))
            {
                txtTenNhaCungCap.Text = "";
            }
            if (string.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                txtSoDienThoai.Text = "";
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                txtDiaChi.Text = "";
            }
            int insert = NhaCungCapBUS.ThemNhaCungCap(txtMaNhaCungCap.Text, txtTenNhaCungCap.Text, txtSoDienThoai.Text, txtDiaChi.Text);
            if (insert == 1)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = NhaCungCapBUS.GetDsNhaCungCap();
                grdctlThongTinNCC.DataSource = bindingSource;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhaCungCap.Clear();
            txtTenNhaCungCap.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = grdwThongTinNCC.GetFocusedDataRow()["MANCC"].ToString();
                int result = NhaCungCapBUS.DeleteNhaCungCap(maNCC);
                if (result == 1)
                    MessageBox.Show("Đã xóa thành công", "Thành Công", MessageBoxButtons.OK);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = NhaCungCapBUS.GetDsNhaCungCap();
                grdctlThongTinNCC.DataSource = bindingSource;
            }
            catch (Exception s)
            {
                MessageBox.Show("Không thể xóa đuọc vì: " + s.Message, "Thất Bại", MessageBoxButtons.OK);
            }
        }

        private void grdctlThongTinNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = NhaCungCapBUS.GetDsNhaCungCap();
                grdctlThongTinNCC.DataSource = bindingSource;
            }
        }
    }
}
