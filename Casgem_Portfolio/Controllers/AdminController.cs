using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class AdminController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        // GET: Admin
        public ActionResult Contact()
        {
            ViewBag.phone = db.TblContact.Select(x => x.ContactTel).FirstOrDefault();
            ViewBag.mail = db.TblContact.Select(x => x.ContactMail).FirstOrDefault();
            ViewBag.adress = db.TblContact.Select(x => x.ContactAdress).FirstOrDefault();
            ViewBag.maps = db.TblContact.Select(x => x.ContactMaps).FirstOrDefault();
            return View();
        }

        [HttpGet]
        public ActionResult EditContact()
        {
            var foundId = db.TblContact.Find(1);
            return View(foundId);

        }

        [HttpPost]
        public ActionResult EditContact(TblContact p)
        {
            var foundId = db.TblContact.Find(1);
            foundId.ContactAdress = p.ContactAdress;
            foundId.ContactMail = p.ContactMail;
            foundId.ContactMaps = p.ContactMaps;
            foundId.ContactTel = p.ContactTel;
            db.SaveChanges();
            return RedirectToAction("Contact");

        }


        public ActionResult WhoAmI()
        {
            ViewBag.titlee = db.TblWhoAmI.Select(x => x.WhoAmITitle).FirstOrDefault();
            ViewBag.jobs = db.TblWhoAmI.Select(x => x.WhoAmIJobs).FirstOrDefault();
            ViewBag.img = db.TblWhoAmI.Select(x => x.WhoAmIImgUrl).FirstOrDefault();
            ViewBag.des = db.TblWhoAmI.Select(x => x.WhoAmIDescription).FirstOrDefault();
            return View();
        }

        [HttpGet]
        public ActionResult EditWhoAmI()
        {
            var foundId = db.TblWhoAmI.Find(1);
            return View(foundId);

        }

        [HttpPost]
        public ActionResult EditWhoAmI(TblWhoAmI p)
        {
            var foundId = db.TblWhoAmI.Find(1);
            foundId.WhoAmIDescription = p.WhoAmIDescription;
            foundId.WhoAmIImgUrl = p.WhoAmIImgUrl;
            foundId.WhoAmIJobs = p.WhoAmIJobs;
            foundId.WhoAmITitle = p.WhoAmITitle;
            db.SaveChanges();
            return RedirectToAction("WhoAmI");

        }

        public ActionResult Feature()
        {
            ViewBag.featureDescription = db.TblFeature.Select(x => x.FeatureDescription).FirstOrDefault();
            ViewBag.featureIJobs = db.TblFeature.Select(x => x.FeatureIJobs).FirstOrDefault();
            ViewBag.featureImageUrl = db.TblFeature.Select(x => x.FeatureImageUrl).FirstOrDefault();
            ViewBag.featureTitle = db.TblFeature.Select(x => x.FeatureTitle).FirstOrDefault();
            return View();
        }

        [HttpGet]
        public ActionResult EditFeature()
        {
            var foundId = db.TblFeature.Find(1);
            return View(foundId);

        }

        [HttpPost]
        public ActionResult EditFeature(TblFeature p)
        {
            var foundId = db.TblFeature.Find(1);
            foundId.FeatureTitle = p.FeatureTitle;
            foundId.FeatureImageUrl = p.FeatureImageUrl;
            foundId.FeatureIJobs = p.FeatureIJobs;
            foundId.FeatureDescription = p.FeatureDescription;
            db.SaveChanges();
            return RedirectToAction("Feature");

        }

        public ActionResult AdminList()
        {
            var values = db.TblAdmin.OrderByDescending(x => x.AdminId).ToList();

            return View(values);
        }

        public ActionResult DeleteAdmin(int id)
        {
            var foundId = db.TblAdmin.Find(id);
            db.TblAdmin.Remove(foundId);
            db.SaveChanges();
            return RedirectToAction("AdminList");
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(TblAdmin p)
        {
            db.TblAdmin.Add(p);
            db.SaveChanges();
            return RedirectToAction("AdminList");
        }

        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var value = db.TblAdmin.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult EditAdmin(TblAdmin p)
        {
            var foundId= db.TblAdmin.Find(p.AdminId);
            foundId.AdminName = p.AdminName;
            foundId.AdminPassword = p.AdminPassword;
            foundId.AdminUserName = p.AdminUserName;
            db.SaveChanges();
            return RedirectToAction("AdminList");
        }


        public ActionResult SocialMedia()
        {
            var values = db.TblSocialMedia.OrderByDescending(x => x.SocialMediaId).ToList();
            return View(values);
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var foundId = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(foundId);
            db.SaveChanges();
            return RedirectToAction("SocialMedia");
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSocialMedia(TblSocialMedia p)
        {

            db.TblSocialMedia.Add(p);
            db.SaveChanges();
            return RedirectToAction("SocialMedia");
        }

        [HttpGet]
        public ActionResult EditSocialMedia(int id)
        {
            var foundId = db.TblSocialMedia.Find(id);
            return View(foundId);
        }

        [HttpPost]
        public ActionResult EditSocialMedia(TblSocialMedia p)
        {

            var foundId = db.TblSocialMedia.Find(p.SocialMediaId);
            foundId.SocialMediaName = p.SocialMediaName;
            foundId.SocialMediaUrl= p.SocialMediaUrl;
            db.SaveChanges();
            return RedirectToAction("SocialMedia");
        }
    }
}