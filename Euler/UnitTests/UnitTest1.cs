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
    }
}
