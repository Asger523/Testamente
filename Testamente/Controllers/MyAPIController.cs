using Microsoft.AspNetCore.Mvc;

namespace Testamente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyAPIController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var response = new
            {
                Message = "Hello from the API!",
                Timestamp = DateTime.UtcNow,
                Something = "BlahBlah"
            };
            return Ok(response);
        }
    }
}
