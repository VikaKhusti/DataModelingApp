using DataModeling_ASP.Net_Core_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace DataModeling_ASP.Net_Core_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string item = "";
            using(DatasContext db = new DatasContext())
            {
                var items = db.MainDates.ToList();
                item = items[0].ToString();
                //Console.WriteLine("Items:");
                //foreach (MainDate md in items)
                //{
                //    Console.WriteLine($"{md.Id} -- {md.Country} -- {md.Itemdate}");
                //}
            }
            return View(item);
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
