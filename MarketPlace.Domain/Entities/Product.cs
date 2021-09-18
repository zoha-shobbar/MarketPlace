using MarketPlace.Domain.Common;
using System;
using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public Guid ProductId { get; set; }

        public string Title { get; set; }

        public string ShortName { get; set; }

        public string URL { get; set; }

        public string Description { get; set; }

        public int? Price { get; set; }

        public int? Quantity { get; set; }

        public string SerialNum { get; set; }

        public int? PurchasePrice { get; set; }

        public int? SpecialSellPrice { get; set; }

        public bool? CellarManagment { get; set; }

        public string Inventory { get; set; }

        public int? LowInventoryThreshold { get; set; }

        public double? Weight { get; set; }

        public string Dimensions { get; set; }

        public string CrossSells { get; set; }

        public bool? ForMoreSell { get; set; }

        public byte? PublishStatus { get; set; }

        public bool? AllowComment { get; set; }

        public Currency Currency { get; set; }
        public Guid? CurrencyId { get; set; }

        public Country ManufacturingCountry { get; set; }
        public Guid? ManufacturingCountryId { get; set; }

        public ProductCategory ProductCategory { get; set; }
        public Guid? ProductCategoryId { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
