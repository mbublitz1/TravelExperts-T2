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

        public Customer GetCustomer(string id)
        {
            return _context.Customers.SingleOrDefault(c => c.UserId == id);
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

        public int UpdateCustomer(Customer itemInDb, Customer model)
        {
            if (itemInDb != null)
            {
                itemInDb.CustFirstName = model.CustFirstName;
                itemInDb.CustLastName = model.CustLastName;
                itemInDb.CustAddress = model.CustAddress;
                itemInDb.CustCity = model.CustCity;
                itemInDb.CustProv = model.CustProv;
                itemInDb.CustPostal = model.CustPostal;
                itemInDb.CustCountry = model.CustCountry;
                itemInDb.CustHomePhone = model.CustHomePhone;
                itemInDb.CustBusPhone = model.CustBusPhone;
                itemInDb.CustEmail = model.CustEmail;

                return _context.SaveChanges();
            }

            return 0;
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

        public TravelProductViewModel GetCustomerTravelProducts(string userId)
        {
            var result = _context.Customers
                .Include(b => b.Bookings).SingleOrDefault(b => b.UserId == userId);
            TravelProductViewModel travelProducts = new TravelProductViewModel();

            if (result != null)
            {
                travelProducts = new TravelProductViewModel
                {
                    CustomerId = result.CustomerId,
                    CustFirstName = result.CustFirstName,
                    CustLastName = result.CustLastName,
                    Bookings = result.Bookings.ToList()
                };
            }

            return travelProducts;
        }
    }
}
