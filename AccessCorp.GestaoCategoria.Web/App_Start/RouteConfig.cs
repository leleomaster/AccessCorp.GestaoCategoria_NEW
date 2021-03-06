﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AccessCorp.GestaoCategoria.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "AccessCorp.GestaoCategoria.Web.Controllers" }
            );

            routes.MapRoute(
              name: "Formulario",
              url: "Formulario/{categoria}/{id}",
              defaults: new { controller = "Formulario", action = "Index", id = UrlParameter.Optional }
            );            
        }
    }
}
