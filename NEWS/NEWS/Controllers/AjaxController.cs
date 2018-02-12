using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NEWS.Models;

namespace NEWS.Controllers
{
    public class AjaxController : Controller
    {
        NewsEntities db = new NewsEntities();
      


        public ActionResult GetPosts(int skip, int take)
        {
            object data = null;

            var posts = db.Posts.OrderBy(ps => ps.Title).Skip(skip).Take(take).
                Select(ps => new
                {
                    ps.Id,
                    ps.Photo,
                    ps.Title,
                    ps.Content,
                    ps.Dateline

                }).ToList();
            data = new
            {
                status = 200,
                message = "success",
                response = posts

            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}