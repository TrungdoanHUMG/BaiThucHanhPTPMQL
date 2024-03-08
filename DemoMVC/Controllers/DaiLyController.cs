using System.Runtime.Serialization;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DaiLyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(DaiLy DL)
        {
            string strResult = "Xin chao : " + DL.MaDaiLy + " - " + DL.TenDaiLy +  " - " + DL.DiaChi +  " - " + DL.NguoiDaiDien +  " - " + DL.MaHTPP +  " - " + DL.NguoiDaiDien ;
            ViewBag.thongbao = strResult;
            return View();
        }
    }
}