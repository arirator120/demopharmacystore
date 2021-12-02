using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class KhachHang
    {
        private string maKhachHang;
        private string tenKhachHang;

        public KhachHang(DataRow row)
        {
            maKhachHang = (string)row["MAKH"];
            tenKhachHang = (string)row["TENKH"];
        }

        #region Get - Set
        public string MaKhachHang
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }
        public string TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }
        #endregion
    }
}
