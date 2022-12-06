using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = experienceManager.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var value=experienceManager.TGetById(id);
            experienceManager.TDelete(value);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values =  experienceManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("index");
        }
    }
}
