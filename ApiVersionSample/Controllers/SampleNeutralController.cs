using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersionSample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SampleNeutralController : ControllerBase
    {
        [ApiVersionNeutral]
        [HttpGet]
        public IActionResult Get()
        {
            var apiVersion = HttpContext.GetRequestedApiVersion();
            return Ok(new { version = apiVersion.ToString("F") });
        }
    }
}
