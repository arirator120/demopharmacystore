using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BUS
{
    public class NhaCungCapBUS
    {
        // Lấy thông tin các nhà cung cấp ở dạng bảng
        public static DataTable GetDsNhaCungCap()
        {
            return NhaCungCapDAO.Instance.GetDsNhaCungCap();
        }
        public static int ThemNhaCungCap(string MANCC, string TENNCC, string SDT, string DIACHI)
        {
            return NhaCungCapDAO.Instance.ThemNhaCungCap(MANCC, TENNCC, SDT, DIACHI);
        }

        public static int DeleteNhaCungCap(string MaNCC)
        {
            return NhaCungCapDAO.Instance.DeleteNhaCungCap(MaNCC);
        }
        // Lấy thông tin nhà cung cấp ở dạng list
        public List<NhaCungCap> GetListNhaCungCap() 
        {
            List<NhaCungCap> listNhaCungCap = new List<NhaCungCap>();
            foreach (DataRow row in GetDsNhaCungCap().Rows)
            {
                NhaCungCap nhaCungCap = new NhaCungCap(row);
                listNhaCungCap.Add(nhaCungCap);
            }
            return listNhaCungCap;
        }

        // Đưa tên nhà cung cấp vào combo box
        public void LoadComboBoxTenNhaCungCap(System.Windows.Forms.ComboBox comboBox)
        {
            foreach (NhaCungCap item in GetListNhaCungCap()) 
            {
                comboBox.Items.Add(item.TenNhaCungCap);
            }
        }
    }
}
