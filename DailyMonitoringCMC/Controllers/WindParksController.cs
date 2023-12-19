using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DailyMonitoringCMC.Models;

namespace DailyMonitoringCMC.Controllers
{
    public class WindParksController : Controller
    {
        private DailyMonitoringCMCContext db = new DailyMonitoringCMCContext();

        // GET: WindParks
        public ActionResult Index()
        {
           var windPark = db.WindPark.ToList();
            return View(windPark.ToList());
        }

        // GET: WindParks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WindPark windPark = db.WindPark.Find(id);
            if (windPark == null)
            {
                return HttpNotFound();
            }
            return View(windPark);
        }

        // GET: WindParks/Create
        public ActionResult Create()
        {
            //ViewBag.ConnectionControlID = new SelectList(db.ConnectionControl, "ConnectionControlID", "ConnectionStatus");
            return View();
        }

        // POST: WindParks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WindParkID,WindParkName,CreatedOn,ModifiedOn,CreatedBy,ModifiedBy,Message,ConnectionControlID")] WindPark windPark)
        {
            if (ModelState.IsValid)
            {
                windPark.CreatedBy = User.Identity.Name;
                windPark.CreatedOn = DateTime.Now;
                windPark.ModifiedBy = User.Identity.Name;
                windPark.ModifiedOn = DateTime.Now;
                db.WindPark.Add(windPark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.ConnectionControlID = new SelectList(db.ConnectionControl, "ConnectionControlID", "ConnectionStatus", windPark.ConnectionControlID);
            return View(windPark);
        }

        // GET: WindParks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WindPark windPark = db.WindPark.Find(id);
            if (windPark == null)
            {
                return HttpNotFound();
            }
            //ViewBag.ConnectionControlID = new SelectList(db.ConnectionControl, "ConnectionControlID", "ConnectionStatus", windPark.ConnectionControlID);
            return View(windPark);
        }

        // POST: WindParks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WindParkID,WindParkName,CreatedOn,ModifiedOn,CreatedBy,ModifiedBy,Message,ConnectionControlID")] WindPark windPark)
        {
            if (ModelState.IsValid)
            {
                var original = db.WindPark.Find(windPark.WindParkID);
                bool changed = original.WindParkName != windPark.WindParkName || original.Message != windPark.Message;
                if(changed)
                {
                    original.Message = windPark.Message;
                    original.WindParkName = windPark.WindParkName;
                    original.ModifiedOn = DateTime.Now;
                    original.ModifiedBy = User.Identity.Name;
                    db.Entry(original).State = EntityState.Modified;
                    db.Entry(original).Property("CreatedOn").IsModified = false;
                    db.Entry(original).Property("CreatedBy").IsModified = false;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
           // ViewBag.ConnectionControlID = new SelectList(db.ConnectionControl, "ConnectionControlID", "ConnectionStatus", windPark.ConnectionControlID);
            return View(windPark);
        }

        // GET: WindParks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WindPark windPark = db.WindPark.Find(id);
            if (windPark == null)
            {
                return HttpNotFound();
            }
            return View(windPark);
        }

        // POST: WindParks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WindPark windPark = db.WindPark.Find(id);
            db.WindPark.Remove(windPark);
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
