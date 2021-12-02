using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.IO;

namespace DTO
{
    public class SanPhamBan
    {
        private int maSanPham;
        private string tenSanPham;
        private string maNhaCungCap;
        private string loaiSanPham;
        private Image hinhSanPham = null;
        private string donVitinh;
        private decimal giaBan;
        private int soLuong;
        private string moTa;

        // Constructor này dùng để them sản phẩm vào hóa đơn
        public SanPhamBan(int maSanPham, string tenSanPham, int soLuong)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.soLuong = soLuong;
        }


        /// <summary>
        /// Lấy thông tin sản phẩm từ cơ sở dữ liệu
        /// </summary>
        /// <param name="row"></param>
        public SanPhamBan(DataRow row) 
        {
            maSanPham = (int)row["MASP"];
            maNhaCungCap = (string)row["MANCC"];
            tenSanPham = (string)row["TENSP"];
            loaiSanPham = (string)row["LOAISP"];
            if (row["HINHANH"] != DBNull.Value) 
            {
                hinhSanPham = ByteArrToImage((byte[])row["HINHANH"]);
            }
            donVitinh = (string)row["DVT"];
            giaBan = (decimal)row["GIABAN"];
            soLuong = (int)row["SL"];
            moTa = (string)row["MOTA"];
        }

        // Lấy hình ảnh từ dạng byte[]
        private Image ByteArrToImage(byte[] imgArr)
        {
            MemoryStream m = new MemoryStream(imgArr);
            return Image.FromStream(m);
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
        public string MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }
        public string LoaiSanPham
        {
            get { return loaiSanPham; }
            set { loaiSanPham = value; }
        }
        public Image HinhSanPham
        {
            get { return hinhSanPham; }
            set { hinhSanPham = value; }
        }
        public string DonViTinh
        {
            get { return donVitinh; }
            set { donVitinh = value; }
        }
        public decimal GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        #endregion
    }
}
