using Data.Core.Models;
using Data.Core.Repository;
using Data.Core.ViewModel;
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
            return _context.Customers.Where(c => c.CustomerId == id).SingleOrDefault();
        }

        public List<Package> GetPackages()
        {
            return _context.Packages.ToList();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetSuppliers()
        {
            return _context.Suppliers.ToList();
        }
    }
}
