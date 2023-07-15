using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class ContactController : Controller
    {

        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
           // var values = db.TblContact.ToList();
            ViewBag.phone = db.TblContact.Select(x => x.ContactTel).FirstOrDefault();
            ViewBag.mail = db.TblContact.Select(x => x.ContactMail).FirstOrDefault();
            ViewBag.adress = db.TblContact.Select(x => x.ContactAdress).FirstOrDefault();
            ViewBag.maps = db.TblContact.Select(x => x.ContactMaps).FirstOrDefault();
            return View();
        }


        [HttpPost]
        public ActionResult Index(TblMessage p)
        {
            db.TblMessage.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}