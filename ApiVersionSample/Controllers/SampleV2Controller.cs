using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersionSample.Controllers
{
    [Route("Sample")]
    [Route("api/v{version:apiVersion}/sample")]
    [ApiVersion(2.0)]
    [ApiVersion(3.0)]
    [ApiController]
    public class SampleV2Controller : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion(2.0)]
        public IActionResult Get()
        {
            var apiVersion = HttpContext.GetRequestedApiVersion();
            return Ok(new { version = apiVersion.ToString("F") });
        }

        [HttpGet]
        [MapToApiVersion(3.0)]
        public IActionResult GetV3()
        {
            var apiVersion = HttpContext.GetRequestedApiVersion();
            return Ok(new { version = apiVersion.ToString("F") });
        }
    }
}
