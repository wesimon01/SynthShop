using log4net;
using SynthShop.Services;
using SynthShopData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SynthShop.Catalog
{
    public partial class Create : System.Web.UI.Page
    {
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ICatalogService CatalogService { get; set; }

        public IEnumerable<CatalogManufacturer> GetManufacturers()
        {
            return CatalogService.GetCatalogManufacturers();
        }
        public IEnumerable<CatalogType> GetTypes()
        {
            return CatalogService.GetCatalogTypes();
        }

        protected void Create_Click(object sender, EventArgs e)
        {
            if (ModelState.IsValid)
            {
                var catalogItem = new CatalogItem()
                {
                    Name = Name.Text,
                    Description = Description.Text,
                    CatalogManufacturerId = int.Parse(Manufacturer.SelectedValue),
                    
                    Price = decimal.Parse(Price.Text),
                    AvailableStock = int.Parse(Stock.Text)

                };
                
                CatalogService.CreateCatalogItem(catalogItem);
                Response.Redirect("~");           
            }
        }
    }
}