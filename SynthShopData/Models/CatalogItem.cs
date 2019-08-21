using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynthShopData.Models
{
    public class CatalogItem
    {
        public const string DefaultPictureName = "dummy.png";

        public CatalogItem()
        {
            PictureFileName = DefaultPictureName;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name = "Manufacturer")]
        public CatalogManufacturer CatalogManufacturer { get; set; }
        [Display(Name = "ItemSpecs")]
        public CatalogItemSpecs CatalogItemSpecs { get; set; }

        [Range(0, 999999999999.99)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "PictureName")]
        public string  PictureFileName { get; set; }
        public string PictureUri { get; set; }
        [Display(Name = "Type")]
        public int CatalogTypeId { get; set; }
        [Display(Name = "Type")]
        public CatalogType CatalogType { get; set; }
        [Display(Name = "Manufacturer")]
        public int CatalogManufacturerId { get; set; }
        [Display(Name = "ItemSpecs")]
        public int CatalogItemSpecsId { get; set; }
        [Range(0, 10000000, ErrorMessage = "The field Stock must be between 0 and 10 million.")]
        [Display(Name = "Stock")]
        public int AvailableStock { get; set; }
        public bool OnReorder { get; set; }
    }
}
