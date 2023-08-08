using CourseCatalogApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CourseCatalogApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Courses);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}