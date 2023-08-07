using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseCatalogApp.Controllers
{
    public class CourseController : Controller
    {
        public string Index()
        {
            return "Course/index";
        }

        public string List()
        {
            return "Course/Index";
        }
    }
}