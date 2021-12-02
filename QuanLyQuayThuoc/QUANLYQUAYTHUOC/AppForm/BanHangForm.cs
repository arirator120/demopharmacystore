using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class BanHangForm : DevExpress.XtraEditors.XtraUserControl
    {
        SanPhamBanBUS sanPham = new SanPhamBanBUS();
        NhaCungCapBUS nhaCungCap = new NhaCungCapBUS();
        
        public BanHangForm()
        {
            InitializeComponent();
            sanPham.LoadComboBoxLoaiSanPham(cbLocLoaiSanPham);
            nhaCungCap.LoadComboBoxTenNhaCungCap(cbLocNhaCungCap);
            List<TextBox> listTextBox = new List<TextBox>();
            listTextBox.Add(txtMaSanPham);
            listTextBox.Add(txtTenSanPham);
            listTextBox.Add(txtLoaiSanPham);
            listTextBox.Add(txtGiaTien);
            listTextBox.Add(txtTongTien);
            sanPham.GetTextBox(listTextBox);
        }

        private void BanHangForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            sanPham.LoadSanPham(fpnlSanPham);
        }

        private void btnGiam10_Click(object sender, EventArgs e)
        {
            if (numSoLuong.Value - 10 < 1) numSoLuong.Value = 1;
            else numSoLuong.Value -= 10;
        }

        private void btnGiam100_Click(object sender, EventArgs e)
        {
            if (numSoLuong.Value - 100 < 1) numSoLuong.Value = 1;
            else numSoLuong.Value -= 100;
        }

        private void btnTang10_Click(object sender, EventArgs e)
        {
            if (numSoLuong.Value + 10 > numSoLuong.Maximum) numSoLuong.Value = numSoLuong.Maximum;
            else numSoLuong.Value += 10;
        }

        private void btnTang100_Click(object sender, EventArgs e)
        {
            if (numSoLuong.Value + 100 > numSoLuong.Maximum) numSoLuong.Value = numSoLuong.Maximum;
            else numSoLuong.Value += 100;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSanPham;
            string tenSanPham;
            int soLuong;
            int giaBan;
            if (txtMaSanPham.TextLength > 0) 
            {
                maSanPham = txtMaSanPham.Text;
                tenSanPham = txtTenSanPham.Text;
                soLuong = (int)numSoLuong.Value;
                giaBan = Int32.Parse(txtGiaTien.Text);

                sanPham.AddItemToListView(listThongTinDonHang, int.Parse(maSanPham), tenSanPham, soLuong, giaBan);
                UpdateTotalPrice();
                // Reset số lượng
                ResetBill(false);
            }
        }

        private void UpdateTotalPrice() 
        {
            decimal total = 0;
            // Duyệt giá của từng sản phẩm
            foreach (ListViewItem items in listThongTinDonHang.Items) 
            {
                total += decimal.Parse(items.SubItems[4].Text);
            }
            txtTongTien.Text = total.ToString();
        }

        private void txtTienNhan_EditValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTienNhan.Text, out decimal tienNhan) && decimal.TryParse(txtTongTien.Text, out decimal tongTien))
            {
                // Tính tiền thừa
                if (tienNhan >= tongTien)
                {
                    txtTienThua.Text = (tienNhan - tongTien).ToString();
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maHD = 0;
            string tenKH = "";
            string sdtKH = "";
            // Check có hàng hoặc đã nhận tiền mới cho thanh toán
            if (listThongTinDonHang.Items.Count <= 0 && txtTienNhan.Text.Length <= 0) return;

            // Thanh toán cho khách hàng có điền thông tin
            if (txtPhone.Text.Length > 0 && txtKhachHang.Text.Length > 0)
            {
                tenKH = txtKhachHang.Text;
                sdtKH = txtPhone.Text;
                maHD = sanPham.SaveInvoice(new MainForm().GetMaNhanVien(), sdtKH, tenKH, DateTime.Today, int.Parse(txtTongTien.Text), listThongTinDonHang);
            }
            // Thanh toán cho khách hàng không điền thông tin
            else 
            {
                tenKH = "Unknown";
                sdtKH = "Unknown";
                maHD = sanPham.SaveInvoice(new MainForm().GetMaNhanVien(), sdtKH, tenKH, DateTime.Today, int.Parse(txtTongTien.Text), listThongTinDonHang);
            }

            if (chkInHoaDon.Checked)
            {
                if (maHD != 0)
                {
                    PrintInvoice(maHD, tenKH, sdtKH);
                }
            }

            // Reset lại nội dung sau khi thanh toán
            ResetBill(true);
            sanPham.ResetSanPham(fpnlSanPham);
            txtKhachHang.Clear();
            txtPhone.Clear();
            txtTienThua.ResetText();
            txtTienNhan.ResetText();
            txtTongTien.Clear();
        }

        void PrintInvoice(int maHoaDon, string tenKH, string sdtKH) 
        {
            HoaDonBUS hoaDon = new HoaDonBUS();
            InvoiceReport report = new InvoiceReport();
            
            foreach (DevExpress.XtraReports.Parameters.Parameter param in report.Parameters)
            {
                param.Visible = false;
            }

            string tenNhanVien = new NhanVienBUS().GetUserInformation().TenNhanVien;
            string maNhanVien = new NhanVienBUS().GetUserInformation().MaNhanVien;

            report.InitData(maHoaDon.ToString(), DateTime.Today, tenNhanVien, maNhanVien, tenKH, sdtKH, txtTienNhan.Text, txtTienThua.Text, hoaDon.GetInvoiceDetailById(maHoaDon));
            report.ExportToPdf(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\invoice.pdf"
);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetBill(true);
            txtTongTien.Clear();
        }

        void ResetBill(bool listReset) 
        {
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtLoaiSanPham.Clear();
            txtGiaTien.Clear();
            if (listReset) listThongTinDonHang.Items.Clear();
            numSoLuong.Value = 1;
        }

        private void txtTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Chỉ cho phép nhập vào số
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        
        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSanPham.TextLength > 0) 
            {
                numSoLuong.Maximum = sanPham.GetProductByID(int.Parse(txtMaSanPham.Text)).SoLuong;
            }
        }

        private void btnFilterReset_Click(object sender, EventArgs e)
        {
            sanPham.ResetSanPham(fpnlSanPham);
            txtLocMaSanPham.Clear();
            txtLocTenSanPham.Clear();
            cbLocLoaiSanPham.SelectedItem = null;
            cbLocNhaCungCap.SelectedItem = null;
        }

        private void btnLocSanPham_Click(object sender, EventArgs e)
        {
            int maSanPham = 0;
            string tenSanPham = "";
            string loaiSanPham = "";
            string tenNhaCungCap = "";

            if (txtLocMaSanPham.TextLength > 0) maSanPham = int.Parse(txtLocMaSanPham.Text);
            if (txtTenSanPham.TextLength > 0) tenSanPham = txtLocTenSanPham.Text;
            if (cbLocLoaiSanPham.SelectedItem != null) loaiSanPham = cbLocLoaiSanPham.SelectedItem.ToString();
            if (cbLocNhaCungCap.SelectedItem != null) tenNhaCungCap = cbLocNhaCungCap.SelectedItem.ToString();

            sanPham.LoadFilterSanPham(fpnlSanPham, maSanPham, tenSanPham, loaiSanPham, tenNhaCungCap);
        }

        private void txtLocMaSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Chỉ cho phép nhập vào số
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
