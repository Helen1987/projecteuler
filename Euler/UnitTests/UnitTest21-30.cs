﻿using System;
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

        [TestMethod]
        public void TestNonAbundantSums()
        {
            var task = new Task23();
            Assert.AreEqual(4179871, task.Run(), $"The sum of all the positive integers which cannot be written as the sum of two abundant numbers is incorrect");
        }

        [TestMethod]
        public void TestLexicographicPermutations()
        {
            int availableDigits = 10;
            int permutationNumber = 1000000;
            var task = new Task24(availableDigits);
            Assert.AreEqual(2783915460, task.Run(permutationNumber), $"The {permutationNumber} lexicographic permutation of the digits is is incorrect");
        }
    }
}
