using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using MVCClient.Models;

namespace MVCClient.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // Call the webapi services of Employee : Get

        public ActionResult Display()
        {
            IEnumerable<MVCEmployeeModel> emplist = null;
            //create an object of HTTPClient in order to access the webapi services
            using(var Webclient= new HttpClient())
            {
                Webclient.BaseAddress = new Uri("https://localhost:44334/api/");
                var responseTask = Webclient.GetAsync("employee");
                responseTask.Wait();

                var result = responseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<MVCEmployeeModel>>();
                    readTask.Wait();
                    emplist = readTask.Result;
                }
                else
                {
                    emplist = Enumerable.Empty<MVCEmployeeModel>();
                    ModelState.AddModelError(string.Empty, "Some Error Occured.. Try Later");
                }
                return View(emplist);
            }

        }

        //to add a new record

        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(MVCEmployeeModel mvcemp)
        {
            using (var Webclient = new HttpClient())
            {
                Webclient.BaseAddress = new Uri("https://localhost:44334/api/employee");

                //http post
                var postTask = Webclient.PostAsJsonAsync<MVCEmployeeModel>("employee", mvcemp);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Display");
                }
            }
            ModelState.AddModelError(string.Empty, "Some error occured.. try later");
            return View(mvcemp);
        }
    }
}