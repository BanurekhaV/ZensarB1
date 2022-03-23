using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core3_Taghelpers.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
