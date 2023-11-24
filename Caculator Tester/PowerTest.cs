using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator2;

namespace Caculator_Tester
{
    [TestClass]
    public class PowerTest
    {
        [TestMethod]
        public void Testcase1()
        {
            double x = 2;
            int n = 0;
            double exp = 1;
            Assert.AreEqual(exp, Power.Power1(x, n));
        }
        [TestMethod]
        public void Testcase2()
        {
            double x = 3;
            int n = 2;
            double exp = 9;
            Assert.AreEqual(exp, Power.Power1(x, n));
        }

        [TestMethod]
        public void Testcase3()
        {
            double x = 2;
            int n = -1;
            double exp = 0.5;
            Assert.AreEqual(exp, Power.Power1(x, n));
        }

    }
}
