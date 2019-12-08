using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventCalendar2019.Solutions.Day1;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalendar2019.Solutions.Day1.Tests
{
    [TestClass()]
    public class FuelCalculatorTests
    {

        FuelCalculator _fc = new FuelCalculator();

        [TestMethod()]
        [DataRow(12, 2)]
        [DataRow(14, 2)]
        [DataRow(1969, 966)]
        [DataRow(100756, 50346)]
        [DataTestMethod]
        public void Test_CalculateWithSingleInput(int mass, int expectedFuelRequirement)
        {
            double actual = _fc.Calculate(mass);
            Assert.AreEqual(expectedFuelRequirement, actual);
        }

        [TestMethod()]
        [DataRow(new double[]{ 12.0, 14.0, 1969.0, 100756.0 }, 51316)]
        [DataTestMethod]
        public void Test_CalculateWithList(double[] massList, int expectedCombinedRequirement)
        {
            double actual = _fc.Calculate(massList);
            Assert.AreEqual(expectedCombinedRequirement, actual);
        }
    }
}