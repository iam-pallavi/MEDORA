
using Microsoft.AspNetCore.Mvc;

namespace Medora.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPatients()
        {
            return Ok("MEDORA Patient API is working!");
        }
    }
}
