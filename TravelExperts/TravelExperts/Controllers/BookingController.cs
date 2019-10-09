using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelExperts.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
       public ActionResult Index(int id)
        {
            BookingDetailViewModel viewModel = new BookingDetailViewModel();
            viewModel.PackageId = id;
            return View(viewModel);
        }

        public ActionResult BookTrip(int id)
        {
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