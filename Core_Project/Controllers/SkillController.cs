using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace Core_Project.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillManager.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
            
        }
        public IActionResult DeleteSkill(int id)
        {
            var values=skillManager.TGetById(id);
            skillManager.TDelete(values);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id) 
        {
            var values=skillManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
           
            skillManager.TUpdate(skill);
            return RedirectToAction("index");
        }
    }
}
