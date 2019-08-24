﻿using SynthShop.ViewModel;
using SynthShopData.Models;
using System;
using System.Collections.Generic;

namespace SynthShop.Services
{
    public interface ICatalogService : IDisposable
    {
        CatalogItem FindCatalogItem(int id);
        IEnumerable<CatalogManufacturer> GetCatalogManufacturers();
        IEnumerable<CatalogType> GetCatalogTypes();
        IEnumerable<CatalogItemSpecs> GetAllCatalogItemSpecs(int catalogItemId);
        CatalogItemSpecs GetCatalogItemSpecs(int id);
        void CreateCatalogItem(CatalogItem catalogItem);
        void UpdateCatalogItem(CatalogItem catalogItem);
        void RemoveCatalogItems(CatalogItem catalogItem);
        PaginatedItemsViewModel<CatalogItem> GetCatalogItemsPaginated(int pageSize, int pageIndex);
        //DetailsViewModel GetCatalogItemDetails(int id);
    }
}
