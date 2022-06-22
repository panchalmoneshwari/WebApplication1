using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetAllEmployee()
        {
            List<Employee> employeelist = new List<Employee>() {
                new Employee{ Id=1,Name="Mr.Sarma",Location="MUMBAI",Salary=60000},
                new Employee{ Id=1,Name="Miss.Salini",Location="DUBAI",Salary=80000},
                new Employee{ Id=1,Name="Mr.Narayana",Location="Pune",Salary=60000},
                new Employee{ Id=1,Name="Miss.Bhave",Location="Noida",Salary=50000},
                new Employee{ Id=1,Name="Mr.Sarava",Location="Mohali",Salary=60000},
            };
            ViewBag.EmployeeList = employeelist;
        
            return View();
        }
        [HttpGet]
        public ActionResult EmployeeDetails()
        {
            List<string> Option = new List<string>();
            Option.Add("choose an Option ");
            Option.Add("Java");
            Option.Add("C#");
            ViewData["Option"] = new SelectList(Option);
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeDetails(FormCollection fc, ICollection<string> hobbies)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.designation = fc["designation"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.Option = fc["Option"];
            return View("Detailss");
        }
    }
}