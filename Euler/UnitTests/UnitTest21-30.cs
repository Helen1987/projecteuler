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
            Assert.AreEqual(31626, task.Run(upTo), $"Amicable numbers sum up to {upTo} is incorrect");
        }

        [TestMethod]
        public void TestNamesScores()
        {
            var task = new Task22();
            Assert.AreEqual(871198282, task.Run(), $"The total of all the name scores in the file is incorrect");
        }
    }
}
