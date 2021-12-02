using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhoThuocBUS
    {
        public static DataTable GetDsThuoc()
        {
            return KhoThuocDAO.Instance.GetDsThuoc();
        }

        public static int SaveNewSP(object[] obj)
        {
            return KhoThuocDAO.Instance.SaveNewSP(obj);
        }

        public static int DeleteSP(string maSP)
        {
            return KhoThuocDAO.Instance.DeleteSP(maSP);
        }

        public static int UpdateSP(object[] obj)
        {
            return KhoThuocDAO.Instance.UpdateSP(obj);
        }
    }
}
