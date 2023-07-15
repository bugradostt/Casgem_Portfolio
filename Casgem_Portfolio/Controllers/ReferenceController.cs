using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    [Authorize]
    public class ReferenceController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        public ActionResult Index()
        {
            var values = db.TblReference.OrderByDescending(x => x.ReferenceId).ToList();
            return View(values);
        }

        public ActionResult DeleteReference(int id)
        {
            var foundId = db.TblReference.Find(id);
            db.TblReference.Remove(foundId);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddReference()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddReference(TblReference p)
        {
            db.TblReference.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditReference(int id)
        {
            var foundId = db.TblReference.Find(id);
            return View(foundId);
        }

        [HttpPost]
        public ActionResult EditReference(TblReference p)
        {
            var foundId = db.TblReference.Find(p.ReferenceId);
            foundId.ReferenceBusinessName = p.ReferenceBusinessName;
            foundId.ReferenceDescription = p.ReferenceDescription;
            foundId.ReferenceImgUrl = p.ReferenceImgUrl;
            foundId.ReferenceNameSurname = p.ReferenceNameSurname;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}