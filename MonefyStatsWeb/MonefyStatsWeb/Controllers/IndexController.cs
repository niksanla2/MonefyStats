using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonefyStats.Bussines.Models;
using MonefyStats.Bussines.Services;

namespace MonefyStats.Web.Controllers
{
    [Route("api/[controller]")]
    public class IndexController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetIndex(string id)
        {
            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode =(int) HttpStatusCode.OK,
                Content = "<html><body>Hello World</body></html>"
            };
        }
        

        
       
    }
}
