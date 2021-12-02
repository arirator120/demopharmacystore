using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class ThemSanPhamForm : System.Windows.Forms.Form
    {
        string imageName = "";
        string imageLocation = "";
        NhaCungCapBUS nccBus = new NhaCungCapBUS();
        public ThemSanPhamForm()
        {
            InitializeComponent();
            nccBus.LoadComboBoxTenNhaCungCap(cmbMaNCC);
        }

        private void ThemSP_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    imageName = Path.GetFileName(imageLocation);
                    picHinhAnh.Image = new Bitmap(imageLocation);

                }
            }
            catch (Exception)
            {
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cmbMaNCC.ResetText();
            txtTen.ResetText();
            txtLoai.ResetText();
            txtDVT.ResetText();
            txtSL.ResetText();
            txtGiaNhap.ResetText();
            txtGiaBan.ResetText();
            rtfMota.ResetText();
            picHinhAnh.Image = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                txtTen.Text = "";
            }
            if (string.IsNullOrEmpty(cmbMaNCC.Text))
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(txtLoai.Text))
            {
                txtLoai.Text = "";
            }
            if (string.IsNullOrEmpty(txtDVT.Text))
            {
                txtDVT.Text = "";
            }
            if (string.IsNullOrEmpty(txtGiaBan.Text))
            {
                txtGiaBan.Text = "0";
            }
            if (string.IsNullOrEmpty(txtGiaNhap.Text))
            {
                txtGiaNhap.Text = "0";
            }
            if (string.IsNullOrEmpty(txtSL.Text))
            {
                txtSL.Text = "0";
            }
            if (string.IsNullOrEmpty(rtfMota.Text))
            {
                rtfMota.Text = "";
            }
            Byte[] bytBLOBData;
            FileStream fsBLOBFile;
            if (picHinhAnh.Image != null)
            {
                fsBLOBFile = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                bytBLOBData = new Byte[fsBLOBFile.Length];
                fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
                fsBLOBFile.Close();
            }
            else
            {
                fsBLOBFile = new FileStream("..\\..\\AppResource\\placeholder_tablet.png", FileMode.Open, FileAccess.Read);
                bytBLOBData = new Byte[fsBLOBFile.Length];
                fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
                fsBLOBFile.Close();
            }


            object[] obj = { cmbMaNCC.Text, txtTen.Text, txtLoai.Text, bytBLOBData, txtDVT.Text, Convert.ToDecimal(txtGiaBan.Text), Convert.ToDecimal(txtGiaNhap.Text), Convert.ToInt32(txtSL.Text), rtfMota.Text };
            int result = KhoThuocBUS.SaveNewSP(obj);
            if (result == 1)
                MessageBox.Show("Thêm Thành Công", "Thành Công", MessageBoxButtons.OK);

            Close();
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
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
