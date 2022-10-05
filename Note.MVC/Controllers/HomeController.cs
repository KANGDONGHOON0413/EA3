using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Note.BLL;
using Note.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Note.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly NoticeBLL _noticeBLL;

         public HomeController(NoticeBLL noticeBLL)
        {
            _noticeBLL = noticeBLL;
        }

        public IActionResult Index()
        {
            ViewBag.lists = _noticeBLL.GetNoticeList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
