using DonemProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace DonemProjesi.Controllers
{

    public class HomeController : Controller
    {
        private OgrenciContext context = new OgrenciContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
            //return View(context.Ogrenciler.ToList());
        }
    }
}