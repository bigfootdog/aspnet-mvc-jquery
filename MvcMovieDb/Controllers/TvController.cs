using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovieDb.Controllers
{
    public class TvController : Controller
    {
        //
        // GET: /Tv/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            ViewBag.Id = id;

            return View();
        }

        public ActionResult Popular()
        {
            return View();
        }

    }
}
