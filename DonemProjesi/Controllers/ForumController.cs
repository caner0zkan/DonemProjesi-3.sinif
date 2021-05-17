using DonemProjesi.Models;
using System;
using System.Collections.Generic;
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
            return View(db.Projeler.ToList());
        }
    }
}