using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QLHV;
using System.Collections.Generic;

namespace Caculator_Tester
{
    [TestClass]
    public class TestQLH
    {
        public TestContext TestContext { get; set; }
        private QuanLyHocVien qlhv;
        List<HocVien> hvs = new List<HocVien>();

        [TestInitialize]
        public void Setup()
        {
            qlhv = new QuanLyHocVien();
            qlhv.hvs = hvs; 
        }
        [TestMethod]
        public void TestMethod1()
        {
            hvs.Clear();
            HocVien hv = new HocVien(01, "A", "hcm", 8, 8, 8);
            hvs.Add(hv);
            Assert.AreEqual(true,qlhv.XacDinhDanhSachHocBong());
        }
        [TestMethod]
        public void TestMethod2()
        {
            hvs.Clear();
            HocVien hv = new HocVien(01, "A", "hcm", 5, 4, 6);
            hvs.Add(hv);
            Assert.AreEqual(false, qlhv.XacDinhDanhSachHocBong());
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @"X:\KTPM.FILE\NTest\Caculator Tester\Data\TestDataHV.csv", "TestDataHV#csv",
        DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMethod3()
        {
            HocVien hv = new HocVien(int.Parse(TestContext.DataRow[0].ToString()),
                                     TestContext.DataRow[1].ToString(),
                                     TestContext.DataRow[2].ToString(),
                                     double.Parse(TestContext.DataRow[3].ToString()),
                                     double.Parse(TestContext.DataRow[4].ToString()),
                                     double.Parse(TestContext.DataRow[5].ToString())
                                     );
            hvs.Clear();
            hvs.Add(hv);
            string exp = TestContext.DataRow[6].ToString();
            Assert.AreEqual(qlhv.XacDinhDanhSachHocBong().ToString(), exp);
        }
        //[TestMethod]
        //public void TestNhapThongTin()
        //{
        //    HocVien hv = new HocVien(int.Parse(TestContext.DataRow[0].ToString()),
        //                            TestContext.DataRow[1].ToString(),
        //                            TestContext.DataRow[2].ToString(),
        //                            double.Parse(TestContext.DataRow[3].ToString()),
        //                            double.Parse(TestContext.DataRow[4].ToString()),
        //                            double.Parse(TestContext.DataRow[5].ToString())
        //                            );
        //    hvs.Clear();
        //    hvs.Add(hv);
        //    qlhv.hvs = hvs;
        //    qlhv.hvs.Contains(hv);
        //    Assert.IsNotNull(bool.Parse(qlhv.NhapThongTin()), "Nhap thanh cong");
        //}
        
    }
}
