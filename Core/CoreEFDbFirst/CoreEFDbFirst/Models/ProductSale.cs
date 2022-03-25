using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEFDbFirst.Models
{
    public partial class ProductSale
    {
        public int ProductSalesId { get; set; }
        public int? ProductId { get; set; }
        public int? QuantitySold { get; set; }
    }
}
