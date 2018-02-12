using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NEWS.Models;
using System.Web.Helpers;

namespace NEWS.Areas.Admin.Controllers
{
    public class AdminAccountController : Controller
    {
        NewsEntities db = new NewsEntities();

        // GET: Admin/AdminAccount
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {

            if (Email != "" && Password != "")
            {
                AdminInfo admin = db.AdminInfoes.Find(1);
                if (admin.Email == Email && Crypto.VerifyHashedPassword(admin.Password, Password))
                {
                    Session["AdminLogged"] = true;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Error = "Email or Password is wrong!";
                }
            }
            else
            {
                ViewBag.Error = "Email or Password cannot be empty!";
            }
            return View();
        }       
        

        public ActionResult Logout()
        {
            Session["AdminLogged"] = null;
            return RedirectToAction("Login", "AdminAccount");
        }
    }
}