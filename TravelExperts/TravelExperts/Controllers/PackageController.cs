using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelExperts.Controllers
{
    public class PackageController : Controller
    {
        // GET: Package
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insert(Package viewModel)
        {
            return View();
        }


        public ActionResult Update(int PackageID)
        {
            return View();
        }

        public ActionResult Delete(int PackageID)
        {
            return View();
        } 


    }
}