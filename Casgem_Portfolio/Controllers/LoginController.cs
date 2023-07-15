using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Casgem_Portfolio.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login


        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            var values = db.TblAdmin.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);

            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.AdminUserName, false);
                Session["user"] = values.AdminUserName.ToString();
                return RedirectToAction("Feature", "Admin");

            }
            else
            {
                return View();
            }


        }
    }
}