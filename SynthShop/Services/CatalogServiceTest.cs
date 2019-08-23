using SynthShop.ViewModel;
using SynthShopData.Models;
using SynthShopData.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SynthShop.Services
{
    public class CatalogServiceTest : ICatalogService
    {
        private List<CatalogItem> catalogItems
        public void CreateCatalogItem(CatalogItem catalogItem)
        {
            catalogItems = new List<CatalogItem>(PreconfiguredData.GetPreconfiguredCatalogItems());
        }

        

        public CatalogItem FindCatalogItem(int id)
        {
            return catalogItems.FirstOrDefault(i => i.Id == id);
        }

        public PaginatedItemsViewModel<CatalogItem> GetCatalogItemsPaginated(int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CatalogItemSpecs> GetCatalogItemSpecs(int catalogItemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CatalogManufacturer> GetCatalogManufacturers()
        {
            return PreconfiguredData.GetPreconfiguredCatalogManufacturers();
        }

        public IEnumerable<CatalogType> GetCatalogTypes()
        {
            return PreconfiguredData.GetPreconfiguredCatalogTypes();
        }

        public void RemoveCatalogItems(CatalogItem catalogItem)
        {
            catalogItems.Remove(catalogItem);
        }

        public void UpdateCatalogItem(CatalogItem modifiedItem)
        {
            var originalItem = FindCatalogItem(modifiedItem.Id);
            if (originalItem != null)
            {
                catalogItems[catalogItems.IndexOf(originalItem)] = modifiedItem;
            }
        }
        public void Dispose()
        {

        }
    }
}