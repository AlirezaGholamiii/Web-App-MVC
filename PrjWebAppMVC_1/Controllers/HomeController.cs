using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjWebAppMVC_1.Models;

namespace PrjWebAppMVC_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          
            return View();

        }

        public ActionResult ListEmployees()
        {
            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(new Employee { Employeeid = 001, FirstName = "Kasra", LastName = "Gholami", Email = "Kasragholami92@gmail.com" });
            listEmployee.Add(new Employee { Employeeid = 002, FirstName = "Kimia", LastName = "Gholami", Email = "kimia@gmail.com" });
            listEmployee.Add(new Employee { Employeeid = 003, FirstName = "Mojtaba", LastName = "Gholami", Email = "mojtaba@gmail.com" });
            listEmployee.Add(new Employee { Employeeid = 004, FirstName = "Mehrnoosh", LastName = "Azbahani", Email = "mehrnoosh@gmail.com" });
            return View(listEmployee);

        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}