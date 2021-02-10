using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp2.Models;
using WebApp2.Tools;
using Microsoft.AspNetCore.Identity;

namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewModel vm = new ViewModel();
            vm.Customers = new List<Customer>();
            vm.Customers.AddRange(XmlWorks3.Customers);
            vm.Orders = new List<Order>();
            vm.Orders.AddRange(XmlWorks3.Orders);
            return View(vm);
        }

        public ActionResult Create([Bind(Include = "Id,Name,Author,Year")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                //create user
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}