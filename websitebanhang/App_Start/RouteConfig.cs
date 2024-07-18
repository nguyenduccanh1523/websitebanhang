using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace websitebanhang
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Contact",
                url: "lienahe",
                defaults: new { controller = "Contact", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
       name: "vnpay_return",
       url: "vnpay_return",
       defaults: new { controller = "ShoppingCart", action = "VnpayReturn", alias = UrlParameter.Optional },
       namespaces: new[] { "webbanhangonline.Controllers" }
   );

            routes.MapRoute(
                name: "CheckOut",
                url: "thanh-toan",
                defaults: new { controller = "ShoppingCart", action = "CheckOut", alias = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
                name: "ShoppingCart",
                url: "gio-hang",
                defaults: new { controller = "ShoppingCart", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
                name: "CategoryProduct",
                url: "danhamucasanapham/{alias}-{id}",
                defaults: new { controller = "Products", action = "ProductCategory", id = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
                name: "BaiViet",
                url: "post/{alias}",
                defaults: new { controller = "Article", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
                name: "detailProducts",
                url: "chi-tiet/{alias}-p{id}",
                defaults: new { controller = "Products", action = "Detail", alias = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
                name: "Products",
                url: "sanapham",
                defaults: new { controller = "Products", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
                name: "DetailNews",
                url: "{alias}-n{id}",
                defaults: new { controller = "News", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
                name: "DetailPost",
                url: "{alias}-p{id}",
                defaults: new { controller = "Posts", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
                name: "News",
                url: "tinatuc",
                defaults: new { controller = "News", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
                name: "Post",
                url: "baiaviet",
                defaults: new { controller = "Posts", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "websitebanhang.Controllers" }
            );
        }
    }
}
