using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using testmvc_vue.Models;

namespace testmvc_vue.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Vue()
        {
            return View();
        }

        public IActionResult VueLocalRequest()
        {

            ViewBag.AsteroidGridVue = System.IO.File.ReadAllText("./Views/VueComponents/AsteroidGridVue.js");

            return View();
        }

        public IActionResult VueWithPayload()
        {
            ViewBag.AsteroidGridVue = System.IO.File.ReadAllText("./Views/VueComponents/AsteroidGridVue.js");
            ViewBag.payloadJSON = System.IO.File.ReadAllText("./Data/DataTest/asteroids.json");

            return View();
        }

        public IActionResult VueTemplateTest()
        {

            return View();
        }


        //---------------------------------------------------------
        public IActionResult blank1()
        {
            return View();
        }
        public IActionResult blank2()
        {
            return View();
        }
        public IActionResult blank3()
        {
            return View();
        }
        public IActionResult blank4()
        {
            return View();
        }
        public IActionResult blank5()
        {
            return View();
        }
        public IActionResult blank6()
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
