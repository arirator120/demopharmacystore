using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class NhaCungCap
    {
        private string maNhaCungCap { get; set; }
        private string tenNhaCungCap { get; set; }
        private string soDienThoai { get; set; }
        private string diaChi { get; set; }

        public NhaCungCap(DataRow row) 
        {
            maNhaCungCap = (string)row["MANCC"];
            tenNhaCungCap = (string)row["TENNCC"];
            soDienThoai = (string)row["SDT"];
            diaChi = (string)row["DIACHI"];
        }

        #region Get - Set
        public string MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }
        public string TenNhaCungCap
        {
            get { return tenNhaCungCap; }
            set { tenNhaCungCap = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        #endregion

    }
}
