using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        public ActionResult Index()
        {
            var values = db.TblProject.OrderByDescending(x => x.ProjectId).ToList();
            return View(values);
        }

        public ActionResult DeleteProject(int id)
        {
            var foundId = db.TblProject.Find(id);
            db.TblProject.Remove(foundId);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditProject(int id)
        {
            var foundId = db.TblProject.Find(id);
            return View(foundId);
        }

        [HttpPost]
        public ActionResult EditProject(TblProject p)
        {
            var foundId = db.TblProject.Find(p.ProjectId);
            foundId.ProjectUrl = p.ProjectUrl;
            foundId.ProjectName = p.ProjectName;
            foundId.ProjectDescription = p.ProjectDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}