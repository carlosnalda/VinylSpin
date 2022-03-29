using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylSpinService.Data;

namespace VinylSpinService.Logic.VinylLogic
{
    public class VinylCreate
    {
        public class Command : IRequest
        {
            public Vinyl Vinyl { get; set; }
        }

        public class Handler : HandlerBase, IRequestHandler<Command>
        {
            public Handler(VinylSpinContext context) : base(context)
            {
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Vinyls.Add(request.Vinyl);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
