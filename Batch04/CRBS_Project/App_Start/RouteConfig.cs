using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CRBS_Project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute("Cuisine",
            //    "cuisine/{name}",
            //    new { controller = "cuisine", action = "search", name = UrlParameter.Optional });
            //routes.MapRoute("Cuisine",
            //    "cuisine/{name}",
            //    new { controller = "cuisine", action = "search", name = "" });
            //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
