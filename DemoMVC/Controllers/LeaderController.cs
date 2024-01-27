using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class LeaderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index( string FullName , string SĐT)
        {
            string strResult = "Xin Chào" + FullName + "-" + SĐT ;
            ViewBag.thongbao = strResult;
            return View();
        }
    }
}