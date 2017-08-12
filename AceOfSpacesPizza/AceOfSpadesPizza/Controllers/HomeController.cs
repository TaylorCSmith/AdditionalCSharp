using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AceOfSpadesPizza.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Objective()
        {
            ViewData["Message"] = "The Pizza Ordering Web App";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Feel free to contact me if you have any questions";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
