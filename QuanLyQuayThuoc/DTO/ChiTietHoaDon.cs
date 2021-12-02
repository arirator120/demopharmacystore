using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace DTO
{
    public class ChiTietHoaDon
    {
        [Display(Name = "ID")]
        private int maSanPham;
        [Display(Name = "Ten san pham")]
        private string tenSanPham;
        [Display(Name = "So luong")]
        private int soLuong;
        [Display(Name = "Gia tien")]
        private decimal giaTien;
        [Display(Name = "Thanh tien")]
        private decimal thanhTien;

        public ChiTietHoaDon(DataRow row)
        {
            maSanPham = (int)row["MASP"];
            tenSanPham = (string)row["TENSP"];
            soLuong = (int)row["SL"];
            giaTien = (decimal)row["GIABAN"];
        }
        #region Get - Set
        public int MaSanPham 
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }
        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public decimal GiaTien
        {
            get { return giaTien; }
            set { giaTien = value; }
        }
        public decimal ThanhTien
        {
            get { return giaTien * soLuong; }
            set { thanhTien = giaTien * soLuong; }
        }
        #endregion
    }
}
