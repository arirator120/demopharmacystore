using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DoiMatKhauBUS
    {
        public static int DoiMatKhau(string TenDN, string MKCu, string MKMoi)
        {
            return DoiMatKhauDAO.Instance.DoiMatKhau(TenDN, MKCu, MKMoi);
        }
    }
}
