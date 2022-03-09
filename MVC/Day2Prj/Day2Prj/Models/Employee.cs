using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Day2Prj.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [DisplayName("Employee Name")]
        public string FullName { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DOJ { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
    }
}