using FoodMonkey.Models;
using FoodMonkey.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FoodMonkey.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(user u)
        {
            var user = UserRepository.Authenticate(u.email, u.password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.email, true);
                return RedirectToAction("Index", "Admin");
            }
            ViewBag.Error = "Invalid Email or Password";
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}