using Alzheimer.Localization.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alzheimer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocalizationController : ControllerBase
    {
        /// <summary>
        /// Display the geolocalization
        /// </summary>
        /// <returns>The latitude and longitude</returns>
        [HttpGet]
        public IActionResult Get()
        {
            var geolocalization = new GeoLocalization
            {
                Latitude = -23.601250,
                Longitude = -46.694920
            };

            return Ok(geolocalization);
        }
    }
}
