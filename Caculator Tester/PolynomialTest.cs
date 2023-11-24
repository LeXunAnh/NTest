using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator2;
using System.Collections.Generic;

namespace Caculator_Tester
{
    [TestClass]
    public class PolynomialTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod1()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2 };
            Polynomial p = new Polynomial(n, a);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2, 3, 4 };
            Polynomial p = new Polynomial(n, a);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int n = 2;
            List<int> a = new List<int> { 1, 2, 3 };
            double x = 1;
            Polynomial p = new Polynomial(n, a);
            Assert.AreEqual(6, p.Cal(x));
        }
    }
}
