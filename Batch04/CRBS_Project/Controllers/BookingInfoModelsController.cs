using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRBS_Project.Models;
using CRBS_Project.Repository;

namespace CRBS_Project.Controllers
{
    public class BookingInfoModelsController : Controller
    {
        private CRBSystemContext db = new CRBSystemContext();

        // GET: BookingInfoModels
        public ActionResult Index()
        {
            var bookingInfoModels = db.BookingInfoModels.Include(b => b.ConferenceRoomInfoModels);
            return View(bookingInfoModels.ToList());
        }

        // GET: BookingInfoModels/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingInfoModels bookingInfoModels = db.BookingInfoModels.Find(id);
            if (bookingInfoModels == null)
            {
                return HttpNotFound();
            }
            return View(bookingInfoModels);
        }

        // GET: BookingInfoModels/Create
        public ActionResult Create()
        {
            ViewBag.PropertyId = new SelectList(db.ConferenceRoomInfoModels, "PropertyId", "PropertyName");
            return View();
        }

        // POST: BookingInfoModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookingId,PropertyId,UserId,BookingDate,FromTime,ToTime,BookingStatus,StatusName")] BookingInfoModels bookingInfoModels)
        {
            if (ModelState.IsValid)
            {
                db.BookingInfoModels.Add(bookingInfoModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PropertyId = new SelectList(db.ConferenceRoomInfoModels, "PropertyId", "PropertyName", bookingInfoModels.PropertyId);
            return View(bookingInfoModels);
        }

        // GET: BookingInfoModels/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingInfoModels bookingInfoModels = db.BookingInfoModels.Find(id);
            if (bookingInfoModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.PropertyId = new SelectList(db.ConferenceRoomInfoModels, "PropertyId", "PropertyName", bookingInfoModels.PropertyId);
            return View(bookingInfoModels);
        }

        // POST: BookingInfoModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookingId,PropertyId,UserId,BookingDate,FromTime,ToTime,BookingStatus,StatusName")] BookingInfoModels bookingInfoModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookingInfoModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PropertyId = new SelectList(db.ConferenceRoomInfoModels, "PropertyId", "PropertyName", bookingInfoModels.PropertyId);
            return View(bookingInfoModels);
        }

        // GET: BookingInfoModels/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingInfoModels bookingInfoModels = db.BookingInfoModels.Find(id);
            if (bookingInfoModels == null)
            {
                return HttpNotFound();
            }
            return View(bookingInfoModels);
        }

        // POST: BookingInfoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BookingInfoModels bookingInfoModels = db.BookingInfoModels.Find(id);
            db.BookingInfoModels.Remove(bookingInfoModels);
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
