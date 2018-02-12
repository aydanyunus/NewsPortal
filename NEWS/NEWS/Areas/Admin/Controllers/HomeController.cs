using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NEWS.Models;

namespace NEWS.Areas.Admin.Controllers
{
    
    public class HomeController : Controller
    {     
        NewsEntities db = new NewsEntities();

        [AuthorizationFilterController]
        // GET: Admin/Home
        public ActionResult Index()
        {
            
           return View();          
            
        }
    }
}