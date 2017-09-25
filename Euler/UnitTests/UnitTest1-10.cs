﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMultiples()
        {
            var task = new Task1();
            int max = 1000;
            Console.WriteLine();
            Assert.AreEqual(233168, task.Run(max), $"Multiples of 3 and 5 below {max} are incorrect");
        }

        [TestMethod]
        public void TestFibbonacci()
        {
            var task = new Task2();
            int max = 4000000;
            Assert.AreEqual(4613732, task.Run(max), $"Sum of Even Fibonacci numbers below {max} is incorrect");
        }

        [TestMethod]
        public void TestLargestPrimFactor()
        {
            var task = new Task3();
            long number = 600851475143;
            Assert.AreEqual(6857, task.Run(number), $"Largest prime factor of {number} is incorrect");
        }

        [TestMethod]
        public void TestLargestPalindromeProduct2Digits()
        {
            var task = new Task4();
            int digitsCount = 2;
            Assert.AreEqual(9009, task.Run(digitsCount), $"Largest palindrome product of {digitsCount} is incorrect");
        }

        [TestMethod]
        public void TestLargestPalindromeProduct3Digit()
        {
            var task = new Task4();
            int digitsCount = 3;
            Assert.AreEqual(906609, task.Run(digitsCount), $"Largest palindrome product of {digitsCount} is incorrect");
        }

        [TestMethod]
        public void TestSmallestMultipleUpTo10()
        {
            var task = new Task5();
            int upToNumber = 10;
            Assert.AreEqual(2520, task.Run(upToNumber), $"The smallest positive number that is evenly divisible by all of the numbers from 1" +
                $" to {upToNumber} digits is incorrect");
        }

        [TestMethod]
        public void TestSmallestMultipleUpTo20()
        {
            var task = new Task5();
            int upToNumber = 20;
            Assert.AreEqual(232792560, task.Run(upToNumber), $"The smallest positive number that is evenly divisible by all of the numbers from 1" +
                $" to {upToNumber} digits is incorrect");
        }
    }
}
