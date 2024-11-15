using Microsoft.AspNetCore.Mvc;

namespace workshop_dotnet.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {

        }

        [HttpGet("add")]
        public IActionResult Add(int value)
        {
            // comment
            var result = value + 1;
            return Ok(result);
        }

        [HttpGet("minus")]
        public IActionResult Minus(int value)
        {
            var result = value - 1;
            return Ok(result);
        }
    }
}
