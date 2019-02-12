using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Alzheimer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocalizationController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
