using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        // GET: Person
        public ActionResult PersonalDetailes()
        {
            List<string> Option = new List<string>();
            Option.Add("choose an Option ");
            Option.Add("Yes");
            Option.Add("No");
            ViewData["Option"] = new SelectList(Option);
            return View();
        }
        [HttpPost]
        public ActionResult PersonalDetailes(FormCollection fc,ICollection<string> hobbies)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.Option = fc["Option"];
            return View("Details");
        }
    }
}