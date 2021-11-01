using FoodMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodMonkey.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        public ActionResult Index()
        {
            FoodMonkeyEntities db = new FoodMonkeyEntities();
            var i = (from traf in db.site_info
                     select traf).First();

            var users = (from u in db.users
                         where u.status == "active"
                         select u).Count();

            var sale = (from s in db.orders
                        select s.price_on_selling_time).Sum();

            var order = (from o in db.orders
                         select o).Count();

            var admin = (from ad in db.users
                         where ad.status == "active" && ad.type == "admin"
                         select ad).Count();

            var restaurant = (from r in db.users
                              where r.status == "active" && r.type == "restaurant"
                              select r).Count();

            var customer = (from c in db.users
                            where c.status == "active" && c.type == "customer"
                            select c).Count();

            var agent = (from a in db.users
                         where a.status == "active" && a.type == "agent"
                         select a).Count();


            ViewBag.users = users;
            ViewBag.sale = sale;
            ViewBag.order = order;
            ViewBag.admin = admin;
            ViewBag.restaurant = restaurant;
            ViewBag.customer = customer;
            ViewBag.agent = agent;

            return View(i);
        }

        public ActionResult EditProfile()
        {
            return View();
        }

        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(user u)
        {
            if (ModelState.IsValid)
            {
                FoodMonkeyEntities db = new FoodMonkeyEntities();
                db.users.Add(u);
                db.SaveChanges();

                return RedirectToAction("ViewAllUserInfo");
            }

            return View();

        }

        public ActionResult ViewAllUserInfo()
        {
            FoodMonkeyEntities db = new FoodMonkeyEntities();
            var data = from u in db.users
                       where u.status == "active"
                       select u;

            return View(data.ToList());
        }

        public ActionResult EditUserInfo(int id)
        {
            FoodMonkeyEntities db = new FoodMonkeyEntities();
            var user = (from u in db.users
                        where u.id == id
                        select u).First();

            return View(user);
        }

        [HttpPost]
        public ActionResult EditUserInfo(user u)
        {
            using (FoodMonkeyEntities db = new FoodMonkeyEntities())
            {
                var user = (from us in db.users
                            where us.id == u.id
                            select us).FirstOrDefault();

                user.name = u.name;
                user.email = u.email;
                user.password = u.password;
                user.type = u.type;
                user.phone_number = u.phone_number;
                user.status = u.status;
                user.NID_number = u.NID_number;
                user.area = u.area;
                user.address = u.address;
                db.SaveChanges();

                return RedirectToAction("ViewAllUserInfo");
            };

        }

        public ActionResult DeleteUserInfo(int id)
        {
            using (FoodMonkeyEntities db = new FoodMonkeyEntities())
            {
                var user = (from us in db.users
                            where us.id == id
                            select us).FirstOrDefault();

                return View(user);
            };
        }

        [HttpPost]
        public ActionResult DeleteUserInfo(user u)
        {
            using (FoodMonkeyEntities db = new FoodMonkeyEntities())
            {
                var user = (from us in db.users
                            where us.id == u.id
                            select us).FirstOrDefault();

                db.users.Remove(user);
                db.SaveChanges();
                
                return RedirectToAction("ViewAllUserInfo");
            };
        }

        public ActionResult ViewAllTransaction()
        {
            FoodMonkeyEntities db = new FoodMonkeyEntities();
            var data = from d in db.orders
                       select d;

            return View(data.ToList());
        }

        public ActionResult UserReports()
        {
            FoodMonkeyEntities db = new FoodMonkeyEntities();
            var data = from d in db.reports
                       select d;

            return View(data.ToList());
        }

        public ActionResult Announcement()
        {
            FoodMonkeyEntities db = new FoodMonkeyEntities();
            var data = from d in db.announcements
                       where d.status == "active"
                       select d;

            return View(data.ToList());
        }

        public ActionResult DeleteAnnouncement(int id)
        {
            using (FoodMonkeyEntities db = new FoodMonkeyEntities())
            {
                var an = (from us in db.announcements
                            where us.ann_id == id
                            select us).FirstOrDefault();

                return View(an);
            };
        }

        [HttpPost]
        public ActionResult DeleteAnnouncement(announcement a)
        {
            using (FoodMonkeyEntities db = new FoodMonkeyEntities())
            {
                var data = (from us in db.announcements
                            where us.ann_id == a.ann_id
                            select us).FirstOrDefault();

                db.announcements.Remove(data);
                db.SaveChanges();

                return RedirectToAction("Announcement");
            };
        }

        public ActionResult SendAnnoucement()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendAnnoucement(announcement a)
        {
            if (ModelState.IsValid)
            {
                FoodMonkeyEntities db = new FoodMonkeyEntities();
                db.announcements.Add(a);
                db.SaveChanges();

                return RedirectToAction("Announcement");
            }

            return View();

        }

    }
}