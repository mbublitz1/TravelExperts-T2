using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persistence.Repositories
{
    public class TravelRepository
    {
        private readonly ApplicationDbContext _context;

        public TravelRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
