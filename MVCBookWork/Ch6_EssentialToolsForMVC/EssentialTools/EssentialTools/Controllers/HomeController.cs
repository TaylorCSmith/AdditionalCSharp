using EssentialTools.Models;
using System.Web.Mvc;

// no longer necessary
// using Ninject;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;
        private Products[] products =
        {
            new Products {Name = "Kayak", Category = "Watersports", Price = 275M },
            new Products {Name = "Lifejacket", Category = "Watersports", Price = 48.95M },
            new Products {Name = "Soccer ball", Category = "Soccer", Price = 19.50M },
            new Products {Name = "Corner flag", Category = "Soccer", Price = 34.95M },
        };

        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public ActionResult Index()
        {

            #region Prior to including DI (tightly coupled)

            /*
            tightly coupled and hard to replace as you need to find every instance of it... 
            LinqValueCalculator calc = new LinqValueCalculator();
            */

            /*
            loosely coupled
            IValueCalculator calc = new LinqValueCalculator(); 
            */

#endregion 

            // since a dependency resolver has been created... any mention of Ninject or LinqValueCalculator
            // can be removed from the HomeController
            #region Prior to creating the dependency resolver

            // first stage of using Ninject (preparing Ninject)
            // No longer in controller due to dependency resolver
            // IKernel ninjectKernel = new StandardKernel();

            // Second stage... configuring Ninject to understand which implementation objects 
            // you want to use for each interface being used... 
            // the way ninject is worded seems pretty intuitive... Bind... To... 
            // No longer in controller due to dependency resolver
            // ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();

            // third stage... use Ninject to create an object using the kernel Get method
            // No longer in controller due to dependency resolver
            // IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();

            #endregion

            ShoppingCart cart = new ShoppingCart(calc) { Products = products };

            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }
    }
}