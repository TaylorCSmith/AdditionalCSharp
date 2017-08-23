using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Products> products )
        {
            return products.Sum(p => p.Price);
        }
    }
}