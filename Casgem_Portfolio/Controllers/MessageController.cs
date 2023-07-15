using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblMessage.OrderByDescending(x => x.MessageId).ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var foundId = db.TblMessage.Find(id);
            db.TblMessage.Remove(foundId);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DetailsMessage(int id)
        {
            var value = db.TblMessage.Find(id);
            return View(value);
        }

    }
}