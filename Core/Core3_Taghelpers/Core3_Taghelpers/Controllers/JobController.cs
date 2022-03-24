using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core3_Taghelpers.Models;

namespace Core3_Taghelpers.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(JobApplication JA)
        {
            //if (string.IsNullOrEmpty(JA.Name))
            //    ModelState.AddModelError(nameof(JA.Name), "Please enter your Name");
            //else if (JA.Name == "Banu Rekha")
            //    ModelState.AddModelError("", "You are not Eligible to apply for the job");
            //if (JA.DOB == Convert.ToDateTime("01-01-0001 00:00:00"))
            //    ModelState.AddModelError(nameof(JA.DOB), "Please enter Your Date of Birth");
            //else if (JA.DOB > DateTime.Now)
            //    ModelState.AddModelError(nameof(JA.DOB), "Date of Birth cannot be future date");
            //else if (JA.DOB < new DateTime(1980, 1, 1))
            //    ModelState.AddModelError(nameof(JA.DOB), "Date of Birth cannot be before 1980");
            //if (JA.Experience.ToString() == "Select")
            //    ModelState.AddModelError(nameof(JA.Experience), "Please select your experience");
            //if (!JA.AcceptTerms)
            //    ModelState.AddModelError(nameof(JA.AcceptTerms), "You must accept the Terms");
            //Error applicable for the entire model and not for a particular property
           // ModelState.AddModelError("", "Some Model Level Error Occurred");
            if(ModelState.IsValid)
                 return View("Accepted", JA);
            else return View();
        }
    }
}
