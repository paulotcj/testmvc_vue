using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testmvc_vue.Data;
using testmvc_vue.Models;

namespace testmvc_vue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public TestApiController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Produces("application/json")]
        [HttpGet("idval")]
        [EnableQuery()]
        public async Task<IActionResult> IdVal()
        {
            string contentToReturn = System.IO.File.ReadAllText("./Data/DataTest/asteroids.json");

            return Content(contentToReturn, "application/json");

        }


        [Produces("application/json")]
        [HttpGet("odatatest2")]
        [EnableQuery()]
        public IEnumerable<Student> OdataTest2()
        {
            var contentToReturn = new List<Student>();

            Student stu = null;

            //-----
            stu =new Student();
            stu.StudentId = 1;
            stu.Name = "aaa";
            stu.Score = 11;
            stu.SchoolId = "aaaschool name1";
            stu.School = "school name1";
            contentToReturn.Add(stu);
            //-----
            stu = new Student();
            stu.StudentId = 2;
            stu.Name = "bbb";
            stu.Score = 44;
            stu.SchoolId = "aaaschool name1";
            stu.School = "school name1";
            contentToReturn.Add(stu);
            //-----
            stu = new Student();
            stu.StudentId = 3;
            stu.Name = "ccc";
            stu.Score = 22;
            stu.SchoolId = "aaaschool name1";
            stu.School = "school name1";
            contentToReturn.Add(stu);
            //-----
            stu = new Student();
            stu.StudentId = 4;
            stu.Name = "ddd";
            stu.Score = 88;
            stu.SchoolId = "aaaschool name2";
            stu.School = "school name2";
            contentToReturn.Add(stu);
            //-----
            stu = new Student();
            stu.StudentId = 1;
            stu.Name = "eee";
            stu.Score = 55;
            stu.SchoolId = "aaaschool name2";
            stu.School = "school name2";
            contentToReturn.Add(stu);



            return contentToReturn;

        }

        //--------

        [Produces("application/json")]
        [HttpGet("odatatest")]
        [EnableQuery()]
        public async Task<IActionResult> OdataTest()
        {
            string contentToReturn = System.IO.File.ReadAllText("./Data/DataTest/odata_test.json");

            //dynamic jsonaaaa = Newtonsoft.Json.JsonConvert.DeserializeObject(contentToReturn);

            return Content(contentToReturn, "application/json");

        }

        //--------

        [Produces("application/json")]
        [HttpGet("dapper")]
        [EnableQuery()]
        public async Task<IActionResult> Dapper()
        {

            var contentToReturn = new List<Object>();
            return Ok(contentToReturn);


        }

        //--------
    }
}
