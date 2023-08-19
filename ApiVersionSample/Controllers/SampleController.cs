using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersionSample.Controllers
{
    [Route("Sample")]
    [Route("api/v{version:apiVersion}/Sample")]
    [ApiVersion(1.0, Deprecated = true)] // 可不加，預設為 1.0
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { version = "1.0" });
        }
    }
}
