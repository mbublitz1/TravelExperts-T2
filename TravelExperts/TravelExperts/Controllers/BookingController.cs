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
       public ActionResult Index()
        { 
            return View();
        }


        public ActionResult Insert(BookingDetailViewModel viewModel)
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