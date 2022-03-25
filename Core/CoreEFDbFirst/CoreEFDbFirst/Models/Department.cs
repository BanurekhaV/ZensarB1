using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEFDbFirst.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public double? Budget { get; set; }
        public string Loc { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
