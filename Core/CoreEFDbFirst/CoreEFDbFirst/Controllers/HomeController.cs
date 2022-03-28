using CoreEFDbFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEFDbFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ZensarDBContext db;

        public HomeController(ILogger<HomeController> logger, ZensarDBContext zdb)
        {
            _logger = logger;
            db = zdb;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetDetails()
        {
           // List<Product> products = db.Product.ToList();
            //return View(products);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
