using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DonemProjesi.Models;

namespace DonemProjesi.Controllers
{
    public class SecurityController : Controller
    {
        OgrenciContext db = new OgrenciContext();
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Ogrenci ogrenci)
        {
            var kullanici = db.Ogrenciler.FirstOrDefault(x=>x.OgrenciNumarasi == ogrenci.OgrenciNumarasi && x.Sifre == ogrenci.Sifre);
            if (kullanici!=null)
            {
                FormsAuthentication.SetAuthCookie(kullanici.Ad, false);
                return RedirectToAction("Details","Ogrenci", new {@id=kullanici.OgrenciID });
            }
            else
            {
                ViewBag.Mesaj = "Geçersiz numara veya şifre girdiniz!";
                return View();
            }

        }
    }
}