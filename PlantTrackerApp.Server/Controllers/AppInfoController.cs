using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PlantTrackerApp.Server.Models;

namespace PlantTrackerApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppInfoController : ControllerBase
    {
        private readonly IOptions<AppConfig> _config;

        public AppInfoController(IOptions<AppConfig> config)
        {
            _config = config;
        }

        [HttpGet("version")]
        public IActionResult GetVersion()
        {
            return Ok(new { version = _config.Value.AppVersion });
        }
    }
}
