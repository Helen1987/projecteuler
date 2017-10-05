﻿using System;
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
    }
}
