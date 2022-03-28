using System;
using System.Collections.Generic;

#nullable disable

namespace Day6EF_with_SP.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
