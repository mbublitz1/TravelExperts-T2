using Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelExperts.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insert(Product viewModel)
        {
            return View();
        }

        public ActionResult Update(int ProductID)
        {
            return View();
        }

        public ActionResult Delete(int ProductID)
        {
            return View();
        }

    }
}