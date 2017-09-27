using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler;

namespace UnitTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestLargestProductInAGrid()
        {
            int productLength = 4;
            var task = new Task11(productLength);
            Assert.AreEqual(70600674, task.Run(), $"Largest product of length {productLength} in a grid is incorrect");
        }

        [TestMethod]
        public void TestHighlyDivisibleTriangularNumber()
        {
            var task = new Task12();
            int numberOfDivisors = 500;
            Assert.AreEqual(76576500, task.Run(numberOfDivisors), $"The value of the first triangle number to have over {numberOfDivisors} divisors is incorrect");
        }

        [TestMethod]
        public void TestLargeSum()
        {
            int numbersCount = 10;
            var task = new Task13();
            Assert.AreEqual("5537376230", task.Run(numbersCount), $"First {numbersCount} digits of large sum are incorrect");
        }


        [TestMethod]
        public void TestLongestCollatzSequence()
        {
            var task = new Task14();
            int limit = 1000000;
            Assert.AreEqual(837799, task.Run(limit), $"Starting number under {limit} which produces the longest chain divisors is incorrect");
        }

        [TestMethod]
        public void TestLatticePaths2x2()
        {
            int columns = 2, rows = 2;
            var task = new Task15(rows, columns);
            Assert.AreEqual(6, task.Run(), $"Routes count in {rows}x{columns} grid is incorrect");
        }

        [TestMethod]
        public void TestLatticePaths20x20()
        {
            int columns = 20, rows = 20;
            var task = new Task15(rows, columns);
            Assert.AreEqual(137846528820, task.Run(), $"Routes count in {rows}x{columns} grid is incorrect");
        }

        [TestMethod]
        public void TestPower15DigitSum()
        {
            int power = 15;
            var task = new Task16();
            Assert.AreEqual(26, task.Run(power), $"The sum of the digits of the number 2^{power} is incorrect");
        }

        [TestMethod]
        public void TestPower1000DigitSum()
        {
            int power = 1000;
            var task = new Task16();
            Assert.AreEqual(1366, task.Run(power), $"The sum of the digits of the number 2^{power} is incorrect");
        }
    }
}
