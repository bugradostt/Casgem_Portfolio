using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    [Authorize]
    public class StatisticController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.employeeCount = db.TblEmployee.Count();
            var salary = db.TblEmployee.Max(x => x.EmployeeSalary);
            ViewBag.maxSalaryEmployee = db.TblEmployee.Where(x => x.EmployeeSalary == salary).Select(y => y.EmployeeName + " " + y.EmployeeSurname).FirstOrDefault();
            ViewBag.totalCityCount = db.TblEmployee.Select(x => x.EmployeeCity).Distinct().Count();
            ViewBag.avgEmployeeSalary = db.TblEmployee.Average(x=>x.EmployeeSalary);
            ViewBag.countSoftwareDepartment = db.TblEmployee.Where(x => x.EmployeeDepartment == db.TblDepartment.Where(z => z.DepartmentName == "Yazılım").Select(y => y.DepartmentId).FirstOrDefault()).Count();
            ViewBag.cityAnkaraOrAdanaSumSalary = db.TblEmployee.Where(x => x.EmployeeCity == "Ankara" || x.EmployeeCity == "Adana").Sum(x => x.EmployeeSalary);

            var departmentId = db.TblDepartment.Where(x => x.DepartmentName=="Yazılım").Select(y=>y.DepartmentId).FirstOrDefault();
            ViewBag.sumSalaryFromSoftwareDepartment = db.TblEmployee.Where(x => x.EmployeeCity == "Ankara" && x.EmployeeDepartment == departmentId).Sum(x => x.EmployeeSalary);
            return View();
        }
    }
}