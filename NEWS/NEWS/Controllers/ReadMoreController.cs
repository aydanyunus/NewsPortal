using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NEWS.Models;

namespace NEWS.Controllers
{
    public class ReadMoreController : Controller
    {
        NewsEntities db = new NewsEntities();
        // GET: ReadMore
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

    }
}