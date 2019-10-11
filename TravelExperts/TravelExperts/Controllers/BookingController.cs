using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Core.Models;
using Data.Persistence;
using Data.Persistence.Repositories;

namespace TravelExperts.Controllers
{
    public class BookingController : Controller
    {
        private TravelMVCRepository _context = new TravelMVCRepository(new ApplicationDbContext());

        // GET: Booking
       public ActionResult Index(int id)
       {
           List<TripType> tripTypes = _context.GetTripTypes();
            BookingDetailViewModel viewModel = new BookingDetailViewModel
            {
                PackageId = id,
                TripTypes = _context.GetTripTypes()
            };

            return View(viewModel);
        }

        public ActionResult BookTrip(BookingDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var viewModel = new BookingDetailViewModel
                {
                    BookingDate = model.BookingDate,
                    TripStart = model.TripStart,
                    TripEnd = model.TripEnd,
                    TravelerCount = model.TravelerCount,
                    TripTypeId = model.TripTypeId,
                    PackageId = model.PackageId,
                    ItineraryNo = model.ItineraryNo,
                    Description = model.Description,
                    Destination = model.Destination

                };
            }

            return View();
        }


        public ActionResult Update(int bookingID)
        {
            return View();
        }


        public ActionResult Delete(int bookingID)
        {
            return View();
        }
    }
}