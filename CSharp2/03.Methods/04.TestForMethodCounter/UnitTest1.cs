using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.TestForMethodCounter
{
    [TestClass]                              //right Click on TestClass -> Run Tests
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 1, 2, 3, 4, 4, 5, 6, 7 };
            int res = NumberAppearingInArray.Counter(array, 4);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] array = { 1, 2, 3, 4, 4, 5, 6, 7 };
            int res = NumberAppearingInArray.Counter(array, 5);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] array = { 1000, 2, 3, 4, 4, 1000, 5, 6, 7, 1000 };
            int res = NumberAppearingInArray.Counter(array, 1000);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] array = { 0,0,0,0000,00 };
            int res = NumberAppearingInArray.Counter(array, 0);
            Assert.AreEqual(5, res);
        }
    }
}
 