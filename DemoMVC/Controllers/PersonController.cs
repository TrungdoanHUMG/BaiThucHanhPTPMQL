using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strResult = ps.FullName + "-" + ps.PersonID;
            ViewBag.thongbao = strResult;
            return View();
        }
    }
}