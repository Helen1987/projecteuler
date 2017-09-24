using System;
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
            Console.WriteLine(4613732, task.Run(max), $"Sum of Even Fibonacci numbers below {max} is incorrect");
        }

        public void TestLargestPrimFactor()
        {
            var task = new Task3();
            long number = 600851475143;
            Console.WriteLine(6857, task.Run(number), $"Largest prime factor of {number} is incorrect");
        }
    }
}
