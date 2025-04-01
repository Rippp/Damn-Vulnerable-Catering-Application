using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CateringBackend.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetHome()
            => Ok("Catering api /");

        [HttpGet("/api")]
        [AllowAnonymous]
        public IActionResult GetApi()
            => Ok("Catering api /api");
    }
}
