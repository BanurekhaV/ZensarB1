using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModelStateEg.Models
{
    public class User
    {
        [Required(ErrorMessage ="Please Enter First Name")]
        [Display(Name ="First Name :")]
        [StringLength(30,ErrorMessage ="Firstname can only be upto 30 characters")]
        public string Firstname { get; set; }
        [Display(Name ="Last Name")]
        public string Lastname {get;set;}
        public int Age { get; set; }
        //[EmailAddress(ErrorMessage ="Enter Valid Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",ErrorMessage ="Enter Email in the Correct format")]
        [Required(ErrorMessage ="Email Cannot be Blank")]
        [Display(Name ="Email Address")]
        public string Emailaddress { get; set; }
    }
}