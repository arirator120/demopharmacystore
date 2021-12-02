using DevExpress.XtraEditors;
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
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using DevExpress.XtraGrid.Columns;
using System.IO;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class DanhSachNhanVienForm : DevExpress.XtraEditors.XtraUserControl
    {

        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public DanhSachNhanVienForm()
        {
            InitializeComponent();
        }

        void LoadData() 
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nhanVienBUS.GetDsNhanVien();
            gridNhanVien.DataSource = bindingSource;

            grvNhanVien.Columns["MANV"].Caption = "Mã nhân viên";
            grvNhanVien.Columns["TEN"].Caption = "Họ tên";
            grvNhanVien.Columns["NGAYSINH"].Caption = "Ngày sinh";
            grvNhanVien.Columns["GIOITINH"].Caption = "Giới tính (Nữ)";
            grvNhanVien.Columns["CMND"].Caption = "CMND";
            grvNhanVien.Columns["SDT"].Caption = "Số điện thoại";
            grvNhanVien.Columns["DIACHI"].Caption = "Địa chỉ";
            grvNhanVien.Columns["NGAYVAOLAM"].Caption = "Ngày vào làm";
            grvNhanVien.Columns["LUONG"].Caption = "Lương";
            grvNhanVien.Columns["CO_TK"].Caption = "Đã cấp tài khoản";
            grvNhanVien.Columns["PHANQUYEN"].Caption = "Phân quyền";
            grvNhanVien.Columns["FLAG_LAM"].Caption = "Tình trạng làm việc";
        }

        private void DanhSachNhanVienForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadData();
        }

        private void grvNhanVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maNV = grvNhanVien.GetFocusedDataRow()["MANV"].ToString();

            txtIdUser.Text = maNV;
        }

        private void grvNhanVien_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRowView row = (DataRowView)e.Row;
            object[] obj = row.Row.ItemArray;
            int result = NhanVienBUS.UpdateThongTinNhanVien(obj);

            if (result > 0)
            {
                MessageBox.Show("Đã cập nhật dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        public string GeneratePassword(bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial, int length)
        {
            const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
            const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMBERS = "123456789";
            const string SPECIALS = @"!@$%^&*()#";

            char[] password = new char[length];
            string charSet = ""; 
            Random random = new Random();

            if (useLowercase) charSet += LOWER_CASE;

            if (useUppercase) charSet += UPPER_CAES;

            if (useNumbers) charSet += NUMBERS;

            if (useSpecial) charSet += SPECIALS;

            for (int counter = 0; counter < length; counter++)
            {
                password[counter] = charSet[random.Next(charSet.Length - 1)];
            }

            return string.Join(null, password);
        }
    

        private void btnRandPass_Click(object sender, EventArgs e)
        {
            bool lowerCase = true;
            bool upperCase = true;
            bool number = true;
            bool specialChar = true;
            int lenght = 15;

            txtPassword.Text = GeneratePassword(lowerCase, upperCase, number, specialChar, lenght);
        }

        private void btnCapTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtIdUser.TextLength <= 0) return;
            
            NhanVien nhanVien = nhanVienBUS.GetNhanVienById(txtIdUser.Text);

            if (nhanVien == null) return;

            if (nhanVien.HasAccount) return;

            if (txtAccount.TextLength <= 0 || txtPassword.TextLength <= 0) return;

            string maNV = txtIdUser.Text;
            string username = txtAccount.Text;
            string password = txtPassword.Text;

            int result = nhanVienBUS.AddUserAccount(maNV, username, password);

            if (result > 0) MessageBox.Show("Cấp tài khoản thành công.", "Success", MessageBoxButtons.OK);
            else MessageBox.Show("Cấp tài khoản thất bại", "Fail", MessageBoxButtons.OK);

            PrintNote();
            txtIdUser.Clear();
            txtAccount.Clear();
            txtPassword.Clear();
            LoadData();
        }

        void PrintNote() 
        {
            string path = "..\\..\\AppResource\\note.pdf";

            if (true)
            {
                Document document = new Document(PageSize.A4, 10, 10, 35, 35);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
                document.Open();

                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont baseFont = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);

                Paragraph paragraph = new Paragraph("Username: " + txtAccount.Text, font);
                paragraph.Alignment = Element.ALIGN_CENTER;
                document.Add(paragraph);
                paragraph = new Paragraph("Password: " + txtPassword.Text, font);
                paragraph.Alignment = Element.ALIGN_CENTER;
                document.Add(paragraph);

                document.Close();
            }
        }

        bool CheckFillAddAccount() 
        {
            if (txtName.TextLength <= 0) return false;
            if (cbGender.SelectedItem == null) return false;
            if (txtCMND.TextLength <= 0) return false;
            if (txtPhone.TextLength <= 0) return false;
            if (txtAddress.TextLength <= 0) return false;
            if (txtSalary.TextLength <= 0) return false;
            if (cbRole.SelectedItem == null) return false;
            
            return true;
        }

        string GenerateID(int role) 
        {
            string last;
            int sub;

            if (role == 0)
            {
                sub = 5;
                NhanVien admin = nhanVienBUS.GetAdminLast();
                last = admin != null ? admin.MaNhanVien : "ADMIN00000";
            }
            else
            {
                sub = 4;
                NhanVien user = nhanVienBUS.GetUserLast();
                last = user != null ? user.MaNhanVien : "USER000000";
            }

            string prefix = last.Substring(0, sub);
            int val = int.Parse(last.Substring(5));
            return prefix + new string('0', 10 - prefix.Length - (val + 1).ToString().Length) + (val + 1).ToString();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (!CheckFillAddAccount()) return;
            
            string name = txtName.Text;
            DateTime birthDate = dtpBirth.Value;
            bool gender = !cbGender.SelectedItem.ToString().Equals("Nam");
            string cmnd = txtCMND.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            DateTime dateWork = dtpDateWork.Value;
            decimal salary = decimal.Parse(txtSalary.Text);
            int role = cbRole.SelectedItem.ToString().Equals("Admin") ? 0 : 1;
            string id = GenerateID(role);

            object[] obj = new object[] { 
                id,
                name,
                birthDate,
                gender,
                cmnd,
                phone,
                address,
                dateWork,
                salary,
                role
            };

            int result = nhanVienBUS.AddUser(obj);
            if (result > 0) MessageBox.Show("Thêm thành công.", "Success", MessageBoxButtons.OK);
            else MessageBox.Show("Thêm thất bại", "Fail", MessageBoxButtons.OK);

            LoadData();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
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
