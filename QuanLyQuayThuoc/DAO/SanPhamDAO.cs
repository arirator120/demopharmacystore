using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;
        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamDAO();
                }
                return SanPhamDAO.instance;
            }
        }

        public SanPhamDAO() { }

        // Lấy toàn bộ sản phẩm
        public DataTable GetDsSanPham()
        {
            string query = "exec GET_PRODUCT_ALL";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        // Lấy các sản phẩm để bán  
        public DataTable GetDsSanPhamBan()
        {
            string query = "exec GET_PRODUCT_FOR_SALE";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        // Lấy sản phẩm đã lọc
        public DataTable GetSanPhamLoc(int maSanPham, string tenSanPham, string loaiSanPham, string tenNhaCungCap) 
        {
            string query = "exec GET_PRODUCT_FILTER @maSanPham , @tenSanPham , @loaiSanPham , @tenNhaCungCap";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maSanPham, tenSanPham, loaiSanPham, tenNhaCungCap });
        }

        // Lấy danh sách các loại sản phẩm
        public DataTable GetDsLoaiSanPham() 
        {
            string query = "exec GET_PRODUCT_TYPE";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        // Lấy thông tin sản phẩm bằng mã sản phẩm
        public DataTable GetProductByID(int maSanPham)
        {
            string query = "exec GET_PRODUCT_BY_ID @masp";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maSanPham });
        }
    }
}
