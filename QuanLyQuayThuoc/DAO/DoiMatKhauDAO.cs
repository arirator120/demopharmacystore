using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DoiMatKhauDAO
    {
        private static DoiMatKhauDAO instance;
        public static DoiMatKhauDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoiMatKhauDAO();
                }
                return DoiMatKhauDAO.instance;
            }
        }

        public DoiMatKhauDAO() { }

        public int DoiMatKhau(string TenDN, string MKCu, string MKMoi)
        {
            string query = "exec DOIMK @TenDN , @MKCu , @MKMoi";
            object[] obj = { TenDN, MKCu, MKMoi };
            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }
    }
}
