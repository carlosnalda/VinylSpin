using MediatR;
using Microsoft.AspNetCore.Mvc;
using VinylSpinService.Data;
using VinylSpinService.Logic.VinylLogic;

namespace VinylSpinService.Controllers
{
    [Route("api/Vinyles")]
    public class VinylController : BaseController
    {
        public VinylController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<Vinyl>>> GetActivities()
        {
            return await _mediator.Send(new VinylList.Query());
        }
    }
}