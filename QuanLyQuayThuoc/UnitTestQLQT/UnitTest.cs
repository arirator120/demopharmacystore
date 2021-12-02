using DAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace UnitTestDAO
{
    [TestClass]
    public class UnitTest
    {
        //NhaCungCapDAO
        [TestMethod]
        public void Test1_ThemNhaCungCap()
        {
            var obj = new NhaCungCapDAO();
            int result = obj.ThemNhaCungCap("NCC3", "ThuocTien", "0124124128", "Hà Nội");

            Assert.IsTrue(result==1);
        }

        [TestMethod]
        public void Test2_ThemNhaCungCap()
        {
            var obj = new NhaCungCapDAO();
            int result = obj.ThemNhaCungCap("NCC1", "LongVip", "0435234239", "Bình Dương");

            Assert.IsTrue(result==-1);
        }

        [TestMethod]
        public void Test3_ThemNhaCungCap()
        {
            var obj = new NhaCungCapDAO();
            int result = obj.ThemNhaCungCap("NCC4", "LongVip", "04352342399", "Bình Dương");

            Assert.IsTrue(result == -1);
        }   

        [TestMethod]
        public void Test1_XoaNhaCungCap()
        {
            var obj = new NhaCungCapDAO();
            int result = obj.DeleteNhaCungCap("NCC3");

            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void Test2_XoaNhaCungCap()
        {
            var obj = new NhaCungCapDAO();
            int? result = obj.DeleteNhaCungCap("NCC6");
            if (result == null)
                Assert.Fail();
        }

        [TestMethod]
        public void Test3_XoaNhaCungCap()
        {
            var obj = new NhaCungCapDAO();
            int result = obj.DeleteNhaCungCap("NCC3");

            Assert.IsTrue(result == -1);
        }

        [TestMethod]
        public void Test1_TraVeDSNCC()
        {
            var obj = new NhaCungCapDAO();
            DataTable view = obj.GetDsNhaCungCap();

            Assert.AreEqual<string>("NCC1", view.Rows[0].ItemArray[0].ToString());
        }

        [TestMethod]
        public void Test2_TraVeDSNCC()
        {
            var obj = new NhaCungCapDAO();
            DataTable view = obj.GetDsNhaCungCap();

            Assert.AreNotEqual<string>("NCC1", view.Rows[0].ItemArray[1].ToString());
        }

        [TestMethod]
        public void Test3_TraVeDSNCC()
        {
            var obj = new NhaCungCapDAO();
            DataTable view = obj.GetDsNhaCungCap();

            Assert.AreNotEqual<string>("LongVip", view.Rows[2].ItemArray[0].ToString());
        }

        //NhapHangDAO
        [TestMethod]
        public void Test1_DSThuoc()
        {
            var obj = new NhapHangDAO();
            DataTable view = obj.GetDsThuoc();

            Assert.AreEqual<string>("SP1", view.Rows[0].ItemArray[0].ToString());
        }

        [TestMethod]
        public void Test2_DSThuoc()
        {
            var obj = new NhapHangDAO();
            DataTable view = obj.GetDsThuoc();

            Assert.AreNotEqual<string>("SP1", view.Rows[2].ItemArray[0].ToString());
        }

        [TestMethod]
        public void Test3_DSThuoc()
        {
            var obj = new NhapHangDAO();
            DataTable view = obj.GetDsThuoc();

            Assert.AreNotEqual<string>("SP8", view.Rows[0].ItemArray[0].ToString());
        }

        [TestMethod]
        public void Test1_NhapDonMoi()
        {
            var obj = new NhapHangDAO();
            int result = obj.InsertDonNhapMoi(new object[] {"ADMIN00001", "2021-05-08", "2021-05-15", "500000", "False" });

            Assert.AreEqual<int>(1, result);
        }

        [TestMethod]
        public void Test2_NhapDonMoi()
        {
            var obj = new NhapHangDAO();
            int result = obj.InsertDonNhapMoi(new object[] { "ADMIN00002", "2021-05-07", "2021-05-10", "40000", "False" });

            Assert.AreEqual<int>(1, result);
        }

        [TestMethod]
        public void Test1_ThemChiTietDonNhap()
        {
            var obj = new NhapHangDAO();
            int result = obj.InsertCTDN(new object[] {"SP3", 2});

            Assert.AreEqual<int>(1, result);
        }

        [TestMethod]
        public void Test2_ThemChiTietDonNhap()
        {
            var obj = new NhapHangDAO();
            int result = obj.InsertCTDN(new object[] { "SP1", 5 });

            Assert.AreEqual<int>(1, result);
        }

        //KhoThuocDAO
        [TestMethod]
        public void Test1_ThemSanPhamMoi()
        {
            var obj = new KhoThuocDAO();
            Byte[] b = new byte[0];
            int result = obj.SaveNewSP(new object[] {"NCC1", "Yumangel", "Thuốc điều trị", b, "Gói", 100000, 80000, 10, "", "2022-07-20"});

            Assert.AreEqual<int>(1, result);
        }

        [TestMethod]
        public void Test2_ThemSanPhamMoi()
        {
            var obj = new KhoThuocDAO();
            Byte[] b = new byte[0];
            int? result = obj.SaveNewSP(new object[] { "NCC10", "Yumangel", "Thuốc điều trị", b, "Gói", 100000, 80000, 10, "", "2022-07-20" });

            if (result == null)
                Assert.Fail();
        }

        [TestMethod]
        public void Test1_XoaSanPham()
        {
            var obj = new KhoThuocDAO();
            int result = obj.DeleteSP("SP1");

            Assert.AreEqual<int>(1, result);
        }

        [TestMethod]
        public void Test2_XoaSanPham()
        {
            var obj = new KhoThuocDAO();
            int result = obj.DeleteSP("SP10");

            Assert.AreEqual<int>(1, result);
        }

        [TestMethod]
        public void Test1_CapNhatSanPham()
        {
            var obj = new KhoThuocDAO();
            Byte[] b = new Byte[0];
            int result = obj.UpdateSP(new object[] {"SP4", "NCC3", "Yumangel", "Thuốc điều trị", b, "Gói", 100000, 80000, 10, "", "2022-07-20" });

            Assert.AreEqual<int>(1, result);
        }

        [TestMethod]
        public void Test2_CapNhatSanPham()
        {
            var obj = new KhoThuocDAO();
            Byte[] b = new Byte[0];
            int result = obj.UpdateSP(new object[] { "SP10", "NCC3", "Yumangel", "Thuốc điều trị", b, "Gói", 100000, 80000, 10, "", "2022-07-20" });

            Assert.AreEqual<int>(-1, result);
        }

        [TestMethod]
        public void Test3_CapNhatSanPham()
        {
            var obj = new KhoThuocDAO();
            Byte[] b = new Byte[0];
            int result = obj.UpdateSP(new object[] { "SP4", "NCC3", "Yumangel", "Thuốc điều trị", b, "Gói", 100000, 80000, 10, "Trị viêm dạ dày, viêm loét dạ dày tá tràng", "2022-07-20" });

            Assert.AreEqual<int>(1, result);
        }

        [TestMethod]
        public void Test1_DSSanPhamThuoc()
        {
            var obj = new KhoThuocDAO();
            DataTable view = obj.GetDsThuoc();

            Assert.AreEqual<string>("SP1", view.Rows[0].ItemArray[0].ToString());
        }

        [TestMethod]
        public void Test2_DSSanPhamThuoc()
        {
            var obj = new KhoThuocDAO();
            DataTable view = obj.GetDsThuoc();

            Assert.AreNotEqual<string>("SP1", view.Rows[0].ItemArray[1].ToString());
        }

        [TestMethod]
        public void Test3_DSSanPhamThuoc()
        {
            var obj = new KhoThuocDAO();
            DataTable view = obj.GetDsThuoc();

            Assert.AreNotEqual<string>("SP8", view.Rows[0].ItemArray[0].ToString());
        }


        //SanPhamDAO
        [TestMethod]
        public void Test1_DSSanPhamBan()
        {
            var obj = new SanPhamDAO();
            DataTable view = obj.GetDsSanPhamBan();

            Assert.AreEqual<string>("SP4", view.Rows[3].ItemArray[0].ToString());
        }

        [TestMethod]
        public void Test2_DSSanPhamBan()
        {
            var obj = new SanPhamDAO();
            DataTable view = obj.GetDsSanPhamBan();

            Assert.AreNotEqual<string>("SP9", view.Rows[3].ItemArray[0].ToString());
        }

        [TestMethod]
        public void Test1_DSLoaiSP()
        {
            var obj = new SanPhamDAO();
            DataTable view = obj.GetDsLoaiSanPham();

            Assert.AreEqual<string>("Giảm đau", view.Rows[0].ItemArray[0].ToString());
        }

        [TestMethod]
        public void Test2_DSLoaiSP()
        {
            var obj = new SanPhamDAO();
            DataTable view = obj.GetDsLoaiSanPham();

            Assert.AreNotEqual<string>("Giảm đau", view.Rows[1].ItemArray[0].ToString());
        }

        //DoiMatKhauDAO
        [TestMethod]
        public void Test1_DoiMatKhau()
        {
            DoiMatKhauDAO dmk = new DoiMatKhauDAO();
            int result = dmk.DoiMatKhau("TADAadmin", "TADATADATADA", "TADATADATADA");
            Assert.AreEqual<int>(result, 1);
        }

        [TestMethod]
        public void Test2_DoiMatKhau()
        {
            DoiMatKhauDAO dmk = new DoiMatKhauDAO();
            int result = dmk.DoiMatKhau("TADA", "TADATADATADA", "TADATADATADA");
            Assert.AreEqual<int>(result, -1);
        }


        //HoaDonDAO
        [TestMethod]
        public void Test1_GenerateInvoice()
        {
            HoaDonDAO obj = new HoaDonDAO();
            Boolean result = obj.GenerateInvoice("ADMIN00001", "0354876543", DateTime.Today, 300000);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test2_GenerateInvoice()
        {
            HoaDonDAO obj = new HoaDonDAO();
            Boolean result = obj.GenerateInvoice("ADMIN00001", "0135489496", DateTime.Today, 300000);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test3_GenerateInvoice()
        {
            HoaDonDAO obj = new HoaDonDAO();
            Boolean result = obj.GenerateInvoice("ADMIN1", "3784325489", DateTime.Today, 300000);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test1_AddInvoiceDetail()
        {
            HoaDonDAO obj = new HoaDonDAO();
            Boolean result = obj.AddInvoiceDetail(6, 1, 5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test2_AddInvoiceDetail()
        {
            HoaDonDAO obj = new HoaDonDAO();
            Boolean result = obj.AddInvoiceDetail(6, 10, 5);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test3_AddInvoiceDetail()
        {
            HoaDonDAO obj = new HoaDonDAO();
            Boolean result = obj.AddInvoiceDetail(10, 1, 2);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test1_GetDsHoaDon()
        {
            HoaDonDAO obj = new HoaDonDAO();
            DataTable dt = obj.GetDsHoaDon();
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[4].ToString(), "1350000");
        }

        [TestMethod]
        public void Test1_GetLastInvoice()
        {
            HoaDonDAO obj = new HoaDonDAO();
            DataTable dt = obj.GetLastInvoice();
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[0].ToString(), "HD6");
        }


        //KhachHangDAO
        [TestMethod]
        public void Test1_GetDsKhachHang()
        {
            KhachHangDAO obj = new KhachHangDAO();
            DataTable dt = obj.GetDsKhachHang();
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[0].ToString(), "KH1");
        }

        [TestMethod]
        public void Test1_GetCustomerByID()
        {
            KhachHangDAO obj = new KhachHangDAO();
            DataTable dt = obj.GetCustomerByID("KH1");
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[1].ToString(), "NGUYEN VAN A");
        }

        [TestMethod]
        public void Test1_GetCustomerByName()
        {
            KhachHangDAO obj = new KhachHangDAO();
            DataTable dt = obj.GetCustomerByName("NGUYEN VAN B");
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[0].ToString(), "KH2");
        }

        [TestMethod]
        public void Test1_GetLastCustomer()
        {
            KhachHangDAO obj = new KhachHangDAO();
            DataTable dt = obj.GetLastCustomer();
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[1].ToString(), "NGUYEN VAN C");
        }


        //LichSuBanHangDAO
        [TestMethod]
        public void Test1_GetLSBanHang()
        {
            LichSuBanHangDAO obj = new LichSuBanHangDAO();
            DataTable dt = obj.GetLSBanHang();
            Assert.AreEqual<string>(dt.Rows[1].ItemArray[2].ToString(), "KH2");
        }

        [TestMethod]
        public void Test1_GetTTBanHang()
        {
            LichSuBanHangDAO obj = new LichSuBanHangDAO();
            DataTable dt = obj.GetTTBanHang("HD1");
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[2].ToString(), "3");
        }

        [TestMethod]
        public void Test2_GetTTBanHang()
        {
            LichSuBanHangDAO obj = new LichSuBanHangDAO();
            DataTable dt = obj.GetTTBanHang("HD3");
            Assert.IsTrue(dt.Rows.Count == 0);
        }

        [TestMethod]
        public void Test1_GetTongThuNhap()
        {
            LichSuBanHangDAO obj = new LichSuBanHangDAO();
            DataTable dt = obj.GetTongThuNhap("4/26/2021");
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[0].ToString(), "1350000");
        }

        [TestMethod]
        public void Test1_UpdateRowBanHang()
        {
            LichSuBanHangDAO obj = new LichSuBanHangDAO();
            int result = obj.UpdateRowBanHang(new object[] { "HD1", "ADMIN00001", "KH1", DateTime.Today, 1350000, true });
            Assert.IsTrue(result == 1);
        }


        //LichSuNhapHangDAO
        [TestMethod]
        public void Test1_GetLSNhapHang()
        {
            LichSuNhapHangDAO obj = new LichSuNhapHangDAO();
            DataTable dt = obj.GetLSNhapHang();
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[4].ToString(), "450000");
        }

        [TestMethod]
        public void Test1_GetTTNhapHang()
        {
            LichSuNhapHangDAO obj = new LichSuNhapHangDAO();
            DataTable dt = obj.GetTTNhapHang("DN1");
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[2].ToString(), "30");
        }

        [TestMethod]
        public void Test2_GetTTNhapHang()
        {
            LichSuNhapHangDAO obj = new LichSuNhapHangDAO();
            DataTable dt = obj.GetTTNhapHang("DN10");
            Assert.IsTrue(dt.Rows.Count == 0);
        }

        [TestMethod]
        public void Test1_GetTongChi()
        {
            LichSuNhapHangDAO obj = new LichSuNhapHangDAO();
            DataTable dt = obj.GetTongChi("4/27/2021");
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[0].ToString(), "450000");
        }

        [TestMethod]
        public void Test1_UpdateRowNhapHang()
        {
            LichSuNhapHangDAO obj = new LichSuNhapHangDAO();
            int result = obj.UpdateRowNhapHang(new object[] { "DN1", "ADMIN00001", DateTime.Today, DateTime.Today, 450000, true });
            Assert.IsTrue(result == 1);
        }


        //NhanVienDAO
        [TestMethod]
        public void Test1_GetDsNhanVien()
        {
            NhanVienDAO obj = new NhanVienDAO();
            DataTable dt = obj.GetDsNhanVien();
            Assert.AreEqual<string>(dt.Rows[0].ItemArray[0].ToString(), "ADMIN00001");
        }

        [TestMethod]
        public void Test1_GetLogin()
        {
            NhanVienDAO obj = new NhanVienDAO();
            int result = obj.GetLogin("TADAadmin", "TADATADATADA");
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Test2_GetLogin()
        {
            NhanVienDAO obj = new NhanVienDAO();
            int result = obj.GetLogin("TADAadmin", "123456");
            Assert.IsTrue(result == 0);
        }
    }
}
