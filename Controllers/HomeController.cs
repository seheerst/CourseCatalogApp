using CourseCatalogApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CourseCatalogApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}