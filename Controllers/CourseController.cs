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

        public IActionResult List()
        {
            var courses = new List<Course>(){
               new Course{Id=1, Title="Asp.net Core Kursu", Description="Bu kurs ile asp.net core ile uygulama geliştir",Image= "img1.jpg"},
               new Course{Id=2, Title="C# Kursu", Description="Bu kurs ile C# öğren",Image= "img_2.jpg"},
               new Course{Id=3, Title="Flutter Kursu", Description="Flutter ile mobil uygulamalar geliştir",Image= "img2.jpg"},
            };
            return View(courses);
        }
    }
}