using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SynthShop.ViewModel;
using SynthShopData.Models;

namespace SynthShop.Services
{
    public class CatalogService : ICatalogService
    {
        public void CreateCatalogItem(CatalogItem catalogItem)
        {
            throw new NotImplementedException();
        }

        public int CreateCatalogItemSpecs(CatalogItemSpecs itemSpecs)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public CatalogItem FindCatalogItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CatalogItemSpecs> GetAllCatalogItemSpecs(int catalogItemId)
        {
            throw new NotImplementedException();
        }

        public PaginatedItemsViewModel<CatalogItem> GetCatalogItemsPaginated(int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CatalogManufacturer> GetCatalogManufacturers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CatalogType> GetCatalogTypes()
        {
            throw new NotImplementedException();
        }

        public void RemoveCatalogItem(CatalogItem catalogItem)
        {
            throw new NotImplementedException();
        }

        public void UpdateCatalogItem(CatalogItem catalogItem)
        {
            throw new NotImplementedException();
        }

        CatalogItemSpecs ICatalogService.GetCatalogItemSpecs(int id)
        {
            throw new NotImplementedException();
        }
    }
}