using AppSecrets.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppSecrets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppSecretController : ControllerBase
    {
        private readonly AppConfiguration _config;

        public AppSecretController(AppConfiguration config)
        {
            this._config = config;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this._config);
        }
    }
}
