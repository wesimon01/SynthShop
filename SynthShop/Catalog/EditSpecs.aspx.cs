using log4net;
using SynthShop.Services;
using SynthShopData.Models;
using System;
using System.Web.UI;

namespace SynthShop.Catalog
{
    public partial class EditSpecs : System.Web.UI.Page
    {
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected CatalogItemSpecs itemSpecs;
        protected CatalogItem product;
        public ICatalogService CatalogService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var productId = Convert.ToInt32(Page.RouteData.Values["id"]);
                _log.Info($"Now loading... /Catalog/EditSpecs.aspx?id={productId}");
                product = CatalogService.FindCatalogItem(productId);
                itemSpecs = CatalogService.GetCatalogItemSpecs(productId);

                this.DataBind();
            }
        }
        protected void Save_Click(object sender, EventArgs e)
        {
            if (ModelState.IsValid)
            {
                var catalogItemSpecs = new CatalogItemSpecs()
                {
                    Id = Convert.ToInt32(Page.RouteData.Values["id"]),
                    Polyphony = Polyphony.Text,
                    Oscillators  = Oscillators.Text,
                    Lfo = Lfo.Text,
                    Effects = Effects.Text,
                    Keyboard = Keyboard.Text,
                    Memory = Memory.Text,
                    DateProduced = int.Parse(DateProduced.Text)                   
                };
                CatalogService.UpdateCatalogItemSpecs(catalogItemSpecs);
                Response.Redirect("~");
            }
        }
    }
}