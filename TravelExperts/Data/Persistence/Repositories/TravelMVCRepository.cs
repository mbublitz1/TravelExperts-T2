using Data.Core.Models;
using Data.Core.Repository;
using Data.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data.Persistence.Repositories
{
    public class TravelMVCRepository
    {
        private readonly ApplicationDbContext _context;

        public TravelMVCRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer GetCustomer(int id)
        {
            return _context.Customers.SingleOrDefault(c => c.CustomerId == id);
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

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public List<Agency> GetAgentandAgencies()
        {
            var result = _context.Agencies
                .Include(a => a.Agents).ToList();

            return result;
        }

        public List<TripType> GetTripTypes()
        {
            return _context.TripTypes.ToList();
        }
    }
}
