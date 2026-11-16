using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using MVCsecond.Models;

namespace MVCsecond.Controllers
{
    
    public class StudentController : Controller
    {
        [HttpPost]
        public IActionResult Addstudent(Student student)
        {
            ViewData.Add("student", student);
            ViewData.Add("Message", "Great Start");
            return View();
        }
        public IActionResult NewStudent()
        {
            return View();
        }
    }
}

