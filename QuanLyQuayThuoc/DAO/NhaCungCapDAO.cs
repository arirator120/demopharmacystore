using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapDAO();
                }
                return NhaCungCapDAO.instance;
            }
        }

        public NhaCungCapDAO() { }

        // Lấy danh sách các nhà cung cấp dạng bảng
        public DataTable GetDsNhaCungCap()
        {
            string query = "exec GET_NHACUNGCAP_ALL";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int ThemNhaCungCap(string MANCC, string TENNCC, string SDT, string DIACHI)
        {
            string query = "exec THEMNHACUNGCAP @MANCC , @TENNCC , @SDT , @DIACHI";
            object[] ojb = { MANCC, TENNCC, SDT, DIACHI };
            return DataProvider.Instance.ExecuteNonQuery(query, ojb);
        }
        public int DeleteNhaCungCap(string MaNCC)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec XOANCC @MANCC", new object[] { MaNCC });
        }

    }
}
