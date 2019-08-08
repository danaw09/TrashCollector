using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;
using TrashColllector.Models;

namespace TrashColllector.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<State> StateList { get; private set; }

        [Authorize(Roles = RoleName.Employee)]
        public ActionResult Details(string id)
        {
            var Customer = db.customers
                .Include(c => c.Streetaddress)
                .Include(c => c.WeeklyPickUpDay)
                .Single(c => c.UserId == id);

            return View(Customer);
        }
        // GET: Customer
        [Authorize]
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.Employee))
            {
                var customers = db.customers
                    .Include(c => c.Streetaddress)
                    .Include(c => c.WeeklyPickUpDay)
                    .ToList();
                return View(customers);
            }

            return RedirectToAction("Edit", "Customer", new { id = User.Identity.GetUserId() });
        }

        // GET: Customer/Edit/5
        [Authorize]
        public ActionResult Edit(string id)
        {
            if (!User.IsInRole(RoleName.Employee))
            {
                id = User.Identity.GetUserId();
            }

            var customerInDb = db.customers
                .Include(c => c.Address)
                .Include(c => c.WeeklyPickUpDay)
                .Single(c => c.UserId == id);


            return View(ViewBag);
        }


        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,phone,firstname,LastName,Streetaddress,addressId,WeeklyPickUpDay,postalCode,bill,city,state")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,phone,firstname,LastName,Streetaddress,addressId,WeeklyPickUpDay,postalCode,bill,city,state")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
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
            Customer customer = db.customers.Find(id);
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
            Customer customer = db.customers.Find(id);
            db.customers.Remove(customer);
            db.SaveChanges();
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
