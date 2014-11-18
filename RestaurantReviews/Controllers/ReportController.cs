using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantReviews.Models;

namespace RestaurantReviews.Controllers
{
    public class ReportController : Controller
    {
        private ReportDataContext db = new ReportDataContext();
        // GET: Report


        public ActionResult Index()
        {
            var val = db.GetRatingsReport().ToList();
            return View(val);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}