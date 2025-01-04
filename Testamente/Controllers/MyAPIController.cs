using Microsoft.AspNetCore.Mvc;
using Testamente.Models;

namespace Testamente.Controllers
{
    [Route ("api/[controller]")] // Postman called 'https://localhost:####/api/myapi'
    [ApiController]
    public class MyAPIController : ControllerBase
    {
        [HttpGet("getOne")]
        public string GetThingyOne ()
        {
            return "GetThingyOne!";
        }

        [HttpGet("getFromRepo")]
        public Testator GetTestator ()
        {
            List<Testator> testators = TestatorRepo.GetTestators ();
            if (testators != null && testators.Count >= 1) {
                //HttpContext.Response.Headers.Add ("X Wherefrom: ", "From a valid list in the repo"); // Bad because no whitespace nor colons in header
                HttpContext.Response.Headers.Add ("X-Wherefrom", "From a valid list in the repo");
                return testators[0];
            }

            return null;
        }

        [HttpGet]
        public IActionResult GetThingy ()
        {
            var result = new {
                ThingyOne = "One",
                OtherField = "OtherOne"
            };
            return Ok (result);
        }

        [HttpPost]
        public IActionResult PostThingy ([FromQuery] Inheritor newInheritor)
        {
            if (newInheritor == null) {
                return BadRequest ("Invalid data provided!");
            }

            return Ok ($"Good, new Inheritor made with {newInheritor.Name}, {newInheritor.Address}, {newInheritor.Birthdate}, {newInheritor.Gender}");
        }
    }
}
