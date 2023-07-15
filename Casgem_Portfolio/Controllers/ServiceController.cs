using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class ServiceController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblService.OrderByDescending(x => x.ServiceId).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(TblService p)
        {
            db.TblService.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteService(int id)
        {
            var foundId = db.TblService.Find(id);
            db.TblService.Remove(foundId);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditService(int id)
        {
            var foundId = db.TblService.Find(id);
            return View(foundId);
        }

        [HttpPost]
        public ActionResult EditService(TblService p)
        {
            var foundId = db.TblService.Find(p.ServiceId);
            foundId.ServiceTitle = p.ServiceTitle;
            foundId.ServiceIcon = p.ServiceIcon;
            foundId.ServiceNumber = p.ServiceNumber;
            foundId.ServiceContent = p.ServiceContent;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}