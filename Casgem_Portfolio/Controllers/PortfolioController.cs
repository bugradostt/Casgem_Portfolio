using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio

        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult _PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult _PartialFeature()
        {
            ViewBag.featureTitle = db.TblFeature.Select(x => x.FeatureTitle).FirstOrDefault();
            ViewBag.featureImageUrl = db.TblFeature.Select(x => x.FeatureImageUrl).FirstOrDefault();
            ViewBag.featureDescription = db.TblFeature.Select(x => x.FeatureDescription).FirstOrDefault();
            ViewBag.featureJobs = db.TblFeature.Select(x=>x.FeatureIJobs).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult _PartialMyResume()
        {
            var values = db.TblResume.ToList();
            return PartialView(values);
        }

        public PartialViewResult _PartialStatitistic()
        {
            ViewBag.totalService = db.TblService.Count();
            ViewBag.totalMessage = db.TblMessage.Count();
            ViewBag.totalThanksMessage = db.TblMessage.Where(x=>x.MessageSubject=="Teşekkür").Count();
            ViewBag.happyCustomer = 12;
            return PartialView();
        }

        public PartialViewResult _PartialFooter()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }

        public PartialViewResult _PartialJavascript()
        {
            return PartialView();
        }

        public PartialViewResult _PartialWhoAmI()
        {
            var value = db.TblWhoAmI.ToList();
            return PartialView(value);
        }

        public PartialViewResult _PartialService()
        {
            var values = db.TblService.OrderByDescending(x=>x.ServiceId).ToList();
            return PartialView(values);
        }

        public PartialViewResult _PartialReferance()
        {
            var values = db.TblReference.OrderByDescending(x => x.ReferenceId).ToList();
            return PartialView(values);
        }

        public PartialViewResult _PartialProject()
        {
            var values = db.TblProject.OrderByDescending(x => x.ProjectId).ToList();
            return PartialView(values);
        }
    }

}