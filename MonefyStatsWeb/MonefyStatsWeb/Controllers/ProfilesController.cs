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
    public class ProfilesController : Controller
    {
        private readonly IChartService _chartService;
        private readonly IProfileService _profileService;

        public ProfilesController(IChartService chartService, IProfileService profileService)
        {
            _chartService = chartService;
            _profileService = profileService;
        }

        [HttpGet("{id}/charts/line")]
        public async Task<IActionResult> GetLineChartAsync(string id)
        {
            var profile = await _profileService.GetProfileByIdAsync(id);
            return Ok(_chartService.GetLineChartData(profile));
        }

        [HttpGet("{id}/accounts")]
        public async Task<IActionResult> GetAccountsAsync(string id)
        {
            var profile = await _profileService.GetProfileByIdAsync(id);
            return Ok(profile.Accounts.Select(el => el.Name));
        }

        [HttpGet("{id}/categories")]
        public async Task<IActionResult> GetCategoriesAsync(string id)
        {
            var profile = await _profileService.GetProfileByIdAsync(id);
            return Ok(profile.Categories);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProfileAsync(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                var bytes = memoryStream.ToArray();

                return Ok(await _profileService.SaveProfileAsync(new FileBussines
                {
                    Content = bytes
                }));
            }
        }

        //[HttpGet("bar/{id}")]
        //public async Task<IActionResult> GetBarChart(string id)
        //{
        //    return Ok(await _chartService.GetLineChartDataAsync(id));
        //}
    }
}
