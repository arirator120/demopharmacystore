using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAO();
                }
                return HoaDonDAO.instance;
            }
        }

        public HoaDonDAO() { }

        // Nhập hóa đơn mới
        public bool GenerateInvoice(string maNhanVien, string sdtKhachHang, DateTime ngayLap, decimal tongTien)
        {
            string query = "exec GENERATE_INVOICE @maNhanVien , @maKhachHang , @ngayLap , @tongTien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNhanVien, sdtKhachHang, ngayLap, tongTien });
            return data.Rows.Count > 0;
        }

        // Nhập vào chi tiết hóa đơn
        public bool AddInvoiceDetail(int maHoaDon, int maSanPham, int soLuong) 
        {
            string query1 = "exec ADD_INVOICE_DETAIL @maHoaDon , @maSanPham , @soLuong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query1, new object[] { maHoaDon, maSanPham, soLuong });
            
            string query2 = "exec UPDATE_PRODUCT_AMOUNT @maSanPham , @soLuong";
            DataProvider.Instance.ExecuteQuery(query2, new object[] { maSanPham, soLuong });
            return (data.Rows.Count > 0);
        }

        // Trả về danh sách các hóa đơn
        public DataTable GetDsHoaDon()
        {
            string query = "exec GET_INVOICE_ALL";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        // Trả về hóa đơn cuối cùng trong bảng hóa đơn
        public DataTable GetLastInvoice()
        {
            string query = "exec GET_INVOICE_LAST";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        // Trả về chi tiết hóa đơn theo id
        public DataTable GetInvoiceDetailById(int maHoaDon) 
        {
            string query = "exec GET_INVOICE_DETAIL_BY_ID @maHoaDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maHoaDon });
            return data;
        }
    }
}
