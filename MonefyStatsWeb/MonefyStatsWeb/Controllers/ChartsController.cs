using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonefyStats.Bussines.Models;
using MonefyStats.Bussines.Services;

namespace MonefyStats.Web.Controllers
{
    [Route("api/[controller]")]
    public class ChartsController : Controller
    {
        private readonly IChartService _chartService;

        public ChartsController(IChartService chartService)
        {
            _chartService = chartService;
        }

        [HttpGet("line/{id}")]
        public async Task<IActionResult> GetFile(string id)
        {
            return Ok(await _chartService.GetLineChartDataAsync(id));
        }
        
    }
}
