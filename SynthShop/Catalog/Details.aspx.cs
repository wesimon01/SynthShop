using log4net;
using SynthShop.Services;
using SynthShop.ViewModel;
using SynthShopData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SynthShop.Catalog
{
    public partial class Details : System.Web.UI.Page
    {
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public ICatalogService CatalogService { get; set; }
        protected CatalogItem product { get; set; }
        protected CatalogItemSpecs itemSpecs { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var productId = Convert.ToInt32(Page.RouteData.Values["id"]);
            _log.Info($"Now loading... /Catalog/Details.aspx?id={productId}");
            product = CatalogService.FindCatalogItem(productId);
            itemSpecs = CatalogService.GetCatalogItemSpecs(product.Id);

            this.DataBind();
        }
    }
}