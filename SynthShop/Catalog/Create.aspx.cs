using log4net;
using SynthShop.Services;
using SynthShopData.Models;
using System;
using System.Collections.Generic;

namespace SynthShop.Catalog
{
    public partial class Create : System.Web.UI.Page
    {
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ICatalogService CatalogService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            _log.Info($"Now loading... /Catalog/Create.aspx");
        }

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
                    CatalogTypeId = int.Parse(Type.SelectedValue),
                    Price = decimal.Parse(Price.Text),
                    AvailableStock = int.Parse(Stock.Text)
                };
                var itemSpecs = new CatalogItemSpecs()
                {
                    Polyphony = Polyphony.Text,
                    Oscillators = Oscillators.Text,
                    Lfo = Lfo.Text,
                    Filter = Filter.Text,
                    Effects = Effects.Text,
                    Keyboard = Keyboard.Text,
                    Memory = Memory.Text,
                    DateProduced = int.Parse(DateProduced.Text)
                };

                var specId = CatalogService.CreateCatalogItemSpecs(itemSpecs);
                catalogItem.CatalogItemSpecsId = specId;
                CatalogService.CreateCatalogItem(catalogItem);
                Response.Redirect("~");     
            }
        }
    }
}