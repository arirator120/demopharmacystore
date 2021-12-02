using BUS;
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
    public partial class DoiMatKhauForm : System.Windows.Forms.Form
    {
        NhanVienBUS nhanVien = new NhanVienBUS();
        public DoiMatKhauForm()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangePassForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Tên tài khoản" || txtCurrentPass.Text == "Mật khẩu cũ" || txtNewPass.Text == "Mật khẩu mới" || txtConfirmNewP.Text == "Xác nhận mật khẩu mới")
                new KiemTraForm().Show();

            else
            {
                if (txtNewPass.Text == txtCurrentPass.Text)
                    new KiemTraMatKhauMoiForm().Show();
                else if (txtConfirmNewP.Text != txtNewPass.Text)
                    new KiemTraXacNhanMKMoiForm().Show();
                else if (nhanVien.UserLogin(txtUserName.Text, txtCurrentPass.Text))
                {
                    string TenDN, MKCu, MKMoi;
                    TenDN = txtUserName.Text;
                    MKCu = txtCurrentPass.Text;
                    MKMoi = txtNewPass.Text;
                    int result = DoiMatKhauBUS.DoiMatKhau(TenDN, MKCu, MKMoi);
                    if (result == 1)
                    {
                        new ThayDoiMKThanhCongForm().Show();
                        this.Close();
                    }
                }
                else
                    new KiemTraTKvaMKcuForm().Show();
            }
        }
    

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Tên tài khoản")
                txtUserName.Text = "";
        }

        private void txtCurrentPass_Enter(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "Mật khẩu cũ")
            {
                txtCurrentPass.Text = "";
                txtCurrentPass.UseSystemPasswordChar = true;
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "Mật khẩu mới")
            {
                txtNewPass.Text = "";
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmNewP_Enter(object sender, EventArgs e)
        {
            if (txtConfirmNewP.Text == "Xác nhận mật khẩu mới")
            {
                txtConfirmNewP.Text = "";
                txtConfirmNewP.UseSystemPasswordChar = true;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Tên tài khoản";
                txtUserName.UseSystemPasswordChar = false;
            }
        }

        private void txtCurrentPass_Leave(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text == "")
            {
                txtCurrentPass.Text = "Mật khẩu cũ";
                txtCurrentPass.UseSystemPasswordChar = false;
            }
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.Text = "Mật khẩu mới";
                txtNewPass.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmNewP_Leave(object sender, EventArgs e)
        {
            if (txtConfirmNewP.Text == "")
            {
                txtConfirmNewP.Text = "Xác nhận mật khẩu mới";
                txtConfirmNewP.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmNewP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nhanVien.UserLogin(txtUserName.Text, txtCurrentPass.Text))
                {
                    string TenDN, MKCu, MKMoi;
                    TenDN = txtUserName.Text;
                    MKCu = txtCurrentPass.Text;
                    MKMoi = txtNewPass.Text;
                    int result = DoiMatKhauBUS.DoiMatKhau(TenDN, MKCu, MKMoi);
                    if (result == 1)
                    {
                        new ThayDoiMKThanhCongForm().Show();
                        this.Close();
                    }
                }
                else if (txtNewPass.Text == txtCurrentPass.Text)
                    new KiemTraMatKhauMoiForm().Show();
                else if (txtConfirmNewP.Text != txtNewPass.Text)
                    new KiemTraXacNhanMKMoiForm().Show();
                
                else
                    new KiemTraTKvaMKcuForm().Show();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNewPass.Text == txtCurrentPass.Text)
                    new KiemTraMatKhauMoiForm().Show();
                else if (txtConfirmNewP.Text != txtNewPass.Text)
                    new KiemTraXacNhanMKMoiForm().Show();
                else if (nhanVien.UserLogin(txtUserName.Text, txtCurrentPass.Text))
                {
                    string TenDN, MKCu, MKMoi;
                    TenDN = txtUserName.Text;
                    MKCu = txtCurrentPass.Text;
                    MKMoi = txtNewPass.Text;
                    int result = DoiMatKhauBUS.DoiMatKhau(TenDN, MKCu, MKMoi);
                    if (result == 1)
                    {
                        new ThayDoiMKThanhCongForm().Show();
                        this.Close();
                    }
                }
                else
                    new KiemTraTKvaMKcuForm().Show();
            }
        }

        private void txtCurrentPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNewPass.Text == txtCurrentPass.Text)
                    new KiemTraMatKhauMoiForm().Show();
                else if (txtConfirmNewP.Text != txtNewPass.Text)
                    new KiemTraXacNhanMKMoiForm().Show();
                else if (nhanVien.UserLogin(txtUserName.Text, txtCurrentPass.Text))
                {
                    string TenDN, MKCu, MKMoi;
                    TenDN = txtUserName.Text;
                    MKCu = txtCurrentPass.Text;
                    MKMoi = txtNewPass.Text;
                    int result = DoiMatKhauBUS.DoiMatKhau(TenDN, MKCu, MKMoi);
                    if (result == 1)
                    {
                        new ThayDoiMKThanhCongForm().Show();
                        this.Close();
                    }
                }
                else
                    new KiemTraTKvaMKcuForm().Show();
            }
        }

        private void txtNewPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNewPass.Text == txtCurrentPass.Text)
                    new KiemTraMatKhauMoiForm().Show();
                else if (txtConfirmNewP.Text != txtNewPass.Text)
                    new KiemTraXacNhanMKMoiForm().Show();
                else if (nhanVien.UserLogin(txtUserName.Text, txtCurrentPass.Text))
                {
                    string TenDN, MKCu, MKMoi;
                    TenDN = txtUserName.Text;
                    MKCu = txtCurrentPass.Text;
                    MKMoi = txtNewPass.Text;
                    int result = DoiMatKhauBUS.DoiMatKhau(TenDN, MKCu, MKMoi);
                    if (result == 1)
                    {
                        new ThayDoiMKThanhCongForm().Show();
                        this.Close();
                    }
                }
                else
                    new KiemTraTKvaMKcuForm().Show();
            }
        }
    }
}
