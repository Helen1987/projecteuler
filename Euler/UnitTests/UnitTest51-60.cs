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
            var task = new Task52();
            Assert.AreEqual(142857, task.Run(), $"The smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits is incorrect");
        }

        [TestMethod]
        public void TestCombinatoricSelections()
        {
            int maxValue = 100;
            var task = new Task53();
            Assert.AreEqual(4075, task.Run(maxValue), $"Values of nCr, for 1 ≤ n ≤ 100, are greater than one-millio are incorrect");
        }

        [TestMethod]
        public void TestPokerHands()
        {
            var task = new Task54();
            Assert.AreEqual(376, task.Run(), $"How many hands does Player 1 win is incorrect");
        }

        [TestMethod]
        public void TestSquareRootConvergents()
        {
            var task = new Task57();
            int expansionNumber = 1000;
            Assert.AreEqual(153, task.Run(expansionNumber), $"In the first {expansionNumber} how many fractions contain a numerator with more digits than denominator is incorrect");
        }

        [TestMethod]
        public void TestPrimePairSets()
        {
            var task = new Task60();
            Assert.AreEqual(26033, task.Run(), $"The lowest sum for a set of five primes for which any two primes concatenate to produce another prime is incorrect");
        }

    }
}
