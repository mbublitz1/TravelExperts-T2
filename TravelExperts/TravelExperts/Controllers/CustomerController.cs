using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Data.Core.Models;
using Data.Core.ViewModel;
using Data.Persistence;
using Data.Persistence.Repositories;
using Microsoft.AspNet.Identity;

namespace TravelExperts.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        TravelMVCRepository _context = new TravelMVCRepository(new ApplicationDbContext());
        // GET: Customer
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            var viewModel = _context.GetCustomer(userId);
            return View(viewModel);
        }

        public JsonResult Update(Customer model)
        {
            string result = "Error! Unable to update customer!";
            string userId = User.Identity.GetUserId();
            Customer itemInDb = _context.GetCustomer(userId);

            int isSuccessful = _context.UpdateCustomer(itemInDb, model);

            if (isSuccessful > 0)
            {
                result = "Your information has been updated successfully.";
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TravelProducts()
        {
            string userId = User.Identity.GetUserId();
            TravelProductViewModel viewModel = _context.GetCustomerTravelProducts(userId);

            if (viewModel.GetBookingCountWithPackage() == 0)
            {
               viewModel.Bookings = new List<Booking>();
            }

            return View(viewModel);

        }
    }
}