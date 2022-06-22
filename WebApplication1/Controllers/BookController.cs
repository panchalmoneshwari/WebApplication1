using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            return View();
        }
    }
}