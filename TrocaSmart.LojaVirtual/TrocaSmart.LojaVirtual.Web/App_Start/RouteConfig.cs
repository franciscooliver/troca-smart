using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TrocaSmart.LojaVirtual.Web
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

            //Rota responsavel por chamar a view ListaProduto(Para ver essa View Digite depois da porta /Home/ListaProduto
            routes.MapRoute(
                   name: "Produto",
                   url: "{controller}/{action}/{id}",
                  defaults: new { controller = "Home", action = "ListaProduto", id = UrlParameter.Optional }
              );

        }
    }
}
