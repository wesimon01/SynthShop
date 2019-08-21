using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace SynthShop
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //var settings = new FriendlyUrlSettings();
            //settings.AutoRedirectMode = RedirectMode.Permanent;
            //routes.EnableFriendlyUrls(settings);

            routes.MapPageRoute(
                "",
                "Default",
                "~/Default.aspx" 
                );
             routes.MapPageRoute(
                "ProductsByPageRoute",
                "Default/index/{index}/size/{size}",
                "~/Default.aspx" 
                );
             routes.MapPageRoute(
                "CreateProductRoute",
                "Catalog/Create",
                "~/Catalog/Create.aspx" 
                );
             routes.MapPageRoute(
                "EditProductRoute",
                "Catalog/Edit/{id}",
                "~/Catalog/Edit.aspx" 
                );
             routes.MapPageRoute(
                "ProductDetailsRoute",
                "Catalog/Details/{id}",
                "~/Catalog/Details.aspx" 
                );
             routes.MapPageRoute(
                "DeleteProductRoute",
                "Catalog/Delete/{id}",
                "~/Catalog/Delete.aspx" 
                );

        }
    }
}
