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
    public class ConferenceRoomInfoController : Controller
    {
        private CRBSystemContext db = new CRBSystemContext();

        // GET: ConferenceRoomInfo
        public ActionResult Index()
        {
            var conferenceRoomInfoModels = db.ConferenceRoomInfoModels.Include(c => c.PropertyTypeInfo).Include(c => c.RoomType);
            return View(conferenceRoomInfoModels.ToList());
        }

        // GET: ConferenceRoomInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceRoomInfoModels conferenceRoomInfoModels = db.ConferenceRoomInfoModels.Find(id);
            if (conferenceRoomInfoModels == null)
            {
                return HttpNotFound();
            }
            return View(conferenceRoomInfoModels);
        }

        // GET: ConferenceRoomInfo/Create
        public ActionResult Create()
        {
            ViewBag.PropertyPurposeId = new SelectList(db.PropertyTypeInfo, "PropertyPurposeId", "PropertyPurposeName");
            ViewBag.RoomTypeId = new SelectList(db.RoomType, "RoomTypeId", "RoomTypeName");
            return View();
        }

        // POST: ConferenceRoomInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PropertyId,PropertyName,PersonCapacity,PropertyPurposeId,RoomTypeId,FairAmount")] ConferenceRoomInfoModels conferenceRoomInfoModels)
        {
            if (ModelState.IsValid)
            {
                db.ConferenceRoomInfoModels.Add(conferenceRoomInfoModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PropertyPurposeId = new SelectList(db.PropertyTypeInfo, "PropertyPurposeId", "PropertyPurposeName", conferenceRoomInfoModels.PropertyPurposeId);
            ViewBag.RoomTypeId = new SelectList(db.RoomType, "RoomTypeId", "RoomTypeName", conferenceRoomInfoModels.RoomTypeId);
            return View(conferenceRoomInfoModels);
        }

        // GET: ConferenceRoomInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceRoomInfoModels conferenceRoomInfoModels = db.ConferenceRoomInfoModels.Find(id);
            if (conferenceRoomInfoModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.PropertyPurposeId = new SelectList(db.PropertyTypeInfo, "PropertyPurposeId", "PropertyPurposeName", conferenceRoomInfoModels.PropertyPurposeId);
            ViewBag.RoomTypeId = new SelectList(db.RoomType, "RoomTypeId", "RoomTypeName", conferenceRoomInfoModels.RoomTypeId);
            return View(conferenceRoomInfoModels);
        }

        // POST: ConferenceRoomInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PropertyId,PropertyName,PersonCapacity,PropertyPurposeId,RoomTypeId,FairAmount")] ConferenceRoomInfoModels conferenceRoomInfoModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conferenceRoomInfoModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PropertyPurposeId = new SelectList(db.PropertyTypeInfo, "PropertyPurposeId", "PropertyPurposeName", conferenceRoomInfoModels.PropertyPurposeId);
            ViewBag.RoomTypeId = new SelectList(db.RoomType, "RoomTypeId", "RoomTypeName", conferenceRoomInfoModels.RoomTypeId);
            return View(conferenceRoomInfoModels);
        }

        // GET: ConferenceRoomInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceRoomInfoModels conferenceRoomInfoModels = db.ConferenceRoomInfoModels.Find(id);
            if (conferenceRoomInfoModels == null)
            {
                return HttpNotFound();
            }
            return View(conferenceRoomInfoModels);
        }

        // POST: ConferenceRoomInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConferenceRoomInfoModels conferenceRoomInfoModels = db.ConferenceRoomInfoModels.Find(id);
            db.ConferenceRoomInfoModels.Remove(conferenceRoomInfoModels);
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
