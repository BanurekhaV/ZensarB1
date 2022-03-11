using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Day4Prj.Models
{
    public class Student
    {
        [Display(Name ="Student Roll No:")]
        public int RollNo { get; set; }
        [Display(Name ="Student Name :")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Gender { get; set; }
        public string Address { get; set; }
    }
}