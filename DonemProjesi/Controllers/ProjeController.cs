using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DonemProjesi.Models;
using System.Web.Security;

namespace DonemProjesi.Controllers
{
    public class ProjeController : Controller
    {
        private OgrenciContext db = new OgrenciContext();

        // GET: Proje
        public ActionResult Index()
        {
            return View(db.Projeler.ToList());
        }

        // GET: Proje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proje proje = db.Projeler.Find(id);
            if (proje == null)
            {
                return HttpNotFound();
            }
            return View(proje);
        }

        // GET: Proje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjeID,ProjeAdi,Aciklama,EklenmeTarihi,OgrenciID")] Proje proje)
        {
            if (ModelState.IsValid)
            {
                proje.EklenmeTarihi = DateTime.Now;
                proje.OgrenciID = (int)Session["OgrenciID"];    //projeyi oluşturacak kullanıcının ID'si foreign key olarak atanıyor 
                
                db.Projeler.Add(proje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proje);
        }

        // GET: Proje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proje proje = db.Projeler.Find(id);
            if (proje == null)
            {
                return HttpNotFound();
            }
            return View(proje);
        }

        // POST: Proje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjeID,ProjeAdi,Aciklama,EklenmeTarihi")] Proje proje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proje);
        }

        // GET: Proje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proje proje = db.Projeler.Find(id);
            if (proje == null)
            {
                return HttpNotFound();
            }
            return View(proje);
        }

        // POST: Proje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proje proje = db.Projeler.Find(id);
            db.Projeler.Remove(proje);
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
