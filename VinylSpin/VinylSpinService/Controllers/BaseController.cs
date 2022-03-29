using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace VinylSpinService.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        public readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
