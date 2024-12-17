using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel()
            {
                Name = "Student of ASP.NET Core Mastery",
                DateOfBirth = new System.DateTime(1987, 4, 4)
            };

            return View(data);
        }
    }
}
