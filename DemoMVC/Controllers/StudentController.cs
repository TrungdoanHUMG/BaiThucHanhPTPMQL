using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student std)
        {
            string strResult = "Hello :" + std.StudentID + "-" + std.Tuoi ; 
            ViewBag.Nhandulieu = strResult;
            return View();
        }
    }
}