using Microsoft.AspNetCore.Mvc;
using SchoolRegistration.Data.Data;
using SchoolRegistration.Entities.Model;

namespace SchoolRegistration.Web.Controllers.SchoolBasicInformation
{
    public class SchoolBasicInformationController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public SchoolBasicInformationController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();  
        }


        [HttpPost]
        public IActionResult Create(SchoolBasicInformations schoolbasicInformation)
        {
            if (ModelState.IsValid)
            {
                dbContext.SchoolBasicInformations.Add(schoolbasicInformation);
                dbContext.SaveChanges();

                //TempData["SuccessMessage"] = "School basic information added successfully!";
                //return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}
