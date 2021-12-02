using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DTO;
using System.Collections.Generic;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }

        public void InitData(string maHD, DateTime ngayLap, string tenNV, string maNV, string tenKH, string sdtKH, string tienNhan, string tienThua, List<ChiTietHoaDon> data) 
        {
            paramTenNhaThuoc.Value = "TADA Pharma";
            paramMaHoaDon.Value = maHD;
            paramNgayLap.Value = ngayLap;
            paramTenNhanVien.Value = tenNV;
            paramMaNhanVien.Value = maNV;
            paramTenKhachHang.Value = tenKH;
            paramSoDienThoai.Value = sdtKH;
            paramTienNhan.Value = tienNhan;
            paramTienThua.Value = tienThua;
            objectDataSource1.DataSource = data;
        }

    }
}
