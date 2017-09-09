using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;
using System.Linq;
using Moq;

namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest2
    {
        private Products[] products =
        {
            new Products {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Products {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Products {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Products {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };

        [TestMethod]
        public void Sum_Products_Correctly()
        {
            // arrange
            // makes a new strongly typed Mock<IDiscountHelper> object
            Mock<IDiscountHelper> mock = new Mock<IDiscountHelper>();

            // specifying behavior of object
            mock.Setup(m => m.ApplyDiscount(It.IsAny<decimal>())) // tells Moq to apply the behavior being defined whenever it encounters a decimal
                .Returns<decimal>(total => total); // returns defines the results

            var target = new LinqValueCalculator(mock.Object); // reads the value of the Object property of the Mock<IDiscountHelper> object
            #region Without using Moq
            /* Without Using Moq
            var discounter = new MinimumDiscountHelper();
            var target = new LinqValueCalculator(discounter);
            var goalTotal = products.Sum(e => e.Price);
            */
            #endregion

            // act
            var result = target.ValueProducts(products);

            // assert
            Assert.AreEqual(products.Sum(e => e.Price), result);
            #region Without using Moq
            // Assert.AreEqual(goalTotal, result);
            #endregion

            // benefit of this Moqis that the unit test only checks the behavior of the LinqValueCalculator object and does not depend on any of the real 
            // implementations of the IDiscountHelper interface in the Models folder... 
            // this  makes it easier to tell where a problem is occuring if a test fails 
        }

        private Products[] createProduct(decimal value)
        {
            return new[] { new Products { Price = value } };
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Pass_Through_Variable_Discounts()
        {
            // arrange
            Mock<IDiscountHelper> mock = new Mock<IDiscountHelper>();

            mock.Setup(m => m.ApplyDiscount(It.IsAny<decimal>()))
                .Returns<decimal>(total => total);
            mock.Setup(m => m.ApplyDiscount(It.Is<decimal>(v => v == 0)))
                .Throws<System.ArgumentOutOfRangeException>();
            mock.Setup(m => m.ApplyDiscount(It.Is<decimal>(v => v > 100)))
                .Returns<decimal>(total => (total * 0.9M));
            mock.Setup(m => m.ApplyDiscount(It.IsInRange<decimal>(10, 100,
                Range.Inclusive))).Returns<decimal>(total => total - 5);

            var target = new LinqValueCalculator(mock.Object);

            // act            
            decimal FiveDollarDiscount = target.ValueProducts(createProduct(5));
            decimal TenDollarDiscount = target.ValueProducts(createProduct(10));
            decimal FiftyDollarDiscount = target.ValueProducts(createProduct(50));
            decimal HundredDollarDiscount = target.ValueProducts(createProduct(100));
            decimal FiveHundredDollarDiscount = target.ValueProducts(createProduct(500));

            // assert            
            Assert.AreEqual(5, FiveDollarDiscount, "$5 Fail");
            Assert.AreEqual(5, TenDollarDiscount, "$10 Fail");
            Assert.AreEqual(45, FiftyDollarDiscount, "$50 Fail");
            Assert.AreEqual(95, HundredDollarDiscount, "$100 Fail");
            Assert.AreEqual(450, FiveHundredDollarDiscount, "$500 Fail");
            target.ValueProducts(createProduct(0));
        }
    }
}
