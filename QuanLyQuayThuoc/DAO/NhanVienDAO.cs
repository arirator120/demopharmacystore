using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienDAO();
                }
                return NhanVienDAO.instance;
            }
        }

        private NhanVien currentUser;

        public NhanVienDAO() { }

        public DataTable GetDsNhanVien() 
        {
            string query = "exec DS_NV";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetLogin(string username, string password)
        {
            string query1 = "exec USER_LOGIN @username , @password";
            DataTable dataLogin = DataProvider.Instance.ExecuteQuery(query1, new object[] { username, password });

            string query2 = "exec GET_USER_BY_USERNAME_PASSWORD @username , @password";
            DataTable dataUser = DataProvider.Instance.ExecuteQuery(query2, new object[] { username, password });
            // Tạo dữ liệu nhân viên đăng nhập
            if (dataUser.Rows.Count > 0) currentUser = new NhanVien(dataUser.Rows[0]);

            return dataLogin.Rows.Count;
        }

        public NhanVien GetUserInformation() 
        {
            return currentUser;
        }

        public int UpdateThongTinNhanVien(NhanVien nhanvien)
        {
            string query = "exec CAPNHATTTCB @MANV , @TEN , @NGAYSINH , @GIOITINH , @CMND , @SDT , @DIACHI";
            object[] obj = { nhanvien.MaNhanVien, nhanvien.TenNhanVien, nhanvien.NgaySinh, nhanvien.GioiTinh, nhanvien.CMND, nhanvien.SDT, nhanvien.DiaChi };
            currentUser = nhanvien;
            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }

        public int UpdateThongTinNhanVien(object[] obj)
        {
            string query = "exec CAPNHATNHANVIEN @maNV , @tenNV , @ngaySinh , @gioiTinh , @cmnd , @sdt , @diaChi , @ngayVaoLam , @luong , @co_tk , @phanQuyen , @flag_lam";
            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }

        public DataTable GetNhanVienById(string maNhanVien) 
        {
            string query = "exec GET_USER_BY_ID @maNhanVien";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maNhanVien });
        }

        public int AddUserAccount(string maNV, string username, string password)
        {
            string query = "exec THEMTAIKHOAN @maNv , @username , @password";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNV, username, password });
        }

        public DataTable GetAdminLast()
        {
            string query = "exec GET_ADMIN_LAST";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetUserLast()
        {
            string query = "exec GET_User_LAST";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int AddUser(object[] obj) 
        {
            string query = "exec THEMNHANVIEN @MANV , @TEN , @NGAYSINH , @GIOITINH , @CMND , @SDT , @DIACHI , @NGAYVAOLAM , @LUONG , @PHANQUYEN";
            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }
    }
}
