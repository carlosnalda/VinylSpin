using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylSpinService.Data;

namespace VinylSpinService.Logic.VinylLogic
{
    public class VinylList
    {
        public class Query : IRequest<List<Vinyl>> { }

        public class Handler : HandlerBase, IRequestHandler<Query, List<Vinyl>>
        {
            public Handler(VinylSpinContext context) : base(context)
            {
            }

            public async Task<List<Vinyl>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Vinyls.ToListAsync(cancellationToken);
            }
        }
    }
}
