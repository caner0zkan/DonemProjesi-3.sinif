using DonemProjesi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DonemProjesi.Controllers
{
    public class ForumController : Controller
    {
        private OgrenciContext db = new OgrenciContext();

        // GET: Forum
        public ActionResult Index()
        {
            //Include(o => o.Ogrenci) -- öğrenci bilgilerini dahil ediyoruz
            return View(db.Projeler.Include(o => o.Ogrenci).ToList());
        }

        [HttpPost]
        public ActionResult Index(string dsd)
        {
            return View();
        }
    }
}