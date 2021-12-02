using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangDAO();
                }
                return KhachHangDAO.instance;
            }
        }
        
        public KhachHangDAO() { }

        // Trả về danh sách những người đã mua hàng
        public DataTable GetDsKhachHang()
        {
            string query = "exec GET_CUSTOMER_ALL";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        // Trả về thông tin khách hàng theo mã khách hàng
        public DataTable GetCustomerByID(string maKhachHang)
        {
            string query = "exec GET_CUSTOMER_ID @maKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maKhachHang });
            return data;
        }

        // Trả về thông tin khách hàng theo tên khách hàng
        public DataTable GetCustomerByName(string tenKhachHang)
        {
            string query = "exec GET_CUSTOMER_NAME @tenKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenKhachHang });
            return data;
        }

        // Trả về khách hàng ở cuối danh sách khách hàng (để lấy ID và tạo ID cho khách hàng tiếp theo)
        public DataTable GetLastCustomer()
        {
            string query = "exec GET_CUSTOMER_LAST";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        // Thêm khách hàng vào CSDL
        public void AddCustomer(string sdtKhachHang, string tenKhachHang)
        {
            string query = "exec ADD_CUSTOMER @maKhachHang , @tenKhachHang";
            DataProvider.Instance.ExecuteQuery(query, new object[] { sdtKhachHang, tenKhachHang });
        }
    }
}
