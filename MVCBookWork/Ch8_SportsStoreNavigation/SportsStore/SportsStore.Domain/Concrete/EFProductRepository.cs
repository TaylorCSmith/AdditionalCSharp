﻿using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Collections.Generic;


namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductsRepository
    {
        private EFDBContext context = new EFDBContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
