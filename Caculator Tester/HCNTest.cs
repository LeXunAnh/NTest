using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator2;
namespace Caculator_Tester
{
    [TestClass]
    public class HCNTest
    { 
        HinhChuNhat hcn = new HinhChuNhat(new Diem(1, 2), new Diem(2, 3));
        [TestMethod]
        public void TestDienTich()
        {
            Assert.AreEqual(4, hcn.DienTich());
        }
        [TestMethod]
        public void TestGiaoNhauTrue()
        {
            Assert.AreEqual(true, hcn.GiaoNhau(hcn));
        }
        [TestMethod]
        public void TestGiaoNhauFalse()
        {
            Assert.AreEqual(false, hcn.GiaoNhau(hcn));
        }
    }
}
