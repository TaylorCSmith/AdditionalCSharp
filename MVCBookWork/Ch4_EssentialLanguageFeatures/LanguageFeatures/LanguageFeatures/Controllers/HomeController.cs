using LanguageFeatures.Models;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        public ViewResult AutoProperty()
        {
            //// creates a new product object
            //Product myProduct = new Product();

            //// set the property value
            //myProduct.Name = "Kayak";

            //// get the property
            //string productName = myProduct.Name;

            //// generates the view
            //return View("Result", (object)String.Format("Product name: {0}", productName));


            // creating a new product using an object initializer
            Product myProduct = new Product
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 275M,
                Category = "Watersports"
            };

            return View("Result", (object)String.Format("Category: {0}", myProduct.Category));
        }

        public ViewResult CreateCollection()
        {
            string[] stringArray = { "apple", "orange", "plum" };

            List<int> intList = new List<int> { 10, 20, 30, 40 };

            Dictionary<string, int> myDict = new Dictionary<string, int> { { "apple", 10 }, { "orange", 20 }, { "plum", 30 } };

            return View("Result", (object)stringArray[1]);
        }


        public ViewResult UseExtensionEnumerable()
        {
            IEnumerable<Product> products = new ShoppingCart
            {
                Products = new List<Product>
                {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
                }
            };

            // create and populate an array of Product objects
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            // get the total value of the products in the cart
            decimal cartTotal = products.TotalPrices();
            decimal arrayTotal = products.TotalPrices();

            return View("Result", (object)String.Format("Cart Total: {0}, Array Total: {1}", cartTotal, arrayTotal));
        }

        public ViewResult UseFilterExtensionMethod()
        {
            IEnumerable<Product> products = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
                    new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                    new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                    new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
                }
            };

            // lambda function can replace the delegate and make the function concise 
            //Func<Product, bool> categoryFilter = delegate (Product prod)
            //{
            //    return prod.Category == "Soccer";
            //};

            Func<Product, bool> categoryFilter = prod => prod.Category == "Soccer";

            decimal total = 0;

            foreach (Product prod in products.Filter(prod => prod.Category == "Soccer" || prod.Price > 20))
            {
                total += prod.Price;
            }

            return View("Result", (object)String.Format("Total: {0}", total));
        }

        #region Additional Notes on Lambda Expressions

        /* Other forms of lambda expressions..
         * 
         *  You do not need to express the logic of a delegate in the lambda express... 
         *  it can also be used to call a method...
         *  
         *  prod => EvaluateProduct(prod)
         * 
         * 
         *  parameters must be wrapped in parentheses if the lambda expression for a delegate
         *  has multiple parameters
         *  
         *  (prod, count) => prod.Price > 20 && count > 0
         *  
         *  
         *  if a lambda expression requires more than one statements... ned to use braces
         *  and finish with a return statement
         *  
         * (prod, count) => {
         *      // ... multiple code statements
         *      return result;
         * }
         * 
         */

        #endregion

        public ViewResult CreateAnonArray()
        {
            var oddsAndEnds = new[]
            {
                new {Name = "MVC", Category = "Pattern" },
                new {Name = "Hat", Category = "Clothing" },
                new {Name = "Apple", Category = "Fruit" }
            };

            StringBuilder result = new StringBuilder();
            foreach (var item in oddsAndEnds)
            {
                result.Append(item.Name + " ");
            }

            return View("Result", (object)result.ToString());
        }

        public ViewResult FindProducts()
        {
            Product[] products =
            {
                new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
                new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
            };

            // query syntax for LINQ
            var foundProducts = from match in products
                                orderby match.Price descending
                                select new { match.Name, match.Price };

            // dot-notation syntax or dot notation
            var foundProductsTwo = products.OrderByDescending(e => e.Price)
                                            .Take(3)
                                            .Select(e => new { e.Name, e.Price });

            #region Additional Notes on LINQ

            /* All of the LINQ extension methods are in the System.Linq namespace
             *
             * Each of the LINQ extension methods in the listening is applied to an IEnumerable<T> 
             * it also returns an IEnumerable<T> which allows you to chain methods together to 
             * form complex queries
             * 
             * Queries are evaluated from scratch every time the results are enumerated.
             * 
             * a query that contains only deferred methods is not executed until the items in 
             * the result are enumerated (i.e. doesn't happen immediately) ... the method 
             * isn't evaluated until the results are used... while non-deferred are evaluated
             * once the method is called
             * 
             */

            #endregion

            int count = 0;
            StringBuilder result = new StringBuilder();
            foreach(var p in foundProducts)
            {
                result.AppendFormat("Price: {0} ", p.Price);
                if (++count == 3)
                {
                    break;
                }
            }

            return View("Result", (object)result.ToString());
        }

    }
}