using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator2;

namespace Caculator_Tester
{
    [TestClass] //dinh nghia 1 class de test case
    public class UnitTest1
    {
        private Caculation c;

        [TestInitialize]// tao du lieu dung hung
        public void SetUp()
        {
            c = new Caculation(10, 5);
        }
        [TestMethod] //tao phuong thuc test case tuong ung
        public void TestAddOperator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10,5);
            expected = 15;
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10, 5);
            expected = 5;
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10, 5);
            expected = 50;
            actual = c.Exectute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            int expected, actual;
            //Caculation c = new Caculation(10, 5);
            expected = 2;
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            c = new Caculation(10, 0);
            c.Exectute("/");
        }
    }
}
