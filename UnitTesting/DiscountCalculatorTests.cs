using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidPrinciples.OCP;

namespace UnitTesting
{
    [TestClass]
    public class DiscountCalculatorTests
    {
        private DiscountCalculator _discountCalculator;

        [TestInitialize]
        public void TestSetup()
        {
            _discountCalculator = new DiscountCalculator();
        }

        [TestMethod]
        public void FifteenPercentForSummer()
        {
            var result = _discountCalculator.CalculateDiscount(100, "summer");
            Assert.AreEqual(15.0, result);
        }

        [TestMethod]
        public void TenPercentForWinter()
        {
            var result = _discountCalculator.CalculateDiscount(100, "winter");
            Assert.AreEqual(10.1, result);
        }
       
        
    }
}
