using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator2;

namespace Caculator_Tester
{
    [TestClass]
    public class UnitTest3
    {
        private Caculation c;
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @"C:\Users\admin\Desktop\NTest\Caculator Tester\Data\TestData2.csv", "TestData2#csv",
        DataAccessMethod.Sequential)]
        public void TestWithDataSourse()
        {
            int a, b, expected, actual; string opera;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            opera = TestContext.DataRow[2].ToString();
            opera = opera.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            
            c = new Caculation(a, b);
            actual = c.Exectute(opera);
            Assert.AreEqual(expected, actual);
        }
    }
}
