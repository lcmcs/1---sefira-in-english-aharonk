using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, 6.IsEven());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true,
                CoolExtensionMethods.IsEven(6));
        }

        [TestMethod]
        public void LangTest()
        {// 10100 => 01010
            Assert.AreEqual(5, 20 >> 2);
        }

        [TestMethod]
        public void LangTest2()
        {
            Assert.AreEqual(Math.Pow(2,31), (UInt32)(Int32.MaxValue) + 1);
        }
        [TestMethod]
        public void LangTest3()
        {
            decimal d = 1.23m; // float/double approximately..use decimal for $
            Assert.AreNotEqual(1.23f, d);
        }
    }
}