using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Core.Models;
using Data.Core.Repository;
using Data.Persistence;
using Data.Persistence.Repositories;

namespace TravelExperts.Controllers
{
    public class HomeController : Controller
    {
        IRepository context;
        public HomeController()
        {
            context = new TravelMVCRepository(new ApplicationDbContext());
        }

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}