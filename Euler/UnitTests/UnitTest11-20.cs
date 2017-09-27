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
    }
}
