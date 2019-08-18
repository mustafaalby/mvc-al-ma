using Microsoft.AspNetCore.Mvc;
using ProjeDeneme.Models;

namespace ProjeDeneme.Controllers
{
    public class CourseController:Controller
    {
        public IActionResult  index(){
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Student student){

            return View();

        }


        public IActionResult details(){
            var course=new Course();
            course.Name="f1 kursu";
            course.description="açıklama";
            course.isPublished=true;
            return View(course);
        }
    }
}