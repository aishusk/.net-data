using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class QuickerController : Controller
    {
        // GET: Quicker

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}