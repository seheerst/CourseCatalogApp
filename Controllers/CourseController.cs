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

        public IActionResult Details(int id)
        {
            var course = Repository.GetById(id);
            return View(course);
        }

        public IActionResult List()
        {
            return View("List", Repository.Courses);
        }
    }
}