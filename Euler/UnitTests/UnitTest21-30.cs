using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler;

namespace UnitTests
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestAmicableNumbers()
        {
            int upTo = 10000;
            var task = new Task21();
            Assert.AreEqual(31626, task.Run(upTo), $"micable numbers sum up to {upTo} is incorrect");
        }
    }
}
