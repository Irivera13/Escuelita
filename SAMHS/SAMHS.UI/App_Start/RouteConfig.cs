using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SAMHS.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Citas",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Citas", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "Calendario",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Calendario", action = "Index", id = UrlParameter.Optional }
          );
        }
    }
}
