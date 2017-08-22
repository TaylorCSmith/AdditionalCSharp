using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        // using Auto Properties

        private string name;
        public int ProductID { get; set; }

        // must implement both getter and setter as regular properties
        // C# does not support mixing automatic and regular style getters in a single property
        public string Name {
            get { return ProductID + name; }
            set { name = value; }
        }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}