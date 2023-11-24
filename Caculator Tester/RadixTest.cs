using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator2;

namespace Caculator_Tester
{
    [TestClass]
    public class RadixTest
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod1()
        {
            int num = -1;
            Radix r = new Radix(num);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            Radix r = new Radix(2);
            int radix = 1;
            r.ConvertDecimalToAnother(radix);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @"X:\KTPM.FILE\NTest\Caculator Tester\Data\TestData3.csv", "TestData3#csv",
        DataAccessMethod.Sequential)]
        public void TestMethod3()
        {
            int num = int.Parse(TestContext.DataRow[0].ToString());
            int radix = int.Parse(TestContext.DataRow[1].ToString());
            string exp =TestContext.DataRow[2].ToString();
        }
    }
}
