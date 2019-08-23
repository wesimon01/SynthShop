using SynthShop.ViewModel;
using SynthShopData.Models;
using SynthShopData.Models.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace SynthShop.Services
{
    public class CatalogServiceTest : ICatalogService
    {
        private List<CatalogItem> catalogItems;

        public CatalogServiceTest()
        {
            catalogItems = new List<CatalogItem>(PreconfiguredData.GetPreconfiguredCatalogItems());                
        }

        public void CreateCatalogItem(CatalogItem catalogItem)
        {
            var maxId = catalogItems.Max(i => i.Id);
            catalogItem.Id = ++maxId;
            catalogItems.Add(catalogItem);
        }

        public CatalogItem FindCatalogItem(int id)
        {
            return catalogItems.FirstOrDefault(i => i.Id == id);
        }

        public PaginatedItemsViewModel<CatalogItem> GetCatalogItemsPaginated(int pageSize = 10, int pageIndex = 0)
        {
            var items = ComposeCatalogItems(catalogItems);
            var itemsOnPage = items
                .OrderBy(i => i.Id)
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToList();
            
            return new PaginatedItemsViewModel<CatalogItem>(pageIndex, pageSize, items.Count, itemsOnPage);
        }

        public IEnumerable<CatalogItemSpecs> GetCatalogItemSpecs(int catalogItemId)
        {
            return PreconfiguredData.GetPreconfiguredCatalogItemSpecs();
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
        private List<CatalogItem> ComposeCatalogItems(List<CatalogItem> items)
        {
            var catalogTypes = PreconfiguredData.GetPreconfiguredCatalogTypes();
            var catalogManufacturers = PreconfiguredData.GetPreconfiguredCatalogManufacturers();
            var catalogItemSpecs = PreconfiguredData.GetPreconfiguredCatalogItemSpecs();
            items.ForEach(i => i.CatalogManufacturer = catalogManufacturers.First(m => m.Id == i.CatalogManufacturerId));
            items.ForEach(i => i.CatalogType = catalogTypes.First(t => t.Id == i.CatalogTypeId));
            items.ForEach(i => i.CatalogItemSpecs = catalogItemSpecs.First(s => s.Id == i.CatalogItemSpecsId));

            return items;
        }
        public void Dispose()
        {
        }
    }
}