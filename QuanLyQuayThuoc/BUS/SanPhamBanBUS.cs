using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class SanPhamBanBUS
    {
        /// <summary>
        /// Dùng cho form Bán hàng
        /// 
        /// listTextBox.ToArray()[0] => txtMaSanPham 
        /// listTextBox.ToArray()[1] => txtTenSanPham
        /// listTextBox.ToArray()[2] => txtLoaiSanPham
        /// listTextBox.ToArray()[3] => txtGiaTien
        /// listTextBox.ToArray()[4] => txtTongTien
        /// 
        /// </summary>
        List<TextBox> listTextBox = new List<TextBox>(); 

        // Lấy các TextBox, NumericUpDown từ forrm Bán hàng
        public void GetTextBox(List<TextBox> textBoxes)
        {
            listTextBox = textBoxes;
        }

        // Tạo sản phẩm kèm hình ảnh trong flow layout panel 
        public void ThemSanPhamVaoFlowPanel(FlowLayoutPanel flowPanel, SanPhamBan sanPhamBan)
        {
            // Trang trí :))
            Panel panelBig = new Panel();
            Panel panelSmall = new Panel();

            panelBig.Height = 300;
            panelBig.Width = 220;
            panelBig.Margin = new Padding(5);
            panelBig.Padding = new Padding(5, 5, 5, 5);
            panelBig.BackColor = Color.FromArgb(0, 102, 204);

            panelSmall.Dock = DockStyle.Fill;
            panelSmall.BackColor = Color.White;

            // Xử lý dạng nút bấm cho sản phẩm
            Button buttonChoose = new Button();
            if (sanPhamBan.HinhSanPham != null)
            {
                buttonChoose.BackgroundImage = sanPhamBan.HinhSanPham;
            }
            else
            {
                buttonChoose.BackgroundImage = Image.FromFile("..\\..\\AppResource\\placeholder_tablet.png");
            }
            buttonChoose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonChoose.FlatStyle = FlatStyle.Flat;
            buttonChoose.FlatAppearance.BorderSize = 0;
            buttonChoose.Dock = DockStyle.Top;
            buttonChoose.Height = 200;
            buttonChoose.Tag = sanPhamBan;
            

            // Sự kiện bấm vào sản phẩm
            buttonChoose.Click += buttonClick;

            // Hiển thị Tên sản phẩm
            Label lbTenSanPham = new Label();
            lbTenSanPham.Text = sanPhamBan.TenSanPham;
            lbTenSanPham.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            lbTenSanPham.ForeColor = Color.Black;
            lbTenSanPham.Location = new Point(10, 20);
            lbTenSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // Hiển thị Mã sản phẩm 
            Label lbMaSanPham = new Label();
            lbMaSanPham.Text = "ID: " + sanPhamBan.MaSanPham;
            lbMaSanPham.Font = new Font(FontFamily.GenericSansSerif, 10);
            lbMaSanPham.ForeColor = Color.Black;
            lbMaSanPham.Location = new Point(10, 40);
            lbMaSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // Hiển thị Giá bán
            Label lbGiaBan = new Label();
            lbGiaBan.Text = "Giá: " + sanPhamBan.GiaBan.ToString() + "đ";
            lbGiaBan.Font = new Font(FontFamily.GenericSansSerif, 10);
            lbGiaBan.ForeColor = Color.Black;
            lbGiaBan.Location = new Point(10, 60);
            lbGiaBan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // Hiển thị số lượng
            Label lbSoLuong = new Label();
            lbSoLuong.Text = "Số lượng: " + sanPhamBan.SoLuong;
            lbSoLuong.Font = new Font(FontFamily.GenericSansSerif, 10);
            lbSoLuong.ForeColor = Color.Black;
            lbSoLuong.Location = new Point(10, 80);
            lbSoLuong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // Add những thứ ở trên vào panel phù hợp
            panelSmall.Controls.Add(lbTenSanPham);
            panelSmall.Controls.Add(lbMaSanPham);
            panelSmall.Controls.Add(lbGiaBan);
            panelSmall.Controls.Add(lbSoLuong);
            panelSmall.Controls.Add(buttonChoose);
            panelBig.Controls.Add(panelSmall);

            // Add những thứ phù hơp vào panel chính
            flowPanel.Controls.Add(panelBig);
        }

        // Load dữ liệu từ CSDL để đưa vào control
        public void LoadSanPham(FlowLayoutPanel mainPanel) 
        {
            DataTable data = SanPhamDAO.Instance.GetDsSanPhamBan();
            foreach (DataRow row in data.Rows)
            {
                SanPhamBan sanPhamBan = new SanPhamBan(row);
                ThemSanPhamVaoFlowPanel(mainPanel, sanPhamBan);
            }
        }

        // Load dữ liệu lọc sản phẩm
        public void LoadFilterSanPham(FlowLayoutPanel mainPanel, int maSanPham, string tenSanPham, string loaiSanPham, string tenNhaCungCap) 
        {
            mainPanel.Controls.Clear();
            DataTable data = SanPhamDAO.Instance.GetSanPhamLoc(maSanPham, tenSanPham, loaiSanPham, tenNhaCungCap);
            foreach (DataRow row in data.Rows)
            {
                SanPhamBan sanPhamBan = new SanPhamBan(row);
                ThemSanPhamVaoFlowPanel(mainPanel, sanPhamBan);
            }
        }

        // Clear dữ liệu 
        public void ResetSanPham(FlowLayoutPanel flowPanel)
        {
            flowPanel.Controls.Clear();
            LoadSanPham(flowPanel);
        }

        // Đưa loại sản phảm vào combo box
        public void LoadComboBoxLoaiSanPham(ComboBox comboBox)
        {
            foreach (DataRow row in SanPhamDAO.Instance.GetDsLoaiSanPham().Rows)
            {
                comboBox.Items.Add((string)row["LOAISP"]);
            }
        }

        // Bấm vào cái hình trong danh mục sản phẩm thì nó hiện thông tin vào các textbox
        void buttonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            listTextBox.ToArray()[0].Text = (btn.Tag as SanPhamBan).MaSanPham.ToString();
            listTextBox.ToArray()[1].Text = (btn.Tag as SanPhamBan).TenSanPham;
            if (listTextBox.Count > 2) 
            {
                listTextBox.ToArray()[2].Text = (btn.Tag as SanPhamBan).LoaiSanPham;
                listTextBox.ToArray()[3].Text = (btn.Tag as SanPhamBan).GiaBan.ToString();
            }
        }

        // Sử dụng để tính toán thanh toán
        int totalPrice = 0;
        
        public void AddItemToListView(ListView listView, int maSanPham, string tenSanPham, int soLuong, float giaBan)
        {
            bool check = true;
            for (int i = 0; i < listView.Items.Count; i++) 
            {
                if (listView.Items[i].SubItems[0].Text.Equals(maSanPham.ToString())) 
                {
                    if (int.Parse(listView.Items[i].SubItems[2].Text) + soLuong > GetProductByID(maSanPham).SoLuong)
                    {
                        listView.Items[i].SubItems[2].Text = GetProductByID(maSanPham).SoLuong.ToString();
                    }
                    else 
                    {
                        listView.Items[i].SubItems[2].Text = (int.Parse(listView.Items[i].SubItems[2].Text) + soLuong).ToString();
                    }
                    if (decimal.TryParse(listView.Items[i].SubItems[2].Text, out decimal number) && decimal.TryParse(listView.Items[i].SubItems[3].Text, out decimal money))
                    {
                        listView.Items[i].SubItems[4].Text = (number * money).ToString();
                    }
                    check = false;
                }
            }
            if (check) 
            {
                ListViewItem lvwItem = new ListViewItem(maSanPham.ToString());
                lvwItem.SubItems.Add(tenSanPham);
                lvwItem.SubItems.Add(soLuong.ToString());
                lvwItem.SubItems.Add(giaBan.ToString());
                int productPrice = soLuong * (int)giaBan;
                lvwItem.SubItems.Add(productPrice.ToString());
                totalPrice += productPrice;
                
                listView.Items.Add(lvwItem);
            }
        }

        // Lấy danh sách sản phẩm chốt đơn :))
        public List<SanPhamBan> GetListSale(ListView list) 
        {
            List<SanPhamBan> lstSanPhamBan = new List<SanPhamBan>();
            for (int i = 0; i < list.Items.Count; i++)
            {
                string maSP = list.Items[i].SubItems[0].Text;
                string tenSP = list.Items[i].SubItems[1].Text;
                string soLuong = list.Items[i].SubItems[2].Text;
                
                SanPhamBan sanPhamBan = new SanPhamBan(int.Parse(maSP), tenSP, int.Parse(soLuong));
                lstSanPhamBan.Add(sanPhamBan);
            }
            return lstSanPhamBan;
        }

        // Tạo và lưu hóa đơn
        public int SaveInvoice(string maNhanVien, string sdtKhachHang, string tenKhachHang, DateTime ngayLap, decimal tongTien, ListView listView)
        {
            string maKhachHang = new KhachHangBUS().GetCustomerID(sdtKhachHang, tenKhachHang);
            HoaDonDAO.Instance.GenerateInvoice(maNhanVien, maKhachHang, ngayLap, tongTien);
            HoaDon hoaDon = new HoaDon(HoaDonDAO.Instance.GetLastInvoice().Rows[0]);
            int maHoaDon = hoaDon.MaHoaDon;
            foreach (SanPhamBan sanPham in GetListSale(listView))
            {
                try
                {
                    HoaDonDAO.Instance.AddInvoiceDetail(maHoaDon, sanPham.MaSanPham, sanPham.SoLuong);
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
            return maHoaDon;
        }

        // Lấy thông tin sản phẩm bằng mã sản phẩm 
        public SanPhamBan GetProductByID(int maSanPham)
        {
            if (SanPhamDAO.Instance.GetProductByID(maSanPham).Rows.Count > 0)
            {
                return new SanPhamBan(SanPhamDAO.Instance.GetProductByID(maSanPham).Rows[0]);
            }
            return null;
        }
    }
}
