using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TSTSEF.Models;

namespace TSTSEF.Controllers
{
    public class RelativesController : Controller
    {
        private AgressorsDb db = new AgressorsDb();

        // GET: Relatives
        /// <summary>
        /// Get all Agressors relatives
        /// </summary>
        /// <param name="AgressorId">Agressor's Id</param>
        /// <returns>Index vies of all relatives</returns>
        public ActionResult Index(int AgressorId)
        {
            var model = from r in db.Relatives
                         where r.AgressorId == AgressorId
                        orderby r.Name
                         select r;



            return View(model);
        }

        // GET: Relatives/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relative relative = db.Relatives.Find(id);
            if (relative == null)
            {
                return HttpNotFound();
            }
            return View(relative);
        }

        // GET: Relatives/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Relatives/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Relation,Active,Created,Modified,AgressorId")] Relative relative)
        {
            if (ModelState.IsValid)
            {
                db.Relatives.Add(relative);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relative);
        }

        // GET: Relatives/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relative relative = db.Relatives.Find(id);
            if (relative == null)
            {
                return HttpNotFound();
            }
            return View(relative);
        }

        // POST: Relatives/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Relation,Active,Created,Modified,AgressorId")] Relative relative)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relative).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relative);
        }

        // GET: Relatives/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relative relative = db.Relatives.Find(id);
            if (relative == null)
            {
                return HttpNotFound();
            }
            return View(relative);
        }

        // POST: Relatives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Relative relative = db.Relatives.Find(id);
            db.Relatives.Remove(relative);
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
