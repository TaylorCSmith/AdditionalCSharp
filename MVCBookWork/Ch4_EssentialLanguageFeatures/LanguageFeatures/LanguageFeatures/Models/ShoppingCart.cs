using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace LanguageFeatures.Models
{
    public class ShoppingCart : IEnumerable<Product>
    {
        public List<Product> Products { get; set; }

        // implementation of IEnumerable allows the extension method to be called on by all classes that implement the interface
        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }
    }
}