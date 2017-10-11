﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FastTickets
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Evento",
               url: "Evento/{action}/{id}",
               defaults: new { controller = "Evento", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Local",
               url: "Local/{action}/{id}",
               defaults: new { controller = "LocalEvento", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}