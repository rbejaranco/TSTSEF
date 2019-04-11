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
    public class AgressorsController : Controller
    {
        private AgressorsDb db = new AgressorsDb();

        // GET: Agressors
        public ActionResult Index()
        {
            return View(db.Agressors.ToList());
        }

        // GET: Agressors
        public ActionResult FindAgressors(String aggresor)
        {
            var model = from a in db.Agressors
                     where a.AgressorName.StartsWith(aggresor)
                     orderby a.AgressorName
                     select a;
            return PartialView("_Agressors", model);

        }

        // GET: Agressors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agressor agressor = db.Agressors.Find(id);
            if (agressor == null)
            {
                return HttpNotFound();
            }
            return View(agressor);
        }

        // GET: Agressors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agressors/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgressorId,AgressorName")] Agressor agressor)
        {
            if (ModelState.IsValid)
            {
                db.Agressors.Add(agressor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agressor);
        }

        // GET: Agressors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agressor agressor = db.Agressors.Find(id);
            if (agressor == null)
            {
                return HttpNotFound();
            }
            return View(agressor);
        }

        // POST: Agressors/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgressorId,AgressorName")] Agressor agressor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agressor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agressor);
        }

        // GET: Agressors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agressor agressor = db.Agressors.Find(id);
            if (agressor == null)
            {
                return HttpNotFound();
            }
            return View(agressor);
        }

        // POST: Agressors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Agressor agressor = db.Agressors.Find(id);
            db.Agressors.Remove(agressor);
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
