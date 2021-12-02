using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string maNhanVien;
        private string tenNhanVien;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string cmnd;
        private string sdt;
        private string diaChi;
        private DateTime ngayVaoLam;
        private Decimal luong;
        private int phanQuyen;
        private bool hasAccount;

        public NhanVien()
        {
        }

        public NhanVien(DataRow row) 
        {
            maNhanVien = (string)row["MANV"];
            tenNhanVien = (string)row["TEN"];
            ngaySinh = (DateTime)row["NGAYSINH"];
            gioiTinh = (bool)row["GIOITINH"];
            cmnd = (string)row["CMND"];
            sdt = (string)row["SDT"];
            diaChi = (string)row["DiaChi"];
            ngayVaoLam = (DateTime)row["NGAYSINH"];
            luong = (Decimal)row["LUONG"];
            phanQuyen = (int)row["PHANQUYEN"];
            hasAccount = (bool)row["CO_TK"];
        }

        #region Get - Set
        public string MaNhanVien 
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public DateTime NgayVaoLam
        {
            get { return ngayVaoLam; }
            set { ngayVaoLam = value; }
        }
        public Decimal Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        public int PhanQuyen
        {
            get { return phanQuyen; }
            set { phanQuyen = value; }
        }
        public bool HasAccount
        {
            get { return hasAccount; }
            set { hasAccount = value; }
        }
        #endregion
    }
}
