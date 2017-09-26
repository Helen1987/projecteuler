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
    }
}
