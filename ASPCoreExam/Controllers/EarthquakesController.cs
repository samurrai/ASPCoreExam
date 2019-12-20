using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreExam.Models;
using ASPCoreExam.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EarthquakesController : ControllerBase
    {
        private readonly EarthquakesService service;

        public EarthquakesController(EarthquakesService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> GetEarthqukaes(int amount)
        {
            List<EarthquakeInfo> earthquakes = await service.GetEarthquakes(amount);
            return Ok(earthquakes);
        }
    }
}