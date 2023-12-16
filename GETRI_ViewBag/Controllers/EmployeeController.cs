using GETRI_ViewBag.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_ViewBag.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeModel employee = new EmployeeModel()
            {
                EmployeeId = 1,
                EmployeeName = "John",
                EmployeeSal = 10000
            };

            ViewBag.EmpId = employee.EmployeeId;
            ViewBag.EmpName = employee.EmployeeName;
            ViewBag.EmpSal = employee.EmployeeSal;
            return View();
        }
    }
}
