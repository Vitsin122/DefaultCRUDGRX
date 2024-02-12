using Microsoft.AspNetCore.Mvc;


namespace DefaultCRUDDRX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Zatichka : ControllerBase
    {
        [HttpGet]
        [Route("GetRekt")]
        public IActionResult Get()
        {
            return Ok("Globus");
        }
    }
}
