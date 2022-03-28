using Day6EF_with_SP.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day6EF_with_SP.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext db = new NorthwindContext();
        public IActionResult Index()
        {
            List<Category> cat = db.Categories.ToList();
            return View(cat);
        }

        public IActionResult GetCategoryDetails()
        {
            List<Category> cat = db.Categories.ToList();
            return View(cat);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category cat)
        {
            db.Categories.Add(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Category cat = db.Categories.Find(id);
            db.Categories.Remove(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Category cat = db.Categories.Find(id);
            return View(cat);
        }

        public IActionResult Edit(int id)
        {
            Category cat = db.Categories.Find(id);
            return View(cat);
        }

        [HttpPost]
        public IActionResult Edit(Category c)
        {
            Category cat = db.Categories.Find(c.CategoryId);
            cat.CategoryName = c.CategoryName;
            cat.Description = c.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetCategorybySortedName()
        {
            List<string> catlist = (from cat in db.Categories
                                    orderby cat.CategoryName
                                    select cat.CategoryName).ToList();
            return View(catlist);
        }
    }
}
