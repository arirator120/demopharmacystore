using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class KhachHangBUS
    {
        /// <summary>
        /// Trả về danh sách các khách hàng
        /// </summary>
        /// <returns></returns>
        public List<KhachHang> GetDsKhachHang()
        {
            KhachHang khachHang;
            List<KhachHang> dsKhachHang = new List<KhachHang>();
            foreach (DataRow row in KhachHangDAO.Instance.GetDsKhachHang().Rows)
            {
                khachHang = new KhachHang(row);
                dsKhachHang.Add(khachHang);
            }
            return dsKhachHang;
        }

        /// <summary>
        /// Trả về một khách hàng dựa theo mã khách hàng
        /// </summary>
        /// <param name="maKhachHang"></param>
        /// <returns></returns>
        public KhachHang GetCustomerByID(string maKhachHang)
        {
            if (KhachHangDAO.Instance.GetCustomerByID(maKhachHang).Rows.Count > 0)
            {
                return new KhachHang(KhachHangDAO.Instance.GetCustomerByID(maKhachHang).Rows[0]);
            }
            return null;
        }

        /// <summary>
        /// Trả về một khách hàng cuối cùng trong CSDL được săos xêp theo mã khách khách hàng
        /// </summary>
        /// <returns></returns>
        public KhachHang GetLastCustomer()
        {
            if (KhachHangDAO.Instance.GetLastCustomer().Rows.Count > 0)
            {
                return new KhachHang(KhachHangDAO.Instance.GetLastCustomer().Rows[0]);
            }
            return null; // Cái này null chắc do trong danh sách chưa có ai
        }

        /// <summary>
        /// Trả về một khách hàng dựa theo tên khách hàng
        /// </summary>
        /// <param name="tenKhachHang"></param>
        /// <returns></returns>
        public KhachHang GetCustomerByName(string tenKhachHang)
        {
            if (KhachHangDAO.Instance.GetCustomerByName(tenKhachHang).Rows.Count > 0)
            {
                return new KhachHang(KhachHangDAO.Instance.GetCustomerByName(tenKhachHang).Rows[0]);
            } 
            return null;
        }

        /// <summary>
        /// Lấy mã khách hàng trong CSDL theo tên khách hàng (Ai trùng tên ráng chịu :>) 
        /// Nếu chưa có khách hàng đó thì tạo mã khách hàng và thêm vào CSDL
        /// </summary>
        /// <param name="tenKhachHang"></param>
        /// <returns>Mã khách hàng cũ hoặc mã khách hàng  mới tạo</returns>
        public string GetCustomerID(string sdtKhachHang, string tenKhachHang)
        {
            if (GetCustomerByID(sdtKhachHang) != null)
            {
                return sdtKhachHang;
            }

            // Thêm khách hàng mới khi không tìm được khách hàng trong CSDL
            KhachHangDAO.Instance.AddCustomer(sdtKhachHang, tenKhachHang);
            return sdtKhachHang;
        }
    }
}
