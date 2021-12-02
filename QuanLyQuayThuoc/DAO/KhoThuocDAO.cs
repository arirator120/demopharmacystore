using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhoThuocDAO
    {
        private static KhoThuocDAO instance;
        public static KhoThuocDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhoThuocDAO();
                }
                return KhoThuocDAO.instance;
            }
        }

        public KhoThuocDAO() { }

        public DataTable GetDsThuoc()
        {
            string query = "exec DS_SP";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int SaveNewSP(object[] obj)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec THEMSANPHAM @MANCC , @TENSP , @LOAISP , @HINHANH , @DVT , @GIABAN , @GIANHAP , @SL , @MoTa ", obj);
        }

        public int DeleteSP(string maSP)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec XOASANPHAM @MASP", new object[] { maSP });
        }

        public int UpdateSP(object[] obj)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec CAPNHATSANPHAM @MASP , @MANCC , @TENSP , @LOAISP , @HINHANH , @DVT , @GIABAN , @GIANHAP , @SL , @MoTa ", obj);
        }
    }
}
