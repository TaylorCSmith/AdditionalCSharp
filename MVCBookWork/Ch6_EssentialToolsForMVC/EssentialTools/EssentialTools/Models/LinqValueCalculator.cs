using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discounter;
        private static int counter = 0;

        // dependency is diclared in the constructor
        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            discounter = discountParam;
            System.Diagnostics.Debug.WriteLine(string.Format("instance {0} created", ++counter));
        }

        public decimal ValueProducts(IEnumerable<Products> products )
        {
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}