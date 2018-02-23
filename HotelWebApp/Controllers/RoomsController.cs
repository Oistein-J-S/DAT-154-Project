using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HotelWebApp.Models;

namespace HotelWebApp.Controllers
{
    public class RoomsController : Controller
    {
        private dat154vaar18Entities db = new dat154vaar18Entities();

        // GET: Rooms
        public ActionResult Index()
        {
            var rooms = db.Rooms.Include(r => r.Booking).Include(r => r.Issue).Include(r => r.Standard).Include(r => r.Suite).Include(r => r.Superior);
            return View(rooms.ToList());
        }

        // GET: Rooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Room room = db.Rooms.Find(id);
            if (room == null)
            {
                return HttpNotFound();
            }
            return View(room);
        }

        // GET: Rooms/Create
        public ActionResult Create()
        {
            ViewBag.Bookings = new SelectList(db.Bookings, "BookingId", "BookingId");
            ViewBag.Issues = new SelectList(db.Issues, "Id", "Description");
            ViewBag.Roomnumber = new SelectList(db.Standards, "rNumber", "rNumber");
            ViewBag.Roomnumber = new SelectList(db.Suites, "rNumber", "rNumber");
            ViewBag.Roomnumber = new SelectList(db.Superiors, "rNumber", "rNumber");
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Roomnumber,BedCount,Bookings,Issues,LastCleaned")] Room room)
        {
            if (ModelState.IsValid)
            {
                db.Rooms.Add(room);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Bookings = new SelectList(db.Bookings, "BookingId", "BookingId", room.Bookings);
            ViewBag.Issues = new SelectList(db.Issues, "Id", "Description", room.Issues);
            ViewBag.Roomnumber = new SelectList(db.Standards, "rNumber", "rNumber", room.Roomnumber);
            ViewBag.Roomnumber = new SelectList(db.Suites, "rNumber", "rNumber", room.Roomnumber);
            ViewBag.Roomnumber = new SelectList(db.Superiors, "rNumber", "rNumber", room.Roomnumber);
            return View(room);
        }

        // GET: Rooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Room room = db.Rooms.Find(id);
            if (room == null)
            {
                return HttpNotFound();
            }
            ViewBag.Bookings = new SelectList(db.Bookings, "BookingId", "BookingId", room.Bookings);
            ViewBag.Issues = new SelectList(db.Issues, "Id", "Description", room.Issues);
            ViewBag.Roomnumber = new SelectList(db.Standards, "rNumber", "rNumber", room.Roomnumber);
            ViewBag.Roomnumber = new SelectList(db.Suites, "rNumber", "rNumber", room.Roomnumber);
            ViewBag.Roomnumber = new SelectList(db.Superiors, "rNumber", "rNumber", room.Roomnumber);
            return View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Roomnumber,BedCount,Bookings,Issues,LastCleaned")] Room room)
        {
            if (ModelState.IsValid)
            {
                db.Entry(room).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Bookings = new SelectList(db.Bookings, "BookingId", "BookingId", room.Bookings);
            ViewBag.Issues = new SelectList(db.Issues, "Id", "Description", room.Issues);
            ViewBag.Roomnumber = new SelectList(db.Standards, "rNumber", "rNumber", room.Roomnumber);
            ViewBag.Roomnumber = new SelectList(db.Suites, "rNumber", "rNumber", room.Roomnumber);
            ViewBag.Roomnumber = new SelectList(db.Superiors, "rNumber", "rNumber", room.Roomnumber);
            return View(room);
        }

        // GET: Rooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Room room = db.Rooms.Find(id);
            if (room == null)
            {
                return HttpNotFound();
            }
            return View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Room room = db.Rooms.Find(id);
            db.Rooms.Remove(room);
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
