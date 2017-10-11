using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler;

namespace UnitTests
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestLychrelNumbers()
        {
            var task = new Task55();
            int maxNumber = 10000;
            Assert.AreEqual(249, task.Run(maxNumber), $"Count of Lychrel numbers below {maxNumber} is incorrect");
        }

        [TestMethod]
        public void TestPowerfulDigitSum()
        {
            var task = new Task56();
            int maxNumber = 100;
            Assert.AreEqual(972, task.Run(maxNumber), $"The maximum digital sum is incorrect");
        }
    }
}
