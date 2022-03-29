using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinylSpinService.Data;

namespace VinylSpinService.Logic.VinylLogic
{
    public class HandlerBase
    {
        protected readonly VinylSpinContext _context;
        protected HandlerBase(VinylSpinContext context)
        {
            _context = context;
        }
    }
}
