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


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SchoolBasicInformationStudent schoolbasicInformationStudent)
        {

            dbContext.SchoolBasicInformationStudents.Add(schoolbasicInformationStudent);
            try
            {
                dbContext.SaveChanges();
                ViewBag.Success = "Data inserted";
                return View();
            }
            catch
            {
                ViewBag.Error = "Something Wrong";
                
                return View();
            }

           
        }

    }
}
