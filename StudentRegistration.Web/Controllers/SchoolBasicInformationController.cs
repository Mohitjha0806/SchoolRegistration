using Microsoft.AspNetCore.Mvc;
using SchoolRegistration.Data.Data;
using SchoolRegistration.Entities.Model;


namespace SchoolRegistration.Web.Controllers
{
    public class SchoolBasicInformationControllers : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public SchoolBasicInformationControllers(ApplicationDbContext dbContext)
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
        public Task<IActionResult> Create(SchoolBasicInformations schoolBasicInformation)
        {
            return Task.FromResult<IActionResult>(View());
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
