using Microsoft.AspNetCore.Mvc;
using SchoolRegistration.Entities.Model;

namespace SchoolRegistration.Web.Controllers.SchoolBasicInformation
{
    public class SchoolBasicInformationController : Controller
    {

      


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(SchoolBasicInformation schoolbasicInformation)
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
