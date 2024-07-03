using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ApplicationName = "";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.ApplicationName = "Description";
            ViewBag.Message = "In this site, you can enter the name and surname of your loved one according to their activity";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.ApplicationName = "Demetre natidze";
            ViewBag.Message = "Tel - 568600614";
            return View();
        }

        public ActionResult FamilyMembers()
        {
            ViewBag.ApplicationName = "ოჯახის წევრები";
            ViewBag.Message = "აქ შეგიძლიათ ნახოთ ოჯახის წევრების სია";
            return View();
        }
    }
}