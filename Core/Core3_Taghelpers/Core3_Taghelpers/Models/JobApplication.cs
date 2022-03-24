using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Core3_Taghelpers.CustomValidators;

namespace Core3_Taghelpers.Models
{
    public class JobApplication
    {
        [Required(ErrorMessage ="Name cannot be Blank")]
        [Display(Name="Job Applicant's Name:")]
        public string Name { get; set; }
        [CustomDate]
        public DateTime DOB { get; set; }
        [Range(0,5)]
        public string Experience { get; set; }
        [Range(typeof(bool),"true","true",ErrorMessage ="You must accept the Terms")]
        public bool AcceptTerms { get; set; }
    }
}
