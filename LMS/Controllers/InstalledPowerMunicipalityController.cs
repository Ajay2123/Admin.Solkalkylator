using LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    [Authorize]
    public class InstalledPowerMunicipalityController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // List - List all records
        public ActionResult Index()
        {
            return View(db.InstalledPowerMunicipality.ToList());
        }


        // Details - View Specific record
        public ActionResult Details(int? id)
        {
            if (id == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InstalledPowerMunicipality record = db.InstalledPowerMunicipality.Find(id);
            if (record == null)
            {
                return HttpNotFound();
            }
            return View(record);
        }

        // Create - Create a record
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Kommun,BaseInstalledPower,Inhabitants")] InstalledPowerMunicipality record)
        {
            if (ModelState.IsValid)
            {
                db.InstalledPowerMunicipality.Add(record);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        // Edit - update a record
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InstalledPowerMunicipality record = db.InstalledPowerMunicipality.Find(id);
            if (record == null)
            {
                return HttpNotFound();
            }
            return View(record);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Kommun,BaseInstalledPower,Inhabitants")] InstalledPowerMunicipality record)
        {
            if (ModelState.IsValid)
            {
                db.Entry(record).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(record);
        }

        // Detele - Delete a record
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InstalledPowerMunicipality record = db.InstalledPowerMunicipality.Find(id);
            if (record == null)
            {
                return HttpNotFound();
            }
            return View(record);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InstalledPowerMunicipality record = db.InstalledPowerMunicipality.Find(id);
            db.InstalledPowerMunicipality.Remove(record);
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