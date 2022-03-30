using Client_WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Client_WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Reservation> reservationlist = new List<Reservation>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //get all reservations from api
        public async Task<IActionResult> Index()
        {
            
            using(var httpclient= new HttpClient())
            {
                using (var response = await httpclient.GetAsync("https://localhost:44323/api/reservation/"))
                {
                    string apiresponse = await response.Content.ReadAsStringAsync();
                    reservationlist = JsonConvert.DeserializeObject<List<Reservation>>(apiresponse);
                }
            }
            return View(reservationlist);
        }

        //get specific reservation from api by providing Id
        public ViewResult GetReservation() => View();

        [HttpPost]
        public async Task<IActionResult>GetReservation(int id)
        {
            Reservation reservation = new Reservation();
            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync("https://localhost:44323/api/reservation/" + id))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiresponse = await response.Content.ReadAsStringAsync();
                        reservation = JsonConvert.DeserializeObject<Reservation>(apiresponse);
                    }
                    else
                        ViewBag.StatusCode = response.StatusCode;
                }
            }
            return View(reservation);
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
