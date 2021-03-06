using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.Repo.Contract;
using First.Models.ViewModel;
using First.DATABASE;
using First.Models;

namespace First.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee EmployeeService;
        private readonly Databasefile _Conn;
        public EmployeeController(IEmployee employee,Databasefile Conn) { EmployeeService = employee; _Conn = Conn; }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmployee(EmployeeViewModel model)
        {
            var result = EmployeeService.CreateEmployee(model);
            return RedirectToAction("Index");
        }
        public IActionResult GetEmployee()
        {
            var Query = (from E in _Conn.Employees
                         join Q in _Conn.Qualifications on E.Qf.Id equals Q.Id
                         select new EmployeeViewModel
                         {
                             Id = E.Id,
                             Name = E.Name,
                             Gender = E.Gender,
                             QualificationName = Q.Name,
                             Address = E.Address,
                             City = E.City,
                             IsActive = E.IsActive
                         }).ToList();
            return Json(Query);
        }
        public IActionResult GetQualifications()
        {
            var quali = EmployeeService.GetQualifications();
            return Json(quali);
        }
        [HttpPost]
        public IActionResult DeleteEmployee(int id)
        {
            var result = EmployeeService.DeleteEmployee(id);
            //return Json(emp);

            if (result)
            {
                return Json(new { ok = true, message = "Employee Deleted Successfully.." });
            }
            else
            {
                return Json(new { ok = false, message = "Employee Not Found.." });
            }
        }
        public IActionResult UpdateEmployee()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetEmployeeById(int id)
        {
            var emp1 = EmployeeService.GetEmployeeById(id);
            return Json(emp1);
        }
        [HttpPost]
        public IActionResult UpdateEmployee(EmployeeViewModel model)
        {
            var result = EmployeeService.UpdateEmployee(model);

            if (result != null)
            {
                return RedirectToAction("Index");
            }
            else
            {

                return Json(new { ok = false, message = "Somthing Went Wrong..." });
            }
        }
    }
}
