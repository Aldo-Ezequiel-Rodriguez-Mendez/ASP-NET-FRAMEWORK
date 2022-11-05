using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proyecto_ASP_NET
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //FORMA MEJORADA
            routes.MapMvcAttributeRoutes();

            //FORMA PRIMITIVA DE AGREGAR RUTAS
            /*routes.MapRoute("PeliculasPorFechaLanzamiento",
                "peliculas/lanzamiento/{year}/{month}",
                new { controller = "Peliculas", action = "PorLanzamiento"},
                new { year = @"\d{4}", month = @"\d{2}"});*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
