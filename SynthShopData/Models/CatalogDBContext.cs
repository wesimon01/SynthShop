using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthShopData.Models
{
    public class CatalogDBContext : DbContext
    {
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }
        public DbSet<CatalogManufacturer> CatalogManufacturers { get; set; }

        public CatalogDBContext() : base("name=CatalogDBContext")
        {
        }





    }
}
