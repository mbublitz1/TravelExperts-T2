using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Core.Models;
using Data.Core.Repository;
using Data.Core.ViewModel;
using Data.Persistence;
using Data.Persistence.Repositories;
using System.Data.Entity;

namespace TravelExperts.Controllers
{
    public class HomeController : Controller
    {
        TravelMVCRepository _context;
        public HomeController()
        {
            _context = new TravelMVCRepository(new ApplicationDbContext());
        }

        public ActionResult Index()
        {
            LoginViewModel viewModel = new LoginViewModel()
            {
                Packages = _context.GetPackages(),
                Agencies = _context.GetAgentandAgencies()
            };
            
            return View(viewModel);
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