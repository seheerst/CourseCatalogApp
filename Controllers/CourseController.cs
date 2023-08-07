using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseCatalogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseCatalogApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var course = new Course();
            course.Id = 1;
            course.Title = "Asp.Net Core Kursu";
            course.Description = "Bu kurs ile asp.net core ile uygulama geliştir";
            course.Image = "img1.jpg";
            return View(course);
        }

        public IActionResult Details()
        {
            var course = new Course();
            course.Id = 1;
            course.Title = "Asp.Net Core Kursu";
            course.Description = "Bu kurs ile asp.net core ile uygulama geliştir";
            course.Image = "img1.jpg";
            return View(course);
        }

        public IActionResult List()
        {

            return View("List", Repository.Courses);
        }
    }
}