using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class HoaDon
    {
        private int maHoaDon;
        private string maNhanVien;
        private string maKhachHang;
        private DateTime ngayLap;
        private decimal tongTien;
        private bool trangThai;

        public HoaDon(DataRow row) 
        {
            maHoaDon = (int)row["MAHD"];
            maNhanVien = (string)row["MANV"];
            maKhachHang = (string)row["MAKH"];
            ngayLap = (DateTime)row["NGAYLAP"];
            tongTien = (decimal)row["TONGTIEN"];
            trangThai = (bool)row["TRANGTHAI"];
        }

        #region Get - Set
        public int MaHoaDon 
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        public string MaKhachHang
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }
        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        public decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        #endregion
    }
}
