using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testmvc_vue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {

        [Produces("application/json")]
        [HttpGet("idval")]
        public async Task<IActionResult> IdVal()
        {
            string contentToReturn = System.IO.File.ReadAllText("./Data/DataTest/asteroids.json");

            return Content(contentToReturn, "application/json");

        }
    }
}
