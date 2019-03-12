using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exgths.tests.median.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Class1 c = new Class1();

            Assert.AreEqual(6.5, c.Median(new int[] { 6, 7, 8, 9, 1, 3 }));
        }

        [TestMethod]
        public void Test2()
        {
            Class1 c = new Class1();

            Assert.AreEqual(9, c.Median(new int[] { 1, 5, 2, 7, 9, 10, 25, 21, 52 }));
        }

        [TestMethod]
        public void Test_Throws_NullException()
        {
            Class1 c = new Class1();

            Assert.ThrowsException<ArgumentNullException>(() => c.Median(null));
        }

        [TestMethod]
        public void Test_Throws_ArgumentException()
        {
            Class1 c1 = new Class1();

            Assert.ThrowsException<ArgumentException>(() => c1.Median(new int[] { }), "Array shouldn't be empty!");
        }
    }
}
