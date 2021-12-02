using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class KhoThuocForm : DevExpress.XtraEditors.XtraUserControl
    {
        public KhoThuocForm()
        {
            InitializeComponent();
        }
        private void KhoThuocForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = KhoThuocBUS.GetDsThuoc();
            grdKhoHang.DataSource = bindingSource;

            grwKhoHang.OptionsView.ShowGroupPanel = false;
            grwKhoHang.OptionsFind.AlwaysVisible = true;

            grwKhoHang.Columns["MASP"].Caption = "Mã Sản Phẩm";
            grwKhoHang.Columns["MANCC"].Caption = "Mã Nhà Cung Cấp";
            grwKhoHang.Columns["LOAISP"].Caption = "Loại Sản Phẩm";
            grwKhoHang.Columns["TENSP"].Caption = "Tên Sản Phẩm";
            grwKhoHang.Columns["DVT"].Caption = "Đơn Vị Tính";
            grwKhoHang.Columns["HINHANH"].Caption = "Hình ảnh";
            grwKhoHang.Columns["GIABAN"].Caption = "Giá bán";
            grwKhoHang.Columns["GIANHAP"].Caption = "Giá Nhập";
            grwKhoHang.Columns["SL"].Caption = "Số lượng";
            grwKhoHang.Columns["MOTA"].Caption = "Mô Tả";

            grwKhoHang.Columns["MASP"].OptionsColumn.ReadOnly = true;
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            new ThemSanPhamForm().Show();
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = grwKhoHang.GetFocusedDataRow()["MASP"].ToString();
                int result = KhoThuocBUS.DeleteSP(maSP);
                if (result == 1)
                    MessageBox.Show("Đã xóa thành công", "Thành Công", MessageBoxButtons.OK);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = KhoThuocBUS.GetDsThuoc();
                grdKhoHang.DataSource = bindingSource;
            }
            catch (Exception s)
            {
                MessageBox.Show("Không thể xóa đuọc vì: " + s.Message, "Thất Bại", MessageBoxButtons.OK);
            }
        }

        private void grwKhoHang_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                DataRow row = grwKhoHang.GetFocusedDataRow();
                object[] obj = row.ItemArray;
                int result = KhoThuocBUS.UpdateSP(obj);
                if (result == 1)
                    MessageBox.Show("Đã cập nhật dòng dữ liệu", "Thành Công", MessageBoxButtons.OK);
            }
            catch (Exception s)
            {
                MessageBox.Show("Không thể cập nhật đuọc vì: " + s.Message, "Thất Bại", MessageBoxButtons.OK);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = KhoThuocBUS.GetDsThuoc();
            grdKhoHang.DataSource = bindingSource;
        }

        private void grdKhoHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = KhoThuocBUS.GetDsThuoc();
                grdKhoHang.DataSource = bindingSource;
            }
        }
    }
}
