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

        [TestMethod]
        public void TestGoldbachsOtherConjecture()
        {
            var task = new Task46();
            Assert.AreEqual(5777, task.Run(), $"The smallest odd composite that cannot be written as the sum of a prime and twice a square is incorrect");
        }

        [TestMethod]
        public void TestDistinctPrimesFactors()
        {
            var task = new Task47();
            Assert.AreEqual(134043, task.Run(), $"The first of the first four consecutive integers to have four distinct prime factors each is incorrect");
        }

        [TestMethod]
        public void TestSelfPowers()
        {
            int maxNumber = 1000;
            var task = new Task48();
            Assert.AreEqual(9110846700, task.Run(maxNumber), $"The last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000 is incorrect");
        }

        [TestMethod]
        public void TestPrimePermutations()
        {
            var task = new Task49();
            Assert.AreEqual("296962999629", task.Run(), $"12-digit number formed by concatenating the three terms in this sequence is incorrect");
        }

        [TestMethod]
        public void TestConsecutivePrimeSum()
        {
            int maxNumber = 1000000;
            var task = new Task50();
            Assert.AreEqual(997651, task.Run(maxNumber), $"Prime, below {maxNumber}, can be written as the sum of the most consecutive primes is incorrect");
        }
    }
}
