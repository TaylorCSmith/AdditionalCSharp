using SportsStore.Domain.Abstract;
using SportsStore.WebUI.Models;
using System.Linq;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        public int PageSize = 4;

        // declares dependency on the IProductRepository
        public ProductController(IProductsRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ViewResult List(string category, int page = 1)
        {
            #region Prior to ProductsListViewModel
            //return View(repository.Products
            //    .OrderBy(p=> p.ProductID)
            //    .Skip((page-1) * PageSize)  // page size specifies that it should be 4 items for page
            //    .Take(PageSize));           // inclusion of this known as "Pagination" 
            #endregion

            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => category == null || p.Category == category) // causes LINQ to only select all the items (if category is null) or the items matching the category
                .OrderBy(p => p.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    // TotalItems = repository.Products.Count() BEFORE INTRODUCTION OF CATEGORIES

                    TotalItems = category == null ? repository.Products.Count() : repository.Products.Where(e => e.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }

    }
}