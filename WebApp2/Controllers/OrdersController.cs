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
    public class OrdersController : Controller
    {

        // GET: Orders
        public ActionResult Index()
        {
            return View(XmlWorks3.Orders);
        }

        // GET: Orders/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = XmlWorks3.Orders.First(item => item.Id == id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Customer,Regdate,Value,Status")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.Id = (XmlWorks3.Orders.Max(item => int.Parse(item.Id)) + 1).ToString();
                order.Regdate = SimpleDateConverter.ConvertBack(order.Regdate);
                XmlWorks3.Orders.Add(order);
                return RedirectToAction("Index");
            }

            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = XmlWorks3.Orders.First(item => item.Id == id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Customer,Regdate,Value,Status")] Order order)
        {
            if (ModelState.IsValid)
            {
                var neededordr = XmlWorks3.Orders.First(item => item.Id == order.Id);
                neededordr.Customer = order.Customer;
                neededordr.Value = order.Value;
                neededordr.Status = order.Status;
                neededordr.Regdate = SimpleDateConverter.ConvertBack(order.Regdate);
                return RedirectToAction("Index");
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = XmlWorks3.Orders.First(item => item.Id == id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Order order = XmlWorks3.Orders.First(item => item.Id == id);
            XmlWorks3.Orders.Remove(order);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                
            }
            base.Dispose(disposing);
        }
    }
}
