using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCClient.Models
{
    public class MVCEmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public Nullable<double> Salary { get; set; }
        public Nullable<int> Dept { get; set; }
    }
}