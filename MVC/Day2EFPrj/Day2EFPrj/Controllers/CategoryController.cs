using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2EFPrj.Models;

namespace Day2EFPrj.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Category
        public ActionResult Index()
        {
            return RedirectToAction("GetCategoryScaffolded");
        }

        //2. Fetch Data from category table
        public ActionResult GetCategoryDetails()
        {
            List<Category> category = db.Categories.ToList();
            return View(category);
        }

        //3. Fetching the data by category name in ascending order
        //linq query
        public ActionResult GetCategoryByName()
        {
            //query syntax
            List<string> cname = (from cat in db.Categories
                                  orderby cat.CategoryName
                                  select cat.CategoryName).ToList();
            return View(cname);

        }

        //4. the above requirement using Method syntax
        public ActionResult GetCategoryByMethod()
        {
            //method syntax
            dynamic cm = (db.Categories.OrderBy(c => c.CategoryName).Select(c1 => c1.CategoryName)).ToList();
            return View(cm);
        }

        //5. Getting the category details from scaffolded view
        public ActionResult GetCategoryScaffolded()
        {
            List<Category> cat = db.Categories.ToList();
            return View(cat);
        }

        //6. Crud Operations to create and post of create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category cat)
        {
            db.Categories.Add(cat);
            db.SaveChanges();
            return RedirectToAction("GetCategoryScaffolded");
        }

        //7. get details of a particular category
        public ActionResult Details(int id)
        {
            Category c = db.Categories.Find(id);
            return View(c);
        }
    }
}