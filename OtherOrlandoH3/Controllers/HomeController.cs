using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtherOrlandoH3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        #region events

        public ActionResult RedDress()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult Hareline()
        {
            return View();
        }

        #endregion

        public ActionResult Mismanagement()
        {
            return View();
        }
        
        public ActionResult Guidelines()
        {
            return View();
        }
        
        public ActionResult Contact()
        {
            return View();
        }

        #region Links

        public ActionResult HashStats()
        {
            return View();
        }

        public ActionResult BeerMeister()
        {
            return View();
        }

        public ActionResult Haberdashery()
        {
            return View();
        }

        #endregion

    }
}
