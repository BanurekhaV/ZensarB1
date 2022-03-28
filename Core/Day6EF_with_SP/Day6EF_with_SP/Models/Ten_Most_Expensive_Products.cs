using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day6EF_with_SP.Models
{
    public partial class Ten_Most_Expensive_Products
    {
        [Key]
        public string TenMostExpensiveProducts { get; set; }
        public Nullable<decimal>UnitPrice { get; set; }
    }
}
