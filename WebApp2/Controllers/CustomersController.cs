using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp2.Data;
using WebApp2.Models;
using WebApp2.Tools;

namespace WebApp2.Controllers
{
    public class CustomersController : Controller
    {
        private WebApp2Context db = new WebApp2Context();

        // GET: Customers
        public ActionResult Index()
        {
            return View(XmlWorks3.Customers);
        }

        // GET: Customers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = XmlWorks3.Customers.First(item => item.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Birdate,Regdate,Email,Phone")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.Id = (XmlWorks3.Customers.Max(item => int.Parse(item.Id)) + 1).ToString();
                XmlWorks3.Customers.Add(customer);
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = XmlWorks3.Customers.First(item => item.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Birdate,Regdate,Email,Phone")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var neededcstmr = XmlWorks3.Customers.First(item => item.Id == customer.Id);
                neededcstmr.Name = customer.Name;
                neededcstmr.Phone = customer.Phone;
                neededcstmr.Email = customer.Email;
                neededcstmr.Birdate = SimpleDateConverter.ConvertBack(customer.Birdate);
                neededcstmr.Regdate = SimpleDateConverter.ConvertBack(customer.Regdate);
                System.Diagnostics.Debug.WriteLine(XmlWorks3.Customers[0].Regdate);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = XmlWorks3.Customers.First(item => item.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Customer customer = XmlWorks3.Customers.First(item => item.Id == id);
            XmlWorks3.Customers.Remove(customer);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
