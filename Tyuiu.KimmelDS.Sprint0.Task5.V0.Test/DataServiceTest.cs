﻿using Tyuiu.KimmelDS.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KimmelDS.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid() => Assert.AreEqual(10, DataService.Addition(2, 8));
        [TestMethod]
        public void CheckedSubtractionValid() => Assert.AreEqual(0, DataService.Subtraction(5, 5));
        [TestMethod]
        public void CheckedMultiplicationValid() => Assert.AreEqual(25, DataService.Multiplication(5, 5));
        [TestMethod]
        public void CheckedDivisionValid() => Assert.AreEqual(1, DataService.Division(5, 5));

    }
}