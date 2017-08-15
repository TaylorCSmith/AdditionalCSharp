using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    // the default controller is called HomeController
    public class HomeController : Controller
    {
        // each method within a controller is known as an "action method"

        // ViewResult instructes MVC to render a view, returning View() with no parameters 
        // tells MVC to render the default view for the action
        public ViewResult Index()
        {
            // Dynamic Output
            int hour = DateTime.Now.Hour;

            // ViewBag is one way to pass data from controller to view and in next request. 
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";


            return View();
        }

        // is the action method called from the HTML helper method
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                // todo: email response to the party organizer
                return View("Thanks", guestResponse);
            } else
            {
                // there is a validation error so the RsvpForm is re-rendered by calling view without any parameters.
                return View(); 
            }
        }
    }
}