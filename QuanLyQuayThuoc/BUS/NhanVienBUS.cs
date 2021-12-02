using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {
        public DataTable GetDsNhanVien() 
        {
            return NhanVienDAO.Instance.GetDsNhanVien();
        }

        public bool UserLogin(string username, string password)
        {
            return NhanVienDAO.Instance.GetLogin(username, password) > 0;
        }

        public NhanVien GetUserInformation() 
        {
            return NhanVienDAO.Instance.GetUserInformation();
        }

        public static int UpdateThongTinNhanVien(NhanVien nhanVien)
        {
            return NhanVienDAO.Instance.UpdateThongTinNhanVien(nhanVien);
        }

        public static int UpdateThongTinNhanVien(object[] obj)
        {
            return NhanVienDAO.Instance.UpdateThongTinNhanVien(obj);
        }

        public NhanVien GetNhanVienById(string maNV)
        {
            DataTable result = NhanVienDAO.Instance.GetNhanVienById(maNV);
            if (result.Rows.Count > 0)
            {
                return new NhanVien(result.Rows[0]);
            }
            return null;
        }

        public int AddUserAccount(string maNV, string username, string password)
        {
            return NhanVienDAO.Instance.AddUserAccount(maNV, username, password);
        }

        public NhanVien GetAdminLast()
        {
            DataTable result = NhanVienDAO.Instance.GetAdminLast();
            if (result.Rows.Count > 0)
            {
                return new NhanVien(result.Rows[0]);
            }
            return null;
        }

        public NhanVien GetUserLast()
        {
            DataTable result = NhanVienDAO.Instance.GetUserLast();
            if (result.Rows.Count > 0)
            {
                return new NhanVien(result.Rows[0]);
            }
            return null;
        }

        public int AddUser(object[] obj)
        {
            return NhanVienDAO.Instance.AddUser(obj);
        }
    }
}
