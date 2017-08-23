using System.Collections.Generic;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        // causes "tight" coupling to LinqValueCalculator... you want components in general 
        // to be loosely coupled to avoid have to replace one component everywhere it is used
        //private LinqValueCalculator calc;

        // tightly coupled
        //public ShoppingCart(LinqValueCalculator calcParam)
        //{
        //    calc = calcParam;
        //}


        private IValueCalculator calc; 

        // loosely coupled
        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }


        public IEnumerable<Products> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}