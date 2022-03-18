using Microsoft.AspNetCore.Mvc;

namespace VinylSpinService.Controllers
{
    [ApiController]
    [Route("api/Vinyles")]
    public class VinylController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetVinyles() => new(new List<object> {
                new { id = 1, Name = "Low" },
                new { id = 1, Name = "Reality" }
            });
    }
}