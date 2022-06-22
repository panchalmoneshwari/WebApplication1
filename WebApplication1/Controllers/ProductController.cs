using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult GetAllProduct()
        {
            List<Product> productlist = new List<Product>() {
                new Product{ Id=101,Name="Laptop",Company="Dell",Price=75000},
                new Product{ Id=102,Name="Mobile",Company="Samsung",Price=3500},
                new Product{ Id=103,Name="Tab",Company="Vivo",Price=35000},
                new Product{ Id=104,Name="Keypad",Company="Dell",Price=300},
                new Product{ Id=105,Name="Laptop",Company="Lenovo",Price=35000}
            };
            ViewBag.ProductList = productlist;
            return View();
        }
        
    }
}