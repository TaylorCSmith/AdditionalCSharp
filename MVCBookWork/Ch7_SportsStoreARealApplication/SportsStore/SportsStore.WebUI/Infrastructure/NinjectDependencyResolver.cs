using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Moq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            // Same Moq techniques introduced in Chapter 6 (page 145)
            // want to make sure that Ninject returns the same mock object whenever 
            // it gets a request for an implementation of the IProductRepository interface
            /*
            Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product { Name = "Football", Price = 25 },
                new Product { Name = "Surf Board", Price = 179 },
                new Product { Name = "Running Shoes", Price = 95 }
            });
            */

            // .ToConstant added to the scope to ensure what was mentioned above, that
            // instead of creating a new instance of the implementation object each time, 
            // Ninject will always satisfy requests for the IProductReposity interface
            // with the same mock objects
            // kernel.Bind<IProductsRepository>().ToConstant(mock.Object);

            kernel.Bind<IProductsRepository>().To<EFProductRepository>();
        }
    }
}