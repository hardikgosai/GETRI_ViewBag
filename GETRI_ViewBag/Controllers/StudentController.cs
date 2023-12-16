using GETRI_ViewBag.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_ViewBag.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Student Details Page";
            ViewBag.Header = "Student Details";

            StudentModel studentModel = new StudentModel()
            {
                StudentId = "1",
                StudentName = "John Doe",
                StudentBranch = "CSE",
                StudentSection = "A",
                StudentGender = "Male"
            };

            ViewBag.Student = studentModel;
            return View();
        }
    }
}
