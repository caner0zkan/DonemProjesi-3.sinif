using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DonemProjesi.Models;

namespace DonemProjesi.Controllers
{
    public class BasvuruController : Controller
    {
        private OgrenciContext db = new OgrenciContext();

        // GET: Basvuru
        public ActionResult Index()
        {
            return View(db.Basvurular.ToList());
        }

        // GET: Basvuru/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basvuru basvuru = db.Basvurular.Find(id);
            if (basvuru == null)
            {
                return HttpNotFound();
            }
            return View(basvuru);
        }

        // GET: Basvuru/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Basvuru/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BasvuruID,ProjeSahibimi,KabulEdildimi")] Basvuru basvuru)
        {
            if (ModelState.IsValid)
            {
                db.Basvurular.Add(basvuru);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(basvuru);
        }

        // GET: Basvuru/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basvuru basvuru = db.Basvurular.Find(id);
            if (basvuru == null)
            {
                return HttpNotFound();
            }
            return View(basvuru);
        }

        // POST: Basvuru/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BasvuruID,ProjeSahibimi,KabulEdildimi")] Basvuru basvuru)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basvuru).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(basvuru);
        }

        // GET: Basvuru/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basvuru basvuru = db.Basvurular.Find(id);
            if (basvuru == null)
            {
                return HttpNotFound();
            }
            return View(basvuru);
        }

        // POST: Basvuru/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Basvuru basvuru = db.Basvurular.Find(id);
            db.Basvurular.Remove(basvuru);
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
