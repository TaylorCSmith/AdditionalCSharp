using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AceOfSpadesPizza.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult PlaceOrder()
        {
            return View();
        }

        public ActionResult ViewOrders()
        {
            return View();
        }
    }
}