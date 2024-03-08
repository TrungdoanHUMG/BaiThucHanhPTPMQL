using System.Runtime.Serialization;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HeThongPhanPhoiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(HeThongPhanPhoi HT)
        {
            string strResult = "Xin chao : " + HT.MaHTPP + " - " + HT.TenHTPP  + "!" ;
            ViewBag.thongbao = strResult;
            return View();
        }

    }
}