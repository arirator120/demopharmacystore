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

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class DangNhapForm : System.Windows.Forms.Form
    {
        NhanVienBUS nhanVien = new NhanVienBUS();
        public DangNhapForm()
        {
            InitializeComponent();
        }
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "Mật khẩu")
                txtPassWord.UseSystemPasswordChar = false;
            else
                txtPassWord.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Tên đăng nhập")
                txtUserName.Text = "";
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
                txtUserName.Text = "Tên đăng nhập";
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "Mật khẩu")
            {
                txtPassWord.Text = "";
                txtPassWord.UseSystemPasswordChar = true;
            }

        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "")
            {
                txtPassWord.Text = "Mật khẩu";
                txtPassWord.UseSystemPasswordChar = false;
            }
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DoiMatKhauForm().Show();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;

            if (nhanVien.UserLogin(username, password))
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                KiemTraTKvaMKcuForm errorScreen = new KiemTraTKvaMKcuForm();
                errorScreen.Show();
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = txtUserName.Text;
                string password = txtPassWord.Text;

                if (nhanVien.UserLogin(username, password))
                {
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    KiemTraTKvaMKcuForm errorScreen = new KiemTraTKvaMKcuForm();
                    errorScreen.Show();
                }
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = txtUserName.Text;
                string password = txtPassWord.Text;

                if (nhanVien.UserLogin(username, password))
                {
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    KiemTraTKvaMKcuForm errorScreen = new KiemTraTKvaMKcuForm();
                    errorScreen.Show();
                }
            }
        }
    }
}
