﻿using System;
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
            var task = new Task52();
            Assert.AreEqual(142857, task.Run(), $"The smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits is incorrect");
        }
    }
}