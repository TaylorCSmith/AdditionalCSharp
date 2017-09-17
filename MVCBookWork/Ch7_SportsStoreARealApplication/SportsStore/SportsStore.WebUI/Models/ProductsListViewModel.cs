/*
 * This file is made so that everything being sent from the controller to the view is 
 * in a single view model class 
 */

using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}