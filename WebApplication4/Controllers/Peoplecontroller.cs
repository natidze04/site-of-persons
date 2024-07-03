// Controllers/PeopleController.cs
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class PeopleController : Controller
    {
        private static List<Actor> actors = new List<Actor>();
        private static List<Singer> singers = new List<Singer>();
        private static List<Footballer> footballers = new List<Footballer>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Actors()
        {
            return View(actors);
        }

        public ActionResult Singers()
        {
            return View(singers);
        }

        public ActionResult Footballers()
        {
            return View(footballers);
        }

        [HttpPost]
        public ActionResult AddActor(Actor actor)
        {
            actors.Add(actor);
            return RedirectToAction("Actors");
        }

        [HttpPost]
        public ActionResult AddSinger(Singer singer)
        {
            singers.Add(singer);
            return RedirectToAction("Singers");
        }

        [HttpPost]
        public ActionResult AddFootballer(Footballer footballer)
        {
            footballers.Add(footballer);
            return RedirectToAction("Footballers");
        }
    }
}
