using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEFDbFirst.Models
{
    public partial class Account
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public int? Balance { get; set; }
    }
}
