using MegaMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MegaMenu.Controllers
{
    public class HomeController : Controller
    {
        private MegaMenuDbContext db = new MegaMenuDbContext();
        public ActionResult Index()
        {
            var ListMenuParent = db.Categories.Where(c => c.ParentId == 0).ToList();
            return View(ListMenuParent);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public PartialViewResult LoadMenu()
        {
            var ListMenuParent = db.Categories.Where(c => c.ParentId == 0).ToList();
            return PartialView("_Menu", ListMenuParent);
        }

        public ActionResult LoadChild(int? parentId)
        {
            if (parentId == null)
            {         
                return View("Index");
            }
            var ListMenuChild = db.Categories.Where(c => c.ParentId == parentId).ToList();

            return PartialView("LoadChild", ListMenuChild);
        }
    }
}