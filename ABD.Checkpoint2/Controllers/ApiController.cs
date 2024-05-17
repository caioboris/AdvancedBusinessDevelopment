using Microsoft.AspNetCore.Mvc;

namespace ABD.Checkpoint2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new
            {
                status = 200,
                resultado = "It's working!"
            });
        }
    }
}
