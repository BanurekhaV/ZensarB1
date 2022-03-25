using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEFDbFirst.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public double? Salary { get; set; }
        public int? Dept { get; set; }

        public virtual Department DeptNavigation { get; set; }
    }
}
