using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator2;
namespace Caculator_Tester
{
    [TestClass]
    public class UnitTest2
    {
        private SimpleEquation s;

        [TestMethod]
        public void TestVoNghiem()
        {
            s = new SimpleEquation(0,1);
            Assert.AreEqual("VN", s.SingleEquation());
        }
        [TestMethod]
        public void TestCoNghiem()
        {
            s = new SimpleEquation(2, 1);
            Assert.AreEqual("-0.5", s.SingleEquation());
        }
        [TestMethod]
        public void TestVoSoNghiem()
        {
            s = new SimpleEquation(0, 0);
            Assert.AreEqual("VSN", s.SingleEquation());
        }
    }
}
