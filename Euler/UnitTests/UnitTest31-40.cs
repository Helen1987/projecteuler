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

        [TestMethod]
        public void TestDigitCancellingFractions()
        {
            var task = new Task33();
            Assert.AreEqual(100, task.Run(), $"The product of these four fractions is given in its lowest common terms, find the value of the denominator is incorrect");
        }

        [TestMethod]
        public void TestDigitFactorials()
        {
            var task = new Task34();
            Assert.AreEqual(40730, task.Run(), $"The sum of all numbers which are equal to the sum of the factorial of their digits is incorrect");
        }

        [TestMethod]
        public void TestCircularPrimes()
        {
            int maxValue = 1000000;
            var task = new Task35(maxValue);
            Assert.AreEqual(55, task.Run(), $"Circular primes are there below {maxValue} is incorrect");
        }

        [TestMethod]
        public void TestDoubleBasePalindromes()
        {
            int maxValue = 1000000;
            var task = new Task36();
            Assert.AreEqual(872187, task.Run(maxValue), $"The sum of all numbers, less than {maxValue}, which are palindromic in base 10 and base 2 is incorrect");
        }

        [TestMethod]
        public void TestTruncatablePrimes()
        {
            var task = new Task37();
            Assert.AreEqual(748317, task.Run(), $"The sum of the only eleven primes that are both truncatable from left to right and right to left is incorrect");
        }
    }
}
