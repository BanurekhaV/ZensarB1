using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core3_Taghelpers.Models;

namespace Core3_Taghelpers.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repo;
        public HomeController(IRepository ir)
        {
            repo = ir;
        }
        public IActionResult Index()
        {
            return View(repo.Products);
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            repo.AddProduct(product);
            return RedirectToAction("Index");
        }

        public ViewResult Edit() => View("Create", repo.Products.Last());
    }
}
