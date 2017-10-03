using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler;

namespace UnitTests
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestCoinSums()
        {
            int sum = 200;
            var task = new Task31();
            Assert.AreEqual(73682, task.Run(sum), $"£2 can be made using any number of coins in different ways");
        }

        [TestMethod]
        public void TestPandigitalProducts()
        {
            var task = new Task32();
            Assert.AreEqual(45228, task.Run(), $"Pandigital products sum is incorrect");
        }
    }
}
