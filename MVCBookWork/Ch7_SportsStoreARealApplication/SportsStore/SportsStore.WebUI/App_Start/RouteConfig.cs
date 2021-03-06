﻿using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // cleans up URL
            // important to put this one before default, the routing system processes routes 
            // in the order that they are listed
            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new { Controller = "Product", action = "List" }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Product", action = "List", id = UrlParameter.Optional }
                // routing features described in detail in chapters 15 and 16
                // used Product instead of ProductController because 
                // despite the naming scheme stating that controller 
                // classes always end in Controller,
                // you can omit this part of the name when referring
                // to the class
            );
        }
    }
}
