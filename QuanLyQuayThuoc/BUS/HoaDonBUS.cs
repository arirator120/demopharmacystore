using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class HoaDonBUS
    {
        public List<ChiTietHoaDon> GetInvoiceDetailById(int maHoaDon) 
        {
            List<ChiTietHoaDon> details = new List<ChiTietHoaDon>();
            foreach (DataRow row in HoaDonDAO.Instance.GetInvoiceDetailById(maHoaDon).Rows)
            {
                ChiTietHoaDon detail = new ChiTietHoaDon(row);
                details.Add(detail);
            }
            return details;
        }

        public HoaDon GetInvoiceLast() 
        {
            HoaDon hoaDon = new HoaDon(HoaDonDAO.Instance.GetLastInvoice().Rows[0]);
            return hoaDon;
        }
    }
}
