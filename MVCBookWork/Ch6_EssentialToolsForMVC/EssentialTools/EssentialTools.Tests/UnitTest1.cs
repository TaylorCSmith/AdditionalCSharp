using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models; 

namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // creates an instance of the object being tested
        // is not decorated with the [TestMethod] attribute so it is not treated like a unit test method
        private IDiscountHelper getTestObject()
        {
            return new MinimumDiscountHelper();
        }

        [TestMethod]
        public void Discount_Above_100()
        {
            // arrange - instance of the object being tested is created
            IDiscountHelper target = getTestObject();
            decimal total = 200;

            // act
            var discountedTotal = target.ApplyDiscount(total);

            // assert - throws an exception if the check fails; all assertions have to succeed for the unit test to pass
            Assert.AreEqual(total * 0.9M, discountedTotal);
        }

        [TestMethod]
        public void Discount_Between_10_and_100()
        {
            // arrange
            IDiscountHelper target = getTestObject();

            // act
            decimal TenDollarDiscount = target.ApplyDiscount(10);
            decimal HundredDollarDiscount = target.ApplyDiscount(100);
            decimal FiftyDollarDiscount = target.ApplyDiscount(50);

            // assert
            Assert.AreEqual(5, TenDollarDiscount, "Ten dollar discount is wrong");
            Assert.AreEqual(95, HundredDollarDiscount, "Hundred dollar dicount is wrong");
            Assert.AreEqual(45, FiftyDollarDiscount, "Fifty dollar discount is wrong");
        }

        [TestMethod]
        public void Discount_Less_Than_10()
        {
            // arrange
            IDiscountHelper target = getTestObject();

            // act
            decimal discountFive = target.ApplyDiscount(5);
            decimal discountZero = target.ApplyDiscount(0);

            // assert
            Assert.AreEqual(5, discountFive);
            Assert.AreEqual(0, discountZero);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Discount_Negative_total()
        {
            // arrange
            IDiscountHelper target = getTestObject();

            // act
            target.ApplyDiscount(-1);
        }
    }
}
