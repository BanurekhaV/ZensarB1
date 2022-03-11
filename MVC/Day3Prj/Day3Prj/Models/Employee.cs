using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day3Prj.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int? AddressId { get; set; }
    }
}