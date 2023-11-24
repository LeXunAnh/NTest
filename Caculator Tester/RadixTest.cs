using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator2;

namespace Caculator_Tester
{
    [TestClass]
    public class RadixTest
    {
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
            int radix = 2;

        }
    }
}
