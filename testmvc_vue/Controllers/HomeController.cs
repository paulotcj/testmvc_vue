using Dapper;
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

            //----------------------------------------------------------------------
            //
            // DAPPER
            //
            using (System.Data.IDbConnection cnn = new Microsoft.Data.SqlClient.SqlConnection(testmvc_vue.Data.ExecuteDB.GetConnectionString())) 
            {
                string sql = @"select * from table_A where Col1 = @table_A_col1 ; 
                               select * from table_B where Col1 = @table_B_col1 ;";
                List<Table_A> tableA_list = null;
                List<Table_B> tableB_list = null;

                var p = new { table_A_col1 = "Col1_6", table_B_col1 = "Col1_16" };

                using (var lists = cnn.QueryMultiple(sql,p)) 
                {
                    tableA_list = lists.Read<Table_A>().ToList();
                    tableB_list = lists.Read<Table_B>().ToList();
                }
            }
            //----------------------------------------------------------------------

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
