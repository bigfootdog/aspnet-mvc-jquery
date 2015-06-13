using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovieDb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult Search(string id)
        {
            ViewBag.Id = id;
            return View();
        }

        //public ActionResult MovieDetails(string id)
        //{
        //    ViewBag.Id = id;
        //    return View();
        //}

        //public ActionResult TvDetails(string id)
        //{
        //    ViewBag.Id = id;
        //    return View();
        //}

        //public ActionResult Actor(string id)
        //{
        //    ViewBag.Id = id;
        //    return View();
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
