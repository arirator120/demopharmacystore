using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class SanPhamBanDAO
    {
        private static SanPhamBanDAO instance;
        public static SanPhamBanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamBanDAO();
                }
                return SanPhamBanDAO.instance;
            }
        }
        private SanPhamBanDAO() { }
        public DataTable GetDsSanPhamBan()
        {
            string query = "exec DS_NV";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
