using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class Employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string MaNV , string TenNV , string Tuoi , string Luong)
        {
            string strResult = "Xin Chào" + MaNV + "-" + TenNV + "-" + Tuoi ;
            ViewBag.thongbao = strResult;
            return View();
        }
    }
}