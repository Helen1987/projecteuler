using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler;

namespace UnitTests
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestIntegerRightTriangles()
        {
            var task = new Task41();
            Assert.AreEqual(7652413, task.Run(), $"The largest n-digit pandigital prime is incorrect");
        }

        [TestMethod]
        public void TestCodedTriangleNumbers()
        {
            var task = new Task42();
            Assert.AreEqual(162, task.Run(), $"How many are triangle words is incorrect");
        }

        [TestMethod]
        public void TestSubStringDivisibility()
        {
            var task = new Task43();
            Assert.AreEqual(16695334890, task.Run(), $"The sum of all 0 to 9 pandigital numbers with this property");
        }

        [TestMethod]
        public void TestPentagonNumbers()
        {
            var task = new Task44();
            Assert.AreEqual(5482660, task.Run(), $"Their sum and difference are pentagonal and D = | Pk − Pj| is minimised is incorrect");
        }

        [TestMethod]
        public void TestTriangularPentagonalHexagonal()
        {
            var task = new Task45();
            Assert.AreEqual(1533776805, task.Run(), $"The next triangle number that is also pentagonal and hexagonal is incorrect");
        }
    }
}
