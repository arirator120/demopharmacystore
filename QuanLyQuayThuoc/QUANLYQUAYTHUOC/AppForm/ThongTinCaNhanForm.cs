using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;
using DTO;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class ThongTinCaNhanForm : DevExpress.XtraEditors.XtraUserControl
    {

        public ThongTinCaNhanForm()
        {
            InitializeComponent();
        }

        private void ThongTinCaNhanForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            txtMaNV.Enabled = false;
            txtNgayVao.Enabled = false;
            txtLuong.Enabled = false;
            txtChucVu.Enabled = false;
            txtTen.Focus();

            NhanVienBUS nv = new NhanVienBUS();
            NhanVien nhanvien = nv.GetUserInformation();
            txtMaNV.Text = nhanvien.MaNhanVien;
            txtTen.Text = nhanvien.TenNhanVien;
            txtNgaySinh.Text = nhanvien.NgaySinh.ToShortDateString();
            if (nhanvien.GioiTinh)
                txtGioiTinh.Text = "Nữ";
            else
                txtGioiTinh.Text = "Nam";
            txtCMND.Text = nhanvien.CMND;
            txtSDT.Text = nhanvien.SDT;
            txtDiaChi.Text = nhanvien.DiaChi;
            txtNgayVao.Text = nhanvien.NgayVaoLam.ToShortDateString();
            txtLuong.Text = nhanvien.Luong.ToString();
            if (nhanvien.PhanQuyen == 0)
                txtChucVu.Text = "Admin";
            else
                txtChucVu.Text = "Nhân Viên";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNV.Text;
            nv.TenNhanVien = txtTen.Text;
            nv.NgaySinh = Convert.ToDateTime(txtNgaySinh.Text);
            if (txtGioiTinh.Text.Equals("Nữ"))
                nv.GioiTinh = true;
            else if (txtGioiTinh.Text.Equals("Nam"))
                nv.GioiTinh = false;
            else
                MessageBox.Show("Giới Tính phải là Nam hoặc Nữ!", "Error", MessageBoxButtons.OK);
            nv.CMND = txtCMND.Text;
            nv.SDT = txtSDT.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.NgayVaoLam = Convert.ToDateTime(txtNgayVao.Text);
            nv.Luong = Convert.ToInt32(txtLuong.Text);
            if (txtChucVu.Text.Equals("Admin"))
                nv.PhanQuyen = 0;
            else
                nv.PhanQuyen = 1;
            int result = NhanVienBUS.UpdateThongTinNhanVien(nv);
            if (result == 1)
                MessageBox.Show("Cập Nhật Thành Công!!!", "Success", MessageBoxButtons.OK);
            else
                MessageBox.Show("Cập Nhật Thất Bại", "Fail", MessageBoxButtons.OK);

            
        }
    }
}
