using Data.Core.Models;
using Data.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persistence.Repositories
{
    public class TravelMVCRepository : IRepository
    {
        private readonly ApplicationDbContext _context;

        public TravelMVCRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Package> GetPackages()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetSuppliers()
        {
            throw new NotImplementedException();
        }
    }
}
