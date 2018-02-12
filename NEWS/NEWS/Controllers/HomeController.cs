using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NEWS.Models;

namespace NEWS.Controllers
{
    public class HomeController : Controller
    {
        NewsEntities db = new NewsEntities();

        public ActionResult Index()
        {
            ViewBag.Posts = db.Posts.OrderBy(ps => ps.Title).Take(10).ToList();
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